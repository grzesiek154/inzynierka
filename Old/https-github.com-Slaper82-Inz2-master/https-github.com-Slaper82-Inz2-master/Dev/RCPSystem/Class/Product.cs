using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPSystem.DbClass;

namespace RCPSystem.Class
{

    class Product
    {
        EFModel context;
        TextBox Name;
        TextBox Description;
        DataGridView dgvProd;
        DataGridView dgvElem;
        List<zadProduct> ProdList;
        public Product(TextBox _name,TextBox _descr,DataGridView _dgvProd,DataGridView _dgvElem)
        {

            context = new EFModel();
            this.Name = _name;
            this.Description = _descr;
            this.dgvProd = _dgvProd;
            this.dgvElem = _dgvElem;
            ProdList = new List<zadProduct>();
            GridProdLoad();
        }

        public void GridProdLoad()
        {
            var ProdList = new List<zadProduct>();
            ProdList = context.zadProducts.ToList();
            dgvProd.AutoGenerateColumns = false;
            dgvProd.DataSource = ProdList;
            dgvProd.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProd.AutoResizeColumns();

        }
        public void GridElemLoad(int ProdID)
        {
            var elem = (from el in context.zadElements
                        join prod in context.zadProdElems on el.IdElement equals prod.IdElement
                        where prod.IdProduct == ProdID
                        select new { Id = el.IdElement, el.Symbol, el.Name, prod.Quantity }).ToList();

            dgvElem.DataSource = elem;
            dgvElem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvElem.AutoResizeColumns();
        }

        public void ButtonAdd(string Name,string Description)
        {
            zadProduct prod = new zadProduct();
            try
            {
                prod.Name = Name;
                prod.Description = Description;
                prod.Active = true;
                context.zadProducts.Add(prod);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridProdLoad();
                this.Name.Text = String.Empty;
            }
        }

        public void BindData(int ProductID)
        {
            try
            {
                zadProduct prod = new zadProduct();
                prod = context.zadProducts.FirstOrDefault(p => p.IdProduct == ProductID);
                this.Name.Text = prod.Name;
                this.Description.Text = prod.Description;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ButtonDelete(int ProductID)
        {
            var listElem = context.zadProdElems.ToList();
            listElem = listElem.FindAll(e => e.IdProduct == ProductID);
            var Prod = context.zadProducts.FirstOrDefault(p => p.IdProduct == ProductID);
            try
            {
                foreach (zadProdElem z in listElem)
                {
                    context.zadProdElems.Attach(z);
                    context.zadProdElems.Remove(z);
                    context.SaveChanges();
                }
                context.zadProducts.Attach(Prod);
                context.zadProducts.Remove(Prod);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridProdLoad();
                this.Name.Text = String.Empty;

            }
        }
        //public void ButtonElemAdd(int ProductId,int ElementId,int Quantity)
        //{

        //    try
        //    {
        //        zadProdElem ProdElem = new zadProdElem
        //        {
        //            IdProduct = ProductId,
        //            IdElement = ElementId,
        //            Quantity = Quantity
        //        };
        //        context.zadProdElems.Add(ProdElem);
        //        context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        dgv.DataSource = null;
        //        BindGrid(ProductId);
        //        this.Quant.Text = String.Empty;
        //    }
        //}
        //public void ButtonElemDelete(int ProductId, int ElemId)
        //{
        //    var elem = context.zadProdElems.FirstOrDefault(e => e.IdProduct == ProductId && e.IdElement == ElemId);

        //    try
        //    {
        //       context.zadProdElems.Attach(elem);
        //       context.zadProdElems.Remove(elem);
        //       context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        this.Name.Text = String.Empty;
        //        BindData(ProductId);
        //    }
        //}
        public void ButtonSave(int ProductID)
        {
            try
            {
                var prod = context.zadProducts.FirstOrDefault(p => p.IdProduct == ProductID);
                prod.Description = Description.Text;
                prod.Name = Name.Text;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridProdLoad();
            }
        }
    }
}
