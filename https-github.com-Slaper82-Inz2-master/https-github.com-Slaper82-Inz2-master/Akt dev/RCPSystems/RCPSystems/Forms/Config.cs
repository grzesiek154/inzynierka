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

namespace RCPSystems.Forms
{
    public partial class Config : Form
    {
        EFModel context;
        TreeNode Node;
        FrmHelpers helper;

        public int UserID { get; set; }

        public Config()
        {
            context = new EFModel();
            InitializeComponent();
            helper = new FrmHelpers(tvUsers, TreeImages);
            helper.TreeLoad();
            ComboLoad();
        }

        private void ComboLoad()
        {
            var role = context.genRoles.ToList();
            cmbRole.DataSource = role;
            cmbRole.ValueMember = "IdRole";
            cmbRole.DisplayMember = "Name";
        }
        private void tvUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = e.Node.ImageIndex;
            UserID = 0;
            var User = new genLogin();
            if (index > 0)
            {
                UserID = Convert.ToInt32(e.Node.Name);
                var UserData = context.genUsers.FirstOrDefault(u => u.IdUser == UserID);
                User = context.genLogins.FirstOrDefault(u => u.IdUser == UserID);
                if (User != null)
                {
                    txtLogin.Text = User.Login;
                    txtPass.Text = User.Password;
                    cmbRole.SelectedValue = UserData.IdRole;
                }
                else
                {
                    txtLogin.Text = String.Empty;
                    txtPass.Text = String.Empty;
                    txtPassCheck.Text = String.Empty;
                    cmbRole.SelectedValue = 5;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UserID > 0)
            {
                bool match;
                match = (txtPass.Text == txtPassCheck.Text);
                if (match)
                {
                    try
                    {
                        var exist =context.genLogins.FirstOrDefault(u => u.IdUser == UserID);
                       
                        if (exist==null)
                        {
                            var Ulogin = new genLogin()
                            {
                                IdUser = UserID,
                                Login = txtLogin.Text,
                                Password = txtPass.Text
                            };
                            context.genLogins.Add(Ulogin);
                            context.SaveChanges();

                            var user = context.genUsers.FirstOrDefault(u => u.IdUser == UserID);
                            user.IdRole = Convert.ToInt32(cmbRole.SelectedValue);
                            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                        }
                        else
                        {
                            exist.Login = txtLogin.Text;
                            exist.Password = txtPass.Text;
                            context.Entry(exist).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();

                            var user = context.genUsers.FirstOrDefault(u => u.IdUser == UserID);
                            user.IdRole = Convert.ToInt32(cmbRole.SelectedValue);
                            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                        }
                        MessageBox.Show("Zapisano");
                        txtPassCheck.Text = String.Empty;
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Hasła do siebie nie pasują!");
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać pracownika");
            }
        }
    }
}
