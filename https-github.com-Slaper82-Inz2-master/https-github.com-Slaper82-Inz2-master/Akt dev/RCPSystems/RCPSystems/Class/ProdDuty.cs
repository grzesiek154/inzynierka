//using RCPSystem.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPSystems;

namespace RCPSystems.Class
{
    public class ProdDuty
    {
        EFModel context;    
        TextBox Name; 
        ListBox listBox;
        DataGridView dgvDuty;
        DataGridView dgvTask;

        public ProdDuty(TextBox _name, DataGridView _dgvDuty, DataGridView _dgvTask)
        {
            context = new EFModel();
            context.Configuration.ProxyCreationEnabled = false;
            this.dgvDuty = _dgvDuty;
            this.dgvTask = _dgvTask;
            this.Name = _name;
            GridDutyLoad();
        }
        public void GridDutyLoad()
        {
            var duties = context.zadDuties.ToList();
            dgvDuty.AutoGenerateColumns = false;
            dgvDuty.DataSource = duties;         
            dgvDuty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDuty.AutoResizeColumns();
            dgvDuty.Refresh();
        }

        public void GridDutyTaskLoad(int DutyID)
        {
            var list = context.zadTypes.ToList();
            var Source = (from type in context.zadTypes
                          join duty in context.zadDutyTypes on type.IdType equals duty.IdType
                          where duty.IdDuty == DutyID
                          select new { type.IdType,type.TypeName }).ToList();
            dgvTask.AutoGenerateColumns = false;
            dgvTask.DataSource = Source;
           
            dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTask.AutoResizeColumns();
            dgvTask.Refresh();
        }
        public void ListBoxLoad(int DutyId)
        {
            listBox.DataSource = null;
            var list = context.zadTypes.ToList();
            var Source = (from type in context.zadTypes
                                 join duty in context.zadDutyTypes on type.IdType equals duty.IdType
                                 where duty.IdDuty == DutyId
                                 select type).ToList();
            List<zadType> zad= Source.ToList();
            listBox.DataSource = zad;
            listBox.ValueMember = "IdType";
            listBox.DisplayMember = "TypeName";
        }

        public void ButtonAdd(string Name)
        {
            zadDuty zad = new zadDuty();
            try
            {
                zad.Name = Name;
                context.zadDuties.Add(zad);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridDutyLoad();
                this.Name.Text = String.Empty;
            }
        }
        public void ButtonDelete(int DutyId)
        {
            var listType = context.zadDutyTypes.ToList();
            listType = listType.FindAll(d => d.IdDuty == DutyId);
            var duty = context.zadDuties.FirstOrDefault(d => d.IdDuty == DutyId);
            try
            {
                foreach(zadDutyType z in listType)
                {
                    context.zadDutyTypes.Attach(z);
                    context.zadDutyTypes.Remove(z);
                    context.SaveChanges();
                }
                context.zadDuties.Attach(duty);
                context.zadDuties.Remove(duty);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridDutyLoad();
                this.Name.Text = String.Empty;

            }
        }
        public void ButtonTypeAdd(int DutyId, int TypeId)
        {
            zadDutyType zadTyp = new zadDutyType();
            try
            {
                zadTyp.IdDuty = DutyId;
                zadTyp.IdType = TypeId;
               context.zadDutyTypes.Add(zadTyp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridDutyTaskLoad(DutyId);
                this.Name.Text = String.Empty;

            }
        }
        public void ButtonTypeDelete(int DutyId,int TypeId)
        {
            zadDutyType zadTyp = new zadDutyType();
            zadTyp = context.zadDutyTypes.FirstOrDefault(du => du.IdDuty == DutyId && du.IdType == TypeId);
            try
            {
                context.zadDutyTypes.Attach(zadTyp);
                context.zadDutyTypes.Remove(zadTyp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {              
                this.Name.Text = String.Empty;
                GridDutyTaskLoad(DutyId);
                this.Name.Text = String.Empty;

            }
        }
    }
}
