using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCPSystem.Class
{
   public class Priviliges
    {
        public enum UserType
        {
            Administrator=1,
            Boss=2,
            Supervisor=3,
            HumanResorces=4,
            Worker=5
        }
        public List<string> PriviligesList { get; set; }

        public Priviliges(UserType type)
        {
            switch (type)
            {
                case UserType.Administrator:
                    PriviligesList = Administrator();
                    break;
                case UserType.Boss:
                    PriviligesList = Boss();
                    break;
                case UserType.Supervisor:
                    PriviligesList = Supervisor();
                    break;
                case UserType.HumanResorces:
                    PriviligesList = HumnaResorces();
                    break;
                case UserType.Worker:
                    PriviligesList = Worker();
                    break;
            }
        }

        public List<string> Administrator()
        {
            List<string> retval = new List<string>();
            retval.Add("tsbUsers");
            retval.Add("tsbTimeAtt");
            retval.Add("tsbDay");
            retval.Add("tsbHarmo");
            retval.Add("tsbDict");
            retval.Add("tsbTA");
            retval.Add("tsbHarmo");
            return retval;
        }
        public List<string> Boss()
        {
            List<string> retval = new List<string>();
            retval.Add("");
            retval.Add("");
            retval.Add("");
            retval.Add("");
            return retval;
        }
        public List<string> Supervisor()
        {
            List<string> retval = new List<string>();
            retval.Add("");
            retval.Add("");
            retval.Add("");
            retval.Add("");
            return retval;
        }
        public List<string> HumnaResorces()
        {
            List<string> retval = new List<string>();
            retval.Add("");
            retval.Add("");
            retval.Add("");
            retval.Add("");
            return retval;
        }
        public List<string> Worker()
        {
            List<string> retval = new List<string>();
            retval.Add("");
            retval.Add("");
            retval.Add("");
            retval.Add("");
            return retval;
        }

    }
}
