using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCPSystem.DbClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
   public class zadDuty
    {
        public zadDuty()
        {
            zadDutyTypes = new HashSet<zadDutyType>();
            zadUserDutys = new HashSet<zadUserDuty>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key]
        public int IdDuty { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadDutyType> zadDutyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadUserDuty> zadUserDutys { get; set; }

    }
}
