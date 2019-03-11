using RCPSystems.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystems
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
            dtpStart.Value = MonthDays.FirstDayOfMonth(DateTime.Now);
            dtpStop.Value = MonthDays.LastDayOfMonth(DateTime.Now);

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
                             where t.IdUser == UserID && t.DateAndTime>=dtpStart.Value && t.DateAndTime<=dtpStop.Value
                             select new { Id = t.IdTrans, Data = t.DateAndTime, Typ_Transakcji = typ.Name, Nazwa_uzytkownika = user.Name + " " + user.Surname }).ToList();
                dgv.DataSource = trans;
            }
            if (dgv.Name == "dgvTranPairs") 
            {
                var pairs = (from p in context.rcpPairsIOs
                             join u in context.genUsers on p.IdUser equals u.IdUser
                             where p.IdUser == UserID && p.Start>=dtpStart.Value && p.Stop<=dtpStop.Value
                             select new { Nazwa = u.Name + " " + u.Surname, Poczatek = p.Start, Koniec = p.Stop }).ToList();

                dgv.DataSource = pairs;
            }
            if (dgv.Name == "dgvTimeBreak")
            {
                var pairs = (from p in context.rcpPairsOnBs
                             join u in context.genUsers on p.IdUser equals u.IdUser
                             where p.IdUser == UserID && p.Start >= dtpStart.Value && p.Stop <= dtpStop.Value
                             select new { Nazwa = u.Name + " " + u.Surname, Poczatek = p.Start, Koniec = p.Stop }).ToList();

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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoResizeColumns();
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
                DgvTranReload(UserID, dgvTimeBreak);
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
                        rcpUserHarmo harmo = new rcpUserHarmo()
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
        
        private void btnHarmoDel_Click(object sender, EventArgs e)
        {
            if (dgvUserHarmo.SelectedRows.Count > 0)
            {
                try
                {
                    int ID = Convert.ToInt32(dgvUserHarmo.SelectedRows[0].Cells["Id"].FormattedValue.ToString());
                    var harmo = context.rcpUserHarmoes.FirstOrDefault(h => h.Id == ID);
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

        private void btnCount_Click(object sender, EventArgs e)
        {
            RcpZadRep();
            RcpReport();
            RcpSum();
        }
        private void RcpZadRep()
        {
            using (var context = new EFModel())
            {
                var Id = new SqlParameter("@Id", this.UserID);
                var Start = new SqlParameter("@Start", dtpStart.Value.ToString("yyyyMMdd"));
                var Stop = new SqlParameter("@Stop", dtpStop.Value.ToString("yyyyMMdd"));


                var result = context.Database
                   .SqlQuery<RepZad>("ZadPodsumowania @Id,@Start,@Stop", Id, Start, Stop)
                   .ToList();

                dgvZad.DataSource = result;
                dgvZad.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvZad.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvZad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvZad.AutoResizeColumns();
            }
        }

        private void RcpReport()
        {
            using (var context = new EFModel())
            {
                var Id = new SqlParameter("@Id", this.UserID);
                var Start = new SqlParameter("@Start", dtpStart.Value.ToString("yyyyMMdd"));
                var Stop = new SqlParameter("@Stop", dtpStop.Value.ToString("yyyyMMdd"));

                var result = context.Database
                    .SqlQuery<ReportClass>("rcpRaport @Id,@Start,@Stop", Id, Start, Stop)
                    .ToList();

                var res = (from r in result
                           join u in context.genUsers on r.IdUser equals u.IdUser
                           select new { User = u.Name + " " + u.Surname, Data = r.Date, r.Norma, r.Odczytane, r.Przerwa, r.Braki, r.Nadgodziny, r.Transakcje }).ToList();

                dgvReport.DataSource = res;
                dgvReport.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvReport.AutoResizeColumns();
            }
        }
        private void RcpSum()
        {
            using (var context = new EFModel())
            {
                var IdS = new SqlParameter("@Id", this.UserID);
                var StartS = new SqlParameter("@Start", dtpStart.Value.ToString("yyyyMMdd"));
                var StopS = new SqlParameter("@Stop", dtpStop.Value.ToString("yyyyMMdd"));

                var sum = context.Database
                    .SqlQuery<SumClass>("RcpPodsumowania @Id,@Start,@Stop", IdS, StartS, StopS)
                    .ToList();

                lblBraki.Text = sum[0].Braki == "0:0" ? "00:00" : sum[0].Braki;
                lblNadgodziny.Text = sum[0].Nadgodziny == "*:0" ? "00:00" : sum[0].Nadgodziny;
                lblNorma.Text = sum[0].Norma;
                lblOdczytane.Text = sum[0].Odczytane;
            }
        }

    }
}
