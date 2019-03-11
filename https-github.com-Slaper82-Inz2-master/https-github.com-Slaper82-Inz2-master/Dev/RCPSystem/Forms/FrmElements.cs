using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Forms
{
    public partial class FrmElements : Form
    {
        EFModel context;
        public int TypeID { get; set; }
        public int ElemID { get; set; }
        List<zadElement> ElemList;
        public event RefreshDgv Ref;
        public FrmElements(int _typeID)
        {
            ElemList = new List<zadElement>();
            context = new EFModel();
            this.TypeID = _typeID;
            InitializeComponent();
            GridLoad();
        }
 
        public void GridLoad()
        {
            ElemList = context.zadElements.ToList();
            ElemList = ElemList.FindAll(e => e.IdType.Equals(1));
            dgvElems.DataSource = ElemList;
            dgvElems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvElems.AutoResizeColumns();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (ElemID > 0)
                {
                    int elementID = ElemID;
                    var elem = context.zadElements.FirstOrDefault(el => el.IdElement == elementID);
                    elem.IdType = TypeID;
                    context.Entry(elem).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Ref();
                this.Close();
            }
        }

        private void dgvElems_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvElems.SelectedRows.Count > 0)
                {
                    ElemID = Convert.ToInt32(dgvElems.SelectedRows[0].Cells["IdElement"].Value.ToString());
                }
            }
        }
    }
}
