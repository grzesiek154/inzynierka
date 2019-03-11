using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCPSystems.Class
{
    public class ReportClass
    {
        public int IdUser { get; set; }
        public int DateKey { get; set; }
        public DateTime Date { get; set; }
        public string Norma { get; set; }
        public string Odczytane { get; set; }
        public int? Przerwa { get; set; }
        public string  Braki { get; set; }
        public string Nadgodziny { get; set; }
        public string Transakcje { get; set; }

    }
}
