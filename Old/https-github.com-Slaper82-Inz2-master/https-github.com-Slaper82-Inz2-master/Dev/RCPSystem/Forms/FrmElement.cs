using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPSystem.DbClass;

namespace RCPSystem.Forms
{
    public partial class FrmElement : Form
    {
        EFModel context;
        public int ProdId { get; set; }
        public int ElemID { get; set; }
        public event Refresh Added;

        public FrmElement(int _prodId)
        {
            this.ProdId = _prodId;
            context = new EFModel();
            InitializeComponent();
            GridLoad();
        }

        public void GridLoad()
        {
            var elem = (from el in context.zadElements
                        join prod in context.zadProdElems on el.IdElement equals prod.IdElement
                        where prod.IdProduct == ProdId
                        select new { Id = el.IdElement,el.Symbol, el.Name, prod.Quantity }).ToList();

            dgvElem.DataSource = elem;
            dgvElem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvElem.AutoResizeColumns();
        }

        private void btnAddElem_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty && txtSymbol.Text != String.Empty && txtQuan.Text != String.Empty)
            {
                try
                {
                    var elem = new zadElement()
                    {
                        Name = txtName.Text,
                        Active = true,
                        Symbol = txtSymbol.Text,
                        IdType = 1
                    };
                    context.zadElements.Add(elem);
                    context.SaveChanges();
                    int idelement = elem.IdElement;
                    var prodElem = new zadProdElem()
                    {
                        IdElement = idelement,
                        IdProduct = ProdId,
                        Quantity = Convert.ToInt32(txtQuan.Text)
                    };
                    context.zadProdElems.Add(prodElem);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    GridLoad();
                    Added(ProdId);
                    txtName.Text = String.Empty;
                    txtSymbol.Text = String.Empty;
                    txtQuan.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
            } 
        }

        private void btnPodElemeDel_Click(object sender, EventArgs e)
        {
            if (ElemID > 0)
            {
                try
                {
                    var elem = context.zadProdElems.FirstOrDefault(el => el.IdElement.Equals(ElemID) && el.IdProduct.Equals(ProdId));
                    context.zadProdElems.Attach(elem);
                    context.zadProdElems.Remove(elem);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    GridLoad();
                    Added(ProdId);
                }
            }
        }

        private void dgvElem_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvElem.SelectedRows.Count > 0)
                {
                    ElemID = Convert.ToInt32(dgvElem.SelectedRows[0].Cells["Id"].Value.ToString());
                }
            }
        }
    }
}
