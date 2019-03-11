using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPSystems;

namespace RCPSystems.Class
{
    class ProdTypes
    {
        EFModel context;
        TreeView Tree;
        Button Add;
        Button Delete;
        TextBox Name;
        List<zadType> Types;
        DataGridView dgv;
        public ProdTypes(Button _add,Button _delete,TextBox _name,DataGridView _dgv)
        {

            context = new EFModel();              
          //  this.Tree = _tree;
            this.Add = _add;
            this.Delete = _delete;
            this.Name = _name;
            this.dgv = _dgv;
            Types = new List<zadType>();
            GridLoad();
        }

        public void GridLoad()
        {
            var Types = (from t in context.zadTypes
                       join el in context.zadElements on t.IdType equals el.IdType
                       where t.Active.Equals(true)
                       select new { t.IdType,Nazwa = t.TypeName,Przypisany=el.Name }).ToList();

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = Types;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoResizeColumns();

        }

        public void ButtonAdd(string Name,out int TypeID)
        {
            TypeID = 0;
            try
            {
                var zad = new zadType();
                zad.TypeName = Name;
                zad.Active = true;
                context.zadTypes.Add(zad);
                context.SaveChanges();
                TypeID =zad.IdType;
            }
            catch(Exception ex)
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
                var zad = context.zadTypes.FirstOrDefault(z => z.IdType == Id);
                zad.Active = false;
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
