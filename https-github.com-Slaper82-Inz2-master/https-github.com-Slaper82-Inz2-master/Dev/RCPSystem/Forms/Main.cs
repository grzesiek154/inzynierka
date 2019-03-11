using RCPSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPSystem.Class;

namespace RCPSystem
{
    public partial class Main : Form
    {
        public int UserID { get; set; }
        public Users User = null;
        public TimeAttandance TimeAtt= null;
        public Config Config = null;
        public DayDef DayDef = null;
        public Dict Dictonaries= null;
        public Harmo Harmo = null;
        public Transact Transact = null;
        public Orders Orders = null;

        public List<string> Priviliges = new List<string>();
    
        public Main(Priviliges.UserType type,int UserId)
        {
            this.UserID = UserId;
            Priviliges priv = new Priviliges(type);
            
            InitializeComponent();
            foreach(string p in priv.PriviligesList)
            {              
                foreach(ToolStripButton b in tsMainMenu.Items)
                {
                    if (b.Name == p)
                    {
                        b.Enabled = true;
                    }
                }
            }
        }
        private void CloseMdichilds()
        {
            this.MdiParent.MdiChildren.OfType<Users>().ToList().ForEach(x => x.Close());
        }

        private void tsbUsers_Click(object sender, EventArgs e)
        {

            if (User==null||User.IsDisposed)
            {
                User = new Users();
                User.MdiParent = this;
                User.WindowState = FormWindowState.Maximized;
                User.Show();
            }
            else
            {
                User.Focus();
            }
        }

        private void tsbTimeAtt_Click(object sender, EventArgs e)
        {
            if (TimeAtt == null || TimeAtt.IsDisposed)
            {
                TimeAtt = new TimeAttandance
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                TimeAtt.Show();
            }
            else
            {
                TimeAtt.Focus();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tsbUsers.PerformClick();
        }

        private void tsbDay_Click(object sender, EventArgs e)
        {
            if (DayDef == null || DayDef.IsDisposed)
            {
                DayDef = new DayDef
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                DayDef.Show();
            }
            else
            {
                DayDef.Focus();
            }
        }

        private void tsbHarmo_Click(object sender, EventArgs e)
        {
            if (Harmo == null || Harmo.IsDisposed)
            {
                Harmo = new Harmo();
                Harmo.MdiParent = this;
                Harmo.WindowState = FormWindowState.Maximized;
                Harmo.Show();
            }
            else
            {
                Harmo.Focus();
            }
        }

        private void tsbDict_Click(object sender, EventArgs e)
        {
            if (Dictonaries == null || Dictonaries.IsDisposed)
            {
                Dictonaries = new Dict();
                Dictonaries.MdiParent = this;
                Dictonaries.WindowState = FormWindowState.Maximized;
                Dictonaries.Show();
            }
            else
            {
                Dictonaries.Focus();
            }
        }

        private void tsbManage_Click(object sender, EventArgs e)
        {
            if (Config == null || Config.IsDisposed)
            {
                Config = new Config();
                Config.MdiParent = this;
                Config.WindowState = FormWindowState.Maximized;
                Config.Show();
            }
            else
            {
                Config.Focus();
            }
        }

        private void tsbTA_Click(object sender, EventArgs e)
        {
            if (Transact == null || Transact.IsDisposed)
            {
                Transact = new Transact(UserID);
                Transact.MdiParent = this;
                Transact.WindowState = FormWindowState.Maximized;
                Transact.Show();
            }
            else
            {
                Transact.Focus();
            }
        }

        private void tsbOrder_Click(object sender, EventArgs e)
        {
            if (Orders == null || Orders.IsDisposed)
            {
                Orders = new Orders(UserID);
                Orders.MdiParent = this;
                Orders.WindowState = FormWindowState.Maximized;
                Orders.Show();
            }
            else
            {
                Orders.Focus();
            }
        }
    }
}
