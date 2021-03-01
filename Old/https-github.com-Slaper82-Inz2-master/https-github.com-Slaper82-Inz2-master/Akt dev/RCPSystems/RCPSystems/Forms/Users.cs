using RCPSystems.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystems
{
    public partial class Users : Form
    {
        EFModel context;
        TreeNode Node;
        FrmHelpers helper;
        public int UserID { get; set; }
        public genUser User { get; set;}
        public genOrgUnitPriv Org { get; set; }
        public genUserDet UserDet { get; set; }
        public List<genOrgUnit> ListaDep { get; set; }
        public List<genUser> UsersList { get; set; }

        public int DutyID { get; set; }

        public  bool Open;
        public Users()
        {
            context = new EFModel();
            InitializeComponent();
            Node = new TreeNode();
            ListaDep = context.genOrgUnits.ToList();
            UsersList = context.genUsers.ToList();
            helper = new FrmHelpers(tvUser,TreeImages);
            comboLoad();
            dgvLoad();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            helper.TreeLoad();
        }

        private void comboLoad()
        {
            var dut = context.zadDuties.ToList();  
            cmbObow.DataSource = dut; 
            cmbObow.ValueMember = "IdDuty";
            cmbObow.DisplayMember = "Name";
        }

        private void dgvLoad()
        {
            if (UserID > 0)
            {
                var usrDuty = (from d in context.zadUserDuties
                               join u in context.zadDuties on d.IdDuty equals u.IdDuty
                               where d.IdUser == UserID
                               select new { Nazwa=u.Name, u.IdDuty }).ToList();

                dgvDuty.DataSource = usrDuty;
                dgvDuty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDuty.AutoResizeColumns();

            }
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
       
        private void tvUser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = e.Node.ImageIndex;
            UserID = 0;
            this.User = null;
            if (index > 0)
            {
                UserID = Convert.ToInt32(e.Node.Name);
                this.User = context.genUsers.First(u => u.IdUser == this.UserID);
                this.UserDet = context.genUserDets.FirstOrDefault(d => d.IdUser == this.UserID);
                             
                txtName.Text = User.Name;
                txtSurname.Text = User.Surname;
                
                txtCity.Text = UserDet== null ? String.Empty: UserDet.City;
                txtBirthPlace.Text = UserDet == null ? String.Empty : UserDet.PlaceBirth;
                if (UserDet != null)
                {
                    try
                    {
                        dtpBirthDate.Value = (DateTime)UserDet.DateBirth;
                    }
                    catch
                    {
                        dtpBirthDate.Value = DateTime.Now;
                    }
                }
                         
                List<genOrgUnit> selected = new List<genOrgUnit>();
                selected = (from dept in context.genOrgUnits
                                        join priv in context.genOrgUnitPrivs on dept.IdOrgUnit equals priv.IdOrgUnit
                                        where priv.IdUser == UserID
                                        select dept).ToList();
                cmbDept.DataSource = selected;
                cmbDept.DisplayMember = "Name";
                cmbDept.ValueMember = "IdOrgUnit";
                dgvLoad();
            }           
        }
        private void EnableDisableControls()
        {

            foreach (var c in this.Controls)
            {
                foreach (var x in gbUser.Controls)
                {
                    if (x is TextBox)
                    {
                       ((TextBox)x).Text = String.Empty;
                    }
                }
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
             EnableDisableControls();
            this.User = null;
            this.UserID = 0;
            cmbDept.DataSource = context.genOrgUnits.ToList();
            cmbDept.DisplayMember = "Name";
            cmbDept.ValueMember = "IdOrgUnit";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit(this.UserID);
            tvUser.Nodes.Clear();
            helper.TreeLoad();
            tvUser.ExpandAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var user = new genUser();
            var userDet = new genUserDet();
            var Org = new genOrgUnitPriv();
           
            if (UserID != 0)
            {
                DialogResult del= MessageBox.Show("Czy na pewno chcesz usunąć wybranego pracownika?","Uwaga",MessageBoxButtons.OKCancel);
                if (del == DialogResult.OK)
                {
                    try
                    {
                        userDet = context.genUserDets.FirstOrDefault(u => u.IdUser == UserID);
                        context.genUserDets.Attach(userDet);
                        context.genUserDets.Remove(userDet);
                        context.SaveChanges();

                        Org = context.genOrgUnitPrivs.FirstOrDefault(o => o.IdUser == UserID);
                        context.genOrgUnitPrivs.Attach(Org);
                        context.genOrgUnitPrivs.Remove(Org);
                        context.SaveChanges();

                        user = context.genUsers.FirstOrDefault(u => u.IdUser == UserID);
                        context.genUsers.Attach(user);
                        context.genUsers.Remove(user);
                        context.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        EnableDisableControls();
                        tvUser.Nodes.Clear();
                        helper.TreeLoad();
                        tvUser.ExpandAll();          
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz pracownika!");
            }

        }
        private void SaveOrEdit(int UserID)
        {
            bool IsEdited = true;    
            if (UserID>0)
            {
                User = context.genUsers.FirstOrDefault(u => u.IdUser == UserID);
                UserDet = context.genUserDets.FirstOrDefault(u => u.IdUser == UserID);
                Org = context.genOrgUnitPrivs.FirstOrDefault(u => u.IdUser == UserID);
            }
            else
            {
                 User = new genUser();
                 UserDet = new genUserDet();
                 Org = new genOrgUnitPriv();
                 IsEdited = false;
            }
            try
            {
                if (User != null && UserDet != null && Org != null)
                {
                    User.Name = txtName.Text;
                    User.Surname = txtSurname.Text;
                    User.IdRole = 5;
                    User.Active = 1;
                    if(!IsEdited) context.genUsers.Add(User);

                    if (User.Surname == String.Empty) MessageBox.Show("Wystąpił problem z zapisem, ponieważ brakuje pola: Nazwisko ", "Nieprawidłowe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        context.SaveChanges();


                        UserDet.PlaceBirth = txtBirthPlace.Text;
                        UserDet.IsWoman = cmbGender.Text == "Kobieta" ? true : false;
                        UserDet.ZipCode = mtxtPost.Text;
                        UserDet.IdUser = User.IdUser;
                        UserDet.DateBirth = dtpBirthDate.Value;
                        UserDet.Adrress = txtAddress.Text;
                        UserDet.City = txtCity.Text;
                        if (!IsEdited) context.genUserDets.Add(UserDet);
                        context.SaveChanges();

                        Org.IdUser = User.IdUser;
                        Org.IdOrgUnit = Convert.ToInt32(cmbDept.SelectedValue);
                        Org.Active = true;
                        if (!IsEdited) context.genOrgUnitPrivs.Add(Org);
                        context.SaveChanges();
                        MessageBox.Show("Dane zostały zapisane", "Nowy pracownik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Wystąpiły problemy....");
                }
            
           
               
            }
            catch (Exception exc)
            {
                    MessageBox.Show("Wystąpił problem z zapisem, ponieważ: " + exc.Data, "Nieprawidłowe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObowAdd_Click(object sender, EventArgs e)
        {
            if (UserID > 0)
            {
                int duty = Convert.ToInt32(cmbObow.SelectedValue);
                bool isOnList = false;
                var test = context.zadUserDuties.ToList();
                test = test.FindAll(t => t.IdDuty == duty && t.IdUser == UserID);
                isOnList = (test.Count == 0);
                try
                {
                    if (isOnList)
                    {
                        var usrDut = new zadUserDuty
                        {
                            IdDuty = Convert.ToInt32(cmbObow.SelectedValue),
                            IdUser = UserID
                        };
                        context.zadUserDuties.Add(usrDut);
                        context.SaveChanges();
                        dgvLoad();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (UserID > 0 && DutyID>0)
            {
                try
                {
                    var usrDut = context.zadUserDuties.ToList();
                    var selected = usrDut.FirstOrDefault(d => d.IdUser == UserID && d.IdDuty == DutyID);
                    context.zadUserDuties.Attach(selected);
                    context.zadUserDuties.Remove(selected);
                    context.SaveChanges();
                    dgvLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvDuty_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvDuty.SelectedRows.Count > 0)
                {
                    DutyID = Convert.ToInt32(dgvDuty.SelectedRows[0].Cells["IdDuty"].Value.ToString());
                }

            }
        }
    }
}
