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
    public partial class FrmElement : Form
    {
        EFModel context;
        public int ProdId { get; set; }
        public int ElemID { get; set; }

        public int ElemeIDCmb { get; set; }
        public event Refresh Added;

        public FrmElement(int _prodId)
        {
            
            this.ProdId = _prodId;
            context = new EFModel();
            context.Configuration.ProxyCreationEnabled = false;
            InitializeComponent();
            GridLoad();
            CmbLoad();
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

        private void CmbLoad()
        {
            var elem = new List<zadElement>();
            elem = context.zadElements.ToList();
            cmbElem.DataSource = elem;
            cmbElem.ValueMember = "IdElement";
            cmbElem.DisplayMember = "Name";
        }


        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (txtQuantOld.Text != String.Empty)
            {
                try
                {
                    int idelement = ElemeIDCmb;
                    var prodElem = new zadProdElem()
                    {
                        IdElement = idelement,
                        IdProduct = ProdId,
                        Quantity = Convert.ToInt32(txtQuantOld.Text)
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
                    txtQuantOld.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
            }
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
                    CmbLoad();
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

        private void cmbElem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbElem_SelectedValueChanged(object sender, EventArgs e)
        {
            string t = cmbElem.SelectedValue.ToString();

            try
            {
                zadElement test = (zadElement)cmbElem.SelectedValue;
                ElemeIDCmb = test.IdElement;
            }
            catch
            {
                ElemeIDCmb = Convert.ToInt32(cmbElem.SelectedValue.ToString());
            }         
            var el = context.zadElements.FirstOrDefault(elem => elem.IdElement.Equals(ElemeIDCmb));
            txtSymOld.Text = el.Symbol;
        }
    }
}
