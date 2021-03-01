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
    public partial class Harmo : Form
    {
        EFModel context;
        TreeNode Node;
        public rcpHarmo Harmonogram { get; set; }
        public rcpHarmoDef MonDef { get; set; }
        public rcpHarmoDef TueDef { get; set; }
        public rcpHarmoDef WedDef { get; set; }
        public rcpHarmoDef ThuDef { get; set; }
        public rcpHarmoDef FriDef { get; set; }
        public rcpHarmoDef SatDef { get; set; }
        public rcpHarmoDef SunDef { get; set; }
        public int HarmoID { get; set; }

        public Harmo()
        {
            context = new EFModel();
            InitializeComponent();
            TreeLoad(Node);
        }
        private void TreeLoad(TreeNode node)
        {
            var Harmons = context.rcpHarmoes.ToList();
            Harmons.ForEach(delegate (rcpHarmo dep)
            {
                node = new TreeNode();
                node.Text = dep.HarmoName;
                node.Name = dep.IdHarmo.ToString();
                tvHarmo.Nodes.Add(node);
            });
        }

        private void tvHarmo_AfterSelect(object sender, TreeViewEventArgs e)
        {

            this.HarmoID = Convert.ToInt32(e.Node.Name);
            this.Harmonogram = context.rcpHarmoes.FirstOrDefault(h => h.IdHarmo == HarmoID);
            txtHarmoName.Text = context.rcpHarmoes.FirstOrDefault(h => h.IdHarmo == HarmoID).HarmoName;
            ComboLoad();
            //pon
            if(context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 2) != null)
            {
                cmbMon.SelectedValue = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 2).IdDay;
                chbMonday.Checked = false;
            }
            else
            {
                chbMonday.Checked = true;
            }
            //wto
            if(context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 3) != null)
            {
                chbTuesday.Checked = false;
                cmbTue.SelectedValue = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 3).IdDay;        
            }
            else
            {
                chbTuesday.Checked = true;
            }
            //sro
            if(context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 4) != null)
            {
                chbWednesday.Checked = false;
                cmbWed.SelectedValue = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 4).IdDay;              
            }
            else
            {
                chbWednesday.Checked = true;
            }
            //czw
            if(context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 5) != null)
            {
                chbThursday.Checked = false;
                int test = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 5).IdDay;
                cmbThur.SelectedValue = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 5).IdDay;           
            }
            else
            {
                chbThursday.Checked = true;
            }
            //pia
            if(context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 6) != null)
            {
                chbFriday.Checked = false;
                cmbFri.SelectedValue = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 6).IdDay;
            }
            else
            {
                chbFriday.Checked = true;
            }
            //sob
            if(context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 7)!=null)
            {
                cmbSat.SelectedValue = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 7).IdDay;
                chbSaturday.Checked = false;
            }
            else
            {
                chbSaturday.Checked = true;
            }
            //niedz
            if(context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 1) != null)
            {
                cmbSun.SelectedValue = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 1).IdDay;
                chbSunday.Checked = false;
            }
            else
            {
                chbSunday.Checked = true;
            }
            

        }

        private void ComboLoad()
        {
            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    var DayList = new List<rcpDay>();
                    DayList = context.rcpDays.ToList();
                    ((ComboBox)c).DataSource = DayList;
                    ((ComboBox)c).DisplayMember = "Name";
                    ((ComboBox)c).ValueMember = "IdDay";
                }
            }
        }

        private void btnAddHarmo_Click(object sender, EventArgs e)
        {
            txtHarmoName.Text = String.Empty;
            HarmoID = 0;
            Harmonogram = null;
            ComboLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool IsEdited = (HarmoID > 0);
            if (this.Harmonogram != null)
            {
                MonDef = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 2);
                TueDef= context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 3);
                WedDef = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 4);
                ThuDef = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 5);
                FriDef = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 6);
                SatDef = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 7);
                SunDef = context.rcpHarmoDefs.FirstOrDefault(h => h.IdHarmo == HarmoID && h.WDay == 1);
            }
            else
            {
                MonDef = new rcpHarmoDef();
                TueDef = new rcpHarmoDef();
                WedDef = new rcpHarmoDef();
                ThuDef = new rcpHarmoDef();
                FriDef = new rcpHarmoDef();
                SatDef = new rcpHarmoDef();
                SunDef = new rcpHarmoDef();
                //IsEdited = false;
            }
            if (!IsEdited)
            {
                var NewHarmo = new rcpHarmo();
                NewHarmo.HarmoName = txtHarmoName.Text;
                context.rcpHarmoes.Add(NewHarmo);
                context.SaveChanges();
                this.HarmoID = NewHarmo.IdHarmo;
            }
            if (HarmoID > 0)
            {
                
                #region Poniedziałek
                if (!chbMonday.Checked)
                {
                    if (MonDef == null)
                    {
                        MonDef = new rcpHarmoDef();
                        MonDef.IdHarmo = HarmoID;
                        MonDef.WDay = 2;
                        MonDef.IdDay = Convert.ToInt16(cmbMon.SelectedValue);
                        context.rcpHarmoDefs.Add(MonDef);
                        context.SaveChanges();
                    }
                    else
                    {
                        MonDef.IdHarmo = HarmoID;
                        MonDef.WDay = 2;
                        MonDef.IdDay = Convert.ToInt16(cmbMon.SelectedValue);
                        if (!IsEdited) context.rcpHarmoDefs.Add(MonDef);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (IsEdited&&MonDef!=null)
                    {
                        context.rcpHarmoDefs.Attach(MonDef);
                        context.rcpHarmoDefs.Remove(MonDef);
                        context.SaveChanges();
                    }
                }
                #endregion Poniedziałek
                #region Wtorek
                if (!chbTuesday.Checked)
                {
                    if (TueDef == null)
                    {
                        TueDef = new rcpHarmoDef();
                        TueDef.IdHarmo = HarmoID;
                        TueDef.WDay = 3;
                        TueDef.IdDay = Convert.ToInt16(cmbTue.SelectedValue);
                        context.rcpHarmoDefs.Add(TueDef);
                        context.SaveChanges();
                    }
                    else
                    {
                        TueDef.IdHarmo = HarmoID;
                        TueDef.WDay = 3;
                        TueDef.IdDay = Convert.ToInt16(cmbTue.SelectedValue);
                        if (!IsEdited) context.rcpHarmoDefs.Add(TueDef);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (IsEdited&&TueDef!=null)
                    {
                        context.rcpHarmoDefs.Attach(TueDef);
                        context.rcpHarmoDefs.Remove(TueDef);
                        context.SaveChanges();
                    }
                }
                #endregion Wtorek
                #region Sroda
                if (!chbWednesday.Checked)
                {
                    if (WedDef == null)
                    {
                        WedDef = new rcpHarmoDef();
                        WedDef.IdHarmo = HarmoID;
                        WedDef.WDay = 4;
                        WedDef.IdDay = Convert.ToInt16(cmbWed.SelectedValue);
                        context.rcpHarmoDefs.Add(WedDef);
                        context.SaveChanges();
                    }
                    else
                    {
                        WedDef.IdHarmo = HarmoID;
                        WedDef.WDay = 4;
                        WedDef.IdDay = Convert.ToInt16(cmbWed.SelectedValue);
                        if (!IsEdited) context.rcpHarmoDefs.Add(WedDef);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (IsEdited&&WedDef!=null)
                    {
                        context.rcpHarmoDefs.Attach(WedDef);
                        context.rcpHarmoDefs.Remove(WedDef);
                        context.SaveChanges();
                    }
                }
                #endregion Sroda
                #region Czwartek
                if (!chbThursday.Checked)
                {
                    if (ThuDef == null)
                    {
                        ThuDef = new rcpHarmoDef();
                        ThuDef.IdHarmo = HarmoID;
                        ThuDef.WDay = 5;
                        ThuDef.IdDay = Convert.ToInt16(cmbThur.SelectedValue);
                        context.rcpHarmoDefs.Add(ThuDef);
                        context.SaveChanges();
                    }
                    else
                    {
                        ThuDef.IdHarmo = HarmoID;
                        ThuDef.WDay = 5;
                        ThuDef.IdDay = Convert.ToInt16(cmbThur.SelectedValue);
                        if (!IsEdited) context.rcpHarmoDefs.Add(ThuDef);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (IsEdited&&ThuDef!=null)
                    {
                        context.rcpHarmoDefs.Attach(ThuDef);
                        context.rcpHarmoDefs.Remove(ThuDef);
                        context.SaveChanges();
                    }
                }
                #endregion Czwartek
                #region Piatek
                if (!chbFriday.Checked)
                {
                    if (FriDef == null)
                    {
                        FriDef = new rcpHarmoDef();
                        FriDef.IdHarmo = HarmoID;
                        FriDef.WDay = 6;
                        FriDef.IdDay = Convert.ToInt16(cmbFri.SelectedValue);
                        context.rcpHarmoDefs.Add(FriDef);
                        context.SaveChanges();
                    }
                    else
                    {
                        FriDef.IdHarmo = HarmoID;
                        FriDef.WDay = 6;
                        FriDef.IdDay = Convert.ToInt16(cmbFri.SelectedValue);
                        if (!IsEdited) context.rcpHarmoDefs.Add(FriDef);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (IsEdited&&FriDef!=null)
                    {
                        context.rcpHarmoDefs.Attach(FriDef);
                        context.rcpHarmoDefs.Remove(FriDef);
                        context.SaveChanges();
                    }
                }
                #endregion Piatek
                #region Sobota
                if (!chbSaturday.Checked)
                {
                    if (SatDef == null)
                    {
                        SatDef = new rcpHarmoDef();
                        SatDef.IdHarmo = HarmoID;
                        SatDef.WDay = 7;
                        SatDef.IdDay = Convert.ToInt16(cmbSat.SelectedValue);
                        context.rcpHarmoDefs.Add(SatDef);
                        context.SaveChanges();
                    }
                    else
                    {
                        SatDef.IdHarmo = HarmoID;
                        SatDef.WDay = 7;
                        SatDef.IdDay = Convert.ToInt16(cmbSat.SelectedValue);
                        if (!IsEdited) context.rcpHarmoDefs.Add(SatDef);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (IsEdited&&SatDef!=null)
                    {
                        context.rcpHarmoDefs.Attach(SatDef);
                        context.rcpHarmoDefs.Remove(SatDef);
                        context.SaveChanges();
                    }
                }
                #endregion Sobota
                #region Niedziela
                if (!chbSunday.Checked)
                {
                    if (SunDef == null)
                    {
                        SunDef = new rcpHarmoDef();
                        SunDef.IdHarmo = HarmoID;
                        SunDef.WDay = 1;
                        SunDef.IdDay = Convert.ToInt16(cmbSun.SelectedValue);
                        context.rcpHarmoDefs.Add(SunDef);
                        context.SaveChanges();
                    }
                    else
                    {
                        SunDef.IdHarmo = HarmoID;
                        SunDef.WDay = 1;
                        SunDef.IdDay = Convert.ToInt16(cmbSun.SelectedValue);
                        if (!IsEdited) context.rcpHarmoDefs.Add(SunDef);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (IsEdited&&SunDef!=null)
                    {
                        context.rcpHarmoDefs.Attach(SunDef);
                        context.rcpHarmoDefs.Remove(SunDef);
                        context.SaveChanges();
                    }
                }
                #endregion Niedziela
            }
            else
            {
                MessageBox.Show("Wystąpił problem z zapisem z powodu braku IDHarmo");
            }
            tvHarmo.Nodes.Clear();
            TreeLoad(Node);

        }
        #region Checkbox events
        private void chbMonday_CheckedChanged(object sender, EventArgs e)
        {
            if(chbMonday.Checked) cmbMon.Enabled = false;
            else cmbMon.Enabled = true;
        }

        private void chbTuesday_CheckedChanged(object sender, EventArgs e)
        {
            if(chbTuesday.Checked) cmbTue.Enabled = false;
            else cmbTue.Enabled = true;
        }

        private void chbWednesday_CheckedChanged(object sender, EventArgs e)
        {
            if (chbWednesday.Checked) cmbWed.Enabled = false;
            else cmbWed.Enabled = true;
        }

        private void chbThursday_CheckedChanged(object sender, EventArgs e)
        {
            if (chbThursday.Checked) cmbThur.Enabled = false;
            else cmbThur.Enabled = true;
        }

        private void chbFriday_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFriday.Checked) cmbFri.Enabled = false;
          else  cmbFri.Enabled = true;
        }

        private void chbSaturday_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSaturday.Checked) cmbSat.Enabled = false;
            else cmbSat.Enabled = true;
        }

        private void chbSunday_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSunday.Checked) cmbSun.Enabled = false;
           else cmbSun.Enabled = true;
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (HarmoID > 0)
            {
                DialogResult = MessageBox.Show("Czy na pewno usunąć wybrany harmonogram?", "Usuwanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.OK)
                {
                    bool Deleted = true;
                    try
                    {
                        List<rcpHarmoDef> ToDelete = new List<rcpHarmoDef>();
                        ToDelete = (from def in context.rcpHarmoDefs
                                    join day in context.rcpHarmoes on def.IdHarmo equals day.IdHarmo
                                    where day.IdHarmo == HarmoID
                                    select def).ToList();
                        foreach (var def in ToDelete)
                        {
                            context.rcpHarmoDefs.Attach(def);
                            context.rcpHarmoDefs.Remove(def);
                            context.SaveChanges();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Deleted = false;
                    }
                    if (Deleted)
                    {
                        var harmo = context.rcpHarmoes.FirstOrDefault(h => h.IdHarmo == HarmoID);
                        context.rcpHarmoes.Attach(harmo);
                        context.rcpHarmoes.Remove(harmo);
                        context.SaveChanges();
                    }
                    txtHarmoName.Text = String.Empty;
                    tvHarmo.Nodes.Clear();
                    TreeLoad(Node);
                }
            }
        }
    }
}
