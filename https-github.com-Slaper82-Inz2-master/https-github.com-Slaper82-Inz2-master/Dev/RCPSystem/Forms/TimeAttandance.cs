using RCPSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem
{
    public partial class TimeAttandance : Form
    {
        EFModel context;
        TreeNode Node;
        FrmHelpers helper;
        public int UserID { get; set; }
        public genUser Users { get; set; }
        public List<genOrgUnit> ListaDep { get; set; }
        public List<genUser> UsersList { get; set; }

        public List<rcpTransactionAll>TransactionList { get; set; }

        public TimeAttandance()
        {
            context = new EFModel();
            InitializeComponent();
            ListaDep = context.genOrgUnits.ToList();
            UsersList = context.genUsers.ToList();
            helper = new FrmHelpers(tvUsers,TreeImages);
            helper.TreeLoad();
            ComboLoad();
            TransactionList = new List<rcpTransactionAll>();
            TransactionList = context.rcpTransactionAlls.ToList();
        }
        public void FormReload()
        {
            TransactionList = context.rcpTransactionAlls.ToList();
        }

        public void ComboLoad()
        {
            var Harmolist = context.rcpHarmoes.ToList();
            cmbHarChose.DataSource = Harmolist;
            cmbHarChose.DisplayMember = "HarmoName";
            cmbHarChose.ValueMember = "IdHarmo";
        }
        public void DgvTranReload(int UserID, DataGridView dgv)
        {
            if (dgv.Name == "dgvTransactions")
            {
                var trans = (from t in context.rcpTransactionAlls
                             join user in context.genUsers on t.IdUser equals user.IdUser
                             join typ in context.rcpTranTypes on t.IdTransType equals typ.IdTranType
                             where t.IdUser == UserID
                             select new { Id = t.IdTrans, Data = t.DateAndTime, Typ_Transakcji = typ.Name, Nazwa_uzytkownika = user.Name + " " + user.Surname }).ToList();
                dgv.DataSource = trans;
            }
            if (dgv.Name == "dgvTranPairs") 
            {
                var pairs = (from p in context.rcpPairsIOs
                             join u in context.genUsers on p.IdUser equals u.IdUser
                             where p.IdUser == UserID
                             select new { Name = u.Name + " " + u.Surname, Wej = p.Start, Wyj = p.Stop }).ToList();

                dgv.DataSource = pairs;
            }
            if (dgv.Name == "dgvUserHarmo")
            {
                var harmo = (from h in context.rcpUserHarmoes
                             join def in context.rcpHarmoes on h.IdHarmo equals def.IdHarmo
                             where h.IdUser == UserID
                             select new { Nazwa = def.HarmoName, Od = h.ValidFrom, Do = h.ValidTo , Id=h.Id }).ToList();
                dgv.DataSource = harmo;
            }
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.Font = new Font("SegoeUI", 14);
        }

        private void tvUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = e.Node.ImageIndex;
            UserID = 0;
            this.Users = null;
            if (index > 0)
            {
                UserID = Convert.ToInt32(e.Node.Name);
                DgvTranReload(UserID,dgvTransactions);
                DgvTranReload(UserID, dgvTranPairs);
                DgvTranReload(UserID, dgvUserHarmo);
            }
        }

        private void dgvTransactions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvTransactions.Rows[e.RowIndex].Cells["lp"].Value = (e.RowIndex + 1).ToString();
        }
        #region Harmonogram
        private void btnHarmoAdd_Click(object sender, EventArgs e)
        {
            if (UserID > 0)
            {
                if (dtpFrom.Value < dtpTo.Value)
                {
                    try
                    {
                        rcpUserHarmoList harmo = new rcpUserHarmoList()
                        {
                            IdHarmo = Convert.ToInt32(cmbHarChose.SelectedValue),
                            ValidFrom = dtpFrom.Value,
                            ValidTo = dtpTo.Value,
                            IdUser = UserID
                        };
                        context.rcpUserHarmoes.Add(harmo);
                        context.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        DgvTranReload(UserID, dgvUserHarmo);
                    }
                }
                else
                {
                    MessageBox.Show("Data od nie może być większa niż data do","Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        //ElemeID= Convert.ToInt32(dgvElem.SelectedRows[0].Cells["ElemId"].FormattedValue .ToString())
        private void btnHarmoDel_Click(object sender, EventArgs e)
        {
            if (dgvUserHarmo.SelectedRows.Count > 0)
            {
                try
                {
                    int ID = Convert.ToInt32(dgvUserHarmo.SelectedRows[0].Cells["Id"].FormattedValue.ToString());
                    var harmo = context.rcpUserHarmoes.FirstOrDefault(h => h.Id == ID);
                    //rcpUserHarmo harmo = new rcpUserHarmo()
                    //{

                    //    IdHarmo = Convert.ToInt32(dgvUserHarmo.SelectedRows[0].Cells["Id"].FormattedValue.ToString()),
                    //    ValidFrom = Convert.ToDateTime(dgvUserHarmo.SelectedRows[0].Cells["Od"].FormattedValue.ToString()),
                    //    ValidTo = Convert.ToDateTime(dgvUserHarmo.SelectedRows[0].Cells["Do"].FormattedValue.ToString()),
                    //    IdUser = UserID
                    //};
                    context.rcpUserHarmoes.Attach(harmo);
                    context.rcpUserHarmoes.Remove(harmo);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void btnBegin_Click(object sender, EventArgs e)
        {
            dtpStart.Value = MonthDays.FirstDayOfMonth(DateTime.Now);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            dtpStop.Value = MonthDays.LastDayOfMonth(DateTime.Now);
        }
    }
}
