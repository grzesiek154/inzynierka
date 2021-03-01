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
    public partial class FrmDuty : Form
    {
        EFModel context;
        public int DutyID { get; set; }
        public int TypeID { get; set; }
        public event Refresh Changed;
        public FrmDuty(int _dutyId)
        {
            this.DutyID = _dutyId;
            context = new EFModel();
            InitializeComponent();
            LeftGridLoad();
            RightGridLoad(_dutyId);
        }

        public void LeftGridLoad()
        {
            var list = (from types in context.zadTypes
                        join duty in context.zadDutyTypes on types.IdType equals duty.IdType into ps
                        from p in ps.DefaultIfEmpty()
                        where p.IdDuty != DutyID 
                        select new { types.IdType,types.TypeName /*, test2 = p==null ? 0 : p.IdType*/ }).ToList();
            dgvTyp.DataSource = list;
            dgvTyp.AutoGenerateColumns = false;
            dgvTyp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTyp.AutoResizeColumns();
            dgvTyp.Refresh();
        }

        public void RightGridLoad(int dutyID)
        {
            var list = (from types in context.zadTypes
                        join duty in context.zadDutyTypes on types.IdType equals duty.IdType
                        where duty.IdDuty == dutyID
                        select new { types.IdType,types.TypeName }).ToList();
            dgvSelected.DataSource = list;
            dgvSelected.AutoGenerateColumns = false;
            dgvSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSelected.AutoResizeColumns();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TypeID > 0)
            {
                var type = context.zadTypes.FirstOrDefault(t => t.IdType == TypeID);
                var typ = new zadDutyType()
                {
                    IdDuty=DutyID,
                    IdType=TypeID,
                    Name=String.Empty
                };
                context.zadDutyTypes.Add(typ);
                context.SaveChanges();
                LeftGridLoad();
                RightGridLoad(DutyID);
                Changed(DutyID);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (TypeID > 0)
            {
                var type = context.zadTypes.FirstOrDefault(t => t.IdType == TypeID);
                var typ = context.zadDutyTypes.FirstOrDefault(t => t.IdDuty == DutyID && t.IdType == TypeID);
                context.zadDutyTypes.Attach(typ);
                context.zadDutyTypes.Remove(typ);
                context.SaveChanges();
                LeftGridLoad();
                RightGridLoad(DutyID);
                Changed(DutyID);
            }
        }

        private void dgvTyp_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvTyp.SelectedRows.Count > 0)
                {
                    TypeID = Convert.ToInt32(dgvTyp.SelectedRows[0].Cells["IdTypeL"].Value.ToString());
                }

            }
        }

        private void dgvSelected_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvSelected.SelectedRows.Count > 0)
                {
                    TypeID = Convert.ToInt32(dgvSelected.SelectedRows[0].Cells["IdTypeR"].Value.ToString());
                }

            }
        }
    }
}
