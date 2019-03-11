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
    public delegate void ReloadValue();
    public partial class Orders : Form
    {
        public int UserId { get; set; }
        public int OrderID { get; set; }
        NewOrder NewOrder;
        EFModel context;

        public Orders(int userId)
        {
            this.UserId = userId;
            context = new EFModel();
            InitializeComponent();
            GridReload();
        }

        public void GridReload()
        {
            //var OrdersList = new List<zadOrder>();
            var OrderList = (from o in context.zadOrders
                            join c in context.zadClients on o.IdClient equals c.IdClient
                            join u in context.genUsers on o.IdUser equals u.IdUser
                            where o.Active==true
                            select new {IdZamowienia=o.IdOrder,Utworzono=o.CreateDate,u.Name,Opis=o.Description,Klient=c.Name,o.Active,o.Done}).ToList();
            //OrderList = context.zadOrders.ToList();
            //OrderList = OrdersList.FindAll(o => o.Active == true);
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = OrderList;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrders.AutoResizeColumns();
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            NewOrder = new NewOrder(UserId);
            NewOrder.Reload +=GridReload;
            NewOrder.ShowDialog();
        }

        //private void GridReload(object sender, EventArgs e)
        //{
        //    var OrdersList = new List<zadOrder>();
        //    OrdersList = context.zadOrders.ToList();
        //    OrdersList = OrdersList.FindAll(o => o.Active == true);

        //    dgvOrders.DataSource = OrdersList;
        //}

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (OrderID>0)
            {
                NewOrder edit =new NewOrder(UserId, OrderID);
                edit.ShowDialog();
            }
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            //dodać potwierdzenie
            if (OrderID > 0)
            {
                try
                {
                    //usuwanie z listy zamówień
                    var order = context.zadOrders.FirstOrDefault(o => o.IdOrder.Equals(OrderID));
                    order.Active = false;
                    context.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    //usuwanie z tasków
                    var tasks = context.zadTaskLists.ToList();
                    tasks = tasks.FindAll(t => t.IdOrder.Equals(OrderID));

                    foreach(var t in tasks)
                    {
                        t.Active = false;
                        context.Entry(t).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        //kończenie pracy nad taskiem
                        var zad = context.zadTaskProductions.ToList();
                        zad = zad.FindAll(z => z.IdTask == t.IdTask);
                        if (zad.Count > 0)
                        {
                            foreach (var z in zad)
                            {
                                z.Stop = DateTime.Now;
                                z.Active = false;
                                context.Entry(z).State = System.Data.Entity.EntityState.Modified;
                                context.SaveChanges();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    GridReload();
                }
            }
            else
            {
                MessageBox.Show("Wybierz zamówienie");
            }

        }

        private void dgvOrders_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    OrderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["IdZam"].Value.ToString());
                }

            }
        }
    }
}
