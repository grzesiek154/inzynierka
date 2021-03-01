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
    public partial class DayDef : Form
    {
        EFModel context = null;
        TreeNode Node;
        public rcpDay Day { get; set; }
        public int DayID { get; set; }

        public DayDef()
        {
            context = new EFModel();
            InitializeComponent();
            TreeLoad(Node);
        }
        public void TreeLoad(TreeNode node)
        {
            var DayDefs = context.rcpDays.ToList();
            DayDefs.ForEach(delegate (rcpDay dep)
            {
                node = new TreeNode();
                node.Text = dep.Name;
                node.Name = dep.IdDay.ToString();
                tvDay.Nodes.Add(node);
            });
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ClearControls();
            Day = null;
            DayID = 0;
        }
        private void ClearControls()
        {

            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                    foreach (var x in gbStart.Controls)
                    {
                        if (x is TextBox)
                        {
                            ((TextBox)x).Text = String.Empty;
                     
                        }
                        if(x is MaskedTextBox)
                        {
                            ((MaskedTextBox)x).Text = String.Empty;
                        }
                    }
                    foreach (var x in gbStop.Controls)
                    {
                        if (x is TextBox)
                        {
                            ((TextBox)x).Text = String.Empty;
                        }
                        if (x is MaskedTextBox)
                        {
                            ((MaskedTextBox)x).Text = String.Empty;
                        }
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsEdited = true;
            if (this.Day == null)
            {
                this.Day = new rcpDay();
                IsEdited = false;
            }
            else
            {
                this.Day = context.rcpDays.First(d => d.IdDay == this.Day.IdDay);
            }
            Day.Active = true;
            Day.Break = Convert.ToInt16(txtBreak.Text);
            Day.CStart = TimeSpan.Parse(mtxtStart.Text);
            Day.CStop = TimeSpan.Parse(mtxtEnd.Text);

            Day.IEarly = Convert.ToInt16(txtEarly.Text);
            Day.ILate = Convert.ToInt16(txtLate.Text);

            Day.OEarly = Convert.ToInt16(txtEndEarly.Text);
            Day.OLate = Convert.ToInt16(txtEndLate.Text);
            Day.Name = txtName.Text;
            if(!IsEdited)context.rcpDays.Add(Day);
            context.SaveChanges();
            tvDay.Nodes.Clear();
            TreeLoad(Node);
        }

        private void tvDay_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DayID = Convert.ToInt32(e.Node.Name);
            this.Day = context.rcpDays.First(d => d.IdDay== this.DayID);

            txtBreak.Text = Day.Break.ToString();
            txtEarly.Text = Day.IEarly.ToString();
            txtLate.Text = Day.ILate.ToString();

            txtEndEarly.Text = Day.OEarly.ToString();
            txtEndLate.Text = Day.OLate.ToString();
            txtName.Text = Day.Name;

            mtxtStart.Text = Day.CStart.ToString();
            mtxtEnd.Text = Day.CStop.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (DayID != 0)
            {
                DialogResult del = MessageBox.Show("Czy na pewno chcesz usunąć wybraną dniówkę?", "Uwaga", MessageBoxButtons.OKCancel);
                if (del == DialogResult.OK)
                {
                    try
                    {
                        Day = context.rcpDays.FirstOrDefault(u => u.IdDay == DayID);
                        context.rcpDays.Attach(Day);
                        context.rcpDays.Remove(Day);
                        context.SaveChanges();

                        tvDay.Nodes.Clear();
                        TreeLoad(Node);
                        ClearControls();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz dniówkę!");
            }
        }
    }
}
