using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Class
{
    class FrmHelpers
    {
        EFModel context;
        TreeNode node;
        TreeView TV;
        ImageList ImageList;
        public List<genOrgUnit> ListaDep { get; set; }
        public List<genUser> UsersList { get; set; }
        public FrmHelpers()
        {
            context = new EFModel();
            ListaDep = context.genOrgUnits.ToList();
            UsersList = context.genUsers.ToList();
          
        }
        public FrmHelpers(TreeView tv,ImageList _images)
        {
            ListaDep = new List<genOrgUnit>();
            context = new EFModel();
            ListaDep = context.genOrgUnits.ToList();
            UsersList = context.genUsers.ToList();
            ImageList = _images;
            this.TV = tv;
        }
        public void EnableDisableControls(Form form )
        {


        }
        public void TreeLoad()
        {
            TV.ImageList = ImageList;
            var listaDzialGl = ListaDep.FindAll(x => x.IdHigherOrgUnit == null);
            listaDzialGl.ForEach(delegate (genOrgUnit dep)
            {
                node = new TreeNode();
                node.Text = dep.Name;
                node.Name = dep.IdOrgUnit.ToString();
                node.ImageIndex = 0;
                TV.Nodes.Add(node);
                UsersAdd(node);
                bool IsParent = (context.genOrgUnits.Count(d => d.IdHigherOrgUnit == dep.IdOrgUnit)) > 0;

                if (IsParent)
                {
                    var listaDzialPdr = ListaDep.FindAll(x => x.IdHigherOrgUnit == dep.IdOrgUnit);
                    GetChildNodes(listaDzialPdr, node);
                }
                TV.ExpandAll();
            }
            );
        }



        public void GetChildNodes(List<genOrgUnit> listaDzialPdr, TreeNode node)
        {
            TreeNode childNode;
            listaDzialPdr.ForEach(delegate (genOrgUnit Child_dep)
            {
                childNode = new TreeNode();
                childNode.Text = Child_dep.Name;
                childNode.Name = Child_dep.IdOrgUnit.ToString();
                childNode.ImageIndex = 0;
                childNode.SelectedImageIndex = 0;
                node.Nodes.Add(childNode);
                UsersAdd(childNode);
                int DepId = Convert.ToInt32(childNode.Name);

                bool IsParent = (context.genOrgUnits.Count(d => d.IdHigherOrgUnit == Child_dep.IdOrgUnit)) > 0;

                if (IsParent)
                {
                    listaDzialPdr = ListaDep.FindAll(x => x.IdHigherOrgUnit == Child_dep.IdOrgUnit);
                    GetChildNodes(listaDzialPdr, childNode);
                }

            });

        }
        public void UsersAdd(TreeNode node)
        {
            var tmp = new List<genUser>();
            tmp = context.genUsers.ToList();
            int nodeId = Convert.ToInt32(node.Name);
            var OrgUnits = context.genOrgUnitPrivs.ToList();
            var UserInOrg = from user in tmp
                            join org in OrgUnits on user.IdUser equals org.IdUser
                            where org.IdOrgUnit == nodeId
                            select user;

            foreach (genUser user in UserInOrg)
            {
                TreeNode usernode = new TreeNode();
                usernode.Text = user.Name + " " + user.Surname;
                usernode.Name = user.IdUser.ToString();
                usernode.ImageIndex = 1;
                usernode.SelectedImageIndex = 1;
                node.Nodes.Add(usernode);
            }
        }
    
    }
    public static class MonthDays
    {
        public static DateTime FirstDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public static int DaysInMonth(this DateTime value)
        {
            return DateTime.DaysInMonth(value.Year, value.Month);
        }

        public static DateTime LastDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.DaysInMonth());
        }
    }
}
