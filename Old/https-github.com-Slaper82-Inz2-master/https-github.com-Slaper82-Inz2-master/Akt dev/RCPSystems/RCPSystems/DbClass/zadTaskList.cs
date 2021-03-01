namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadTaskList")]
    public partial class zadTaskList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zadTaskList()
        {
            zadTaskProductions = new HashSet<zadTaskProduction>();
        }

        [Key]
        public int IdTask { get; set; }

        public int IdOrder { get; set; }

        public int IdElement { get; set; }

        public int Quantity { get; set; }

        public bool? Active { get; set; }

        public bool? Done { get; set; }

        public virtual zadElement zadElement { get; set; }

        public virtual zadOrder zadOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadTaskProduction> zadTaskProductions { get; set; }
    }
}
