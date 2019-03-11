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
    public partial class Logon : Form
    {
        EFModel _context;
        public Logon()
        {
            _context = new EFModel();
            InitializeComponent();
        }

        private void Logon_Load(object sender, EventArgs e)
        {

        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            int users;
            Main main = null;
            users = _context.genLogins.Count(l => l.Login == txtLogin.Text && l.Password == txtPass.Text);
            if (users > 0)
            {
                //genUser user = new genUser();
                var user = _context.genUsers.FirstOrDefault(u => u.IdUser == (_context.genLogins.FirstOrDefault(d => d.Login == txtLogin.Text).IdUser));
                var priv = _context.genRoles.FirstOrDefault(p => p.IdRole == 1);//tmp
                switch (priv.Name)
                {
                    case "Administrator":
                         main = new Main(Class.Priviliges.UserType.Administrator,user.IdUser);
                        break;
                    case "Boss":
                         main = new Main(Class.Priviliges.UserType.Boss, user.IdUser);
                        break;
                    case "HumanResorces":
                        main = new Main(Class.Priviliges.UserType.HumanResorces, user.IdUser);
                        break;
                    case "Supervisor":
                        main = new Main(Class.Priviliges.UserType.Supervisor, user.IdUser);
                        break;
                    case "Worker":
                        main = new Main(Class.Priviliges.UserType.Worker, user.IdUser);
                        break;
                }
                this.Owner = main;
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło", "Uwaga",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void Logon_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Logon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogon.PerformClick();
            }
        }
    }
}
