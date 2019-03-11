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
    public partial class FrmProdAdd : Form
    {
        EFModel context;
        public event RefreshDgv Added;
        public int ProdID { get; set; }
        public FrmProdAdd()
        {
            context = new EFModel();
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            zadProduct prod = new zadProduct();
            try
            {
                prod.Active = true;
                prod.Description = txtDescription.Text;
                prod.Name = txtName.Text;
                context.zadProducts.Add(prod);
                context.SaveChanges();
                ProdID = prod.IdProduct;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Added();
                this.Close();
            }
        }
    }
}
