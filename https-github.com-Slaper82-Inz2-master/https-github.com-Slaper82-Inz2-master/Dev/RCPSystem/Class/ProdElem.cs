using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Class
{
    class ProdElem
    {
        EFModel context;
        TextBox Name;
        ComboBox combo;
        List<zadElement> Elem;
        DataGridView dgv;
        public ProdElem(TextBox _name,ComboBox _combo, DataGridView _dgv)
        {

            context = new EFModel();
            this.dgv = _dgv;
            this.Name = _name;
            this.combo = _combo;
            Elem = new List<zadElement>();
            ComboLoad();
            GridLoad();
        }
        public void ComboLoad()
        {
            var List = context.zadTypes.ToList();
            List = List.FindAll(l => l.Active != false);
            combo.DataSource = List;
            combo.ValueMember = "IdType";
            combo.DisplayMember = "TypeName"; 
        }

        public void GridLoad()
        {
            Elem = context.zadElements.ToList();
            Elem = Elem.FindAll(e => e.Active == true);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = Elem;
        }
        public void ButtonAdd(string Name,int TypeId)
        {
            try
            {
                var elem = new zadElement();
                elem.Name = Name;
                elem.Active = true;
                elem.IdType = TypeId;
                context.zadElements.Add(elem);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridLoad();
                this.Name.Text = String.Empty;
            }
        }
        public void ButtonDelete(int Id)
        {
            try
            {
                var elem = context.zadElements.FirstOrDefault(z => z.IdElement == Id);
                elem.Active = false;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridLoad();
                this.Name.Text = String.Empty;

            }

        }
    }
}
