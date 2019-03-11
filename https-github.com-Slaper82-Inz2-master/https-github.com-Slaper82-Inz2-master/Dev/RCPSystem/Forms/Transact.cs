using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Forms
{
    public partial class Transact : Form
    {
        EFModel context;
        public int UserID { get; set; }
        public int TaskID { get; set; }

        public int MyTaskID { get; set; }
        public string ErrorMessage { get; set; }
        public Transact(int _userId)
        {
            this.UserID = _userId;
            context = new EFModel();
            InitializeComponent();
            dgvTaskLoad();
            dgvMyTaskLoad();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Start"));
            TranAdd(tranType.IdTranType,out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Stop"));
            TranAdd(tranType.IdTranType, out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Przerwa"));
            TranAdd(tranType.IdTranType, out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnBreakOff_Click(object sender, EventArgs e)
        {
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Koniec przerwy"));
            TranAdd(tranType.IdTranType, out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnStartZad_Click(object sender, EventArgs e)
        {
            if (TaskID > 0)
            {
                try
                {
                   // TaskID = Convert.ToInt32(dgvTask.SelectedRows[0].Cells["IdTask"].FormattedValue.ToString());
                    zadTaskProduction task = new zadTaskProduction()
                    {
                        IdUser = UserID,
                        IdTask=TaskID,
                        Start = DateTime.Now,
                        Active = true,
                        Stop = null
                    };
                   context.zadTaskProductions.Add(task);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dgvTaskLoad();
                    dgvMyTaskLoad();
                }

            }
            else
            {
                MessageBox.Show("Wybierz zadanie z listy");
            }
        }

        private void dgvTaskLoad()
        {
            context.Dispose();
            context = new EFModel();

              var TaskIds = (from id in context.zadTaskProductions
                           select id.IdTask).ToList();

            var tasks = (context.zadTaskLists.Where(t => !TaskIds.Any(tp => tp.Value == t.IdTask))).ToList();

            var x = context.zadTaskLists.ToList();

            tasks = tasks.FindAll(t => t.Active == true);
            dgvTask.DataSource = tasks;
            //dodać wszystkie potrzbne ustawienia dgv

            //var tasks = from t in context.zadTaskLists
            //            where TaskIds.Contains(t.IdTask)
            //            select t;
        }
        private void dgvMyTaskLoad()
        {
            var task = context.zadTaskProductions.ToList();
            task = task.FindAll(t => t.IdUser.Equals(UserID));
            dgvMyTasks.DataSource = task;
           // dodać wszystkie potrzbne ustawienia dgv
        }

        private void btnTaskEnd_Click(object sender, EventArgs e)
        {
            //TODO: jak będzie moduł z zadaniami to wtedy 
            if (dgvMyTasks.SelectedRows.Count > 0)
            {
                try
                {
                 //   TaskID = Convert.ToInt32(dgvTask.SelectedRows[0].Cells["IdTask"].FormattedValue.ToString());
                   // var tas = context.
                    zadTaskProduction task = new zadTaskProduction()
                    {
                        IdUser = UserID,
                        Start = DateTime.Now,
                        Active = true,
                        Stop = null
                    };
                    context.zadTaskProductions.Add(task);
                    context.SaveChanges();     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //dgv Reload
                    dgvTaskLoad();
                    //dgvMyTask Reload
                    dgvMyTaskLoad();
                }

            }
            else
            {
                MessageBox.Show("Wybierz zadanie z listy");
            }
        }

        private void TranAdd(int TranType,out string errorMessage)
        {
            errorMessage = String.Empty;
            bool save;
            try
            {
                rcpTransactionAll tran = new rcpTransactionAll()
                {
                    DateAndTime = DateTime.Now,
                    IdUser = this.UserID,
                    IdTransType = TranType
                };
                context.rcpTransactionAlls.Add(tran);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    errorMessage=ex.Message;
                }
            }
            catch (Exception ex)
            {
                errorMessage=ex.Message;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvTaskLoad();
        }

        private void dgvTask_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvTask.SelectedRows.Count > 0)
                {
                    TaskID = Convert.ToInt32(dgvTask.SelectedRows[0].Cells["IdTask"].Value.ToString());
                }

            }
        }

        private void dgvMyTasks_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvMyTasks.SelectedRows.Count > 0)
                {
                    MyTaskID = Convert.ToInt32(dgvMyTasks.SelectedRows[0].Cells["IdTask"].Value.ToString());
                }

            }
        }
    }
}
