namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpDay")]
    public partial class rcpDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rcpDay()
        {
            rcpHarmoDefs = new HashSet<rcpHarmoDef>();
        }

        [Key]
        public int IdDay { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public TimeSpan? CStart { get; set; }

        public TimeSpan? CStop { get; set; }

        public short? IEarly { get; set; }

        public short? ILate { get; set; }

        public short? OEarly { get; set; }

        public short? OLate { get; set; }

        public short? Break { get; set; }

        public bool? Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpHarmoDef> rcpHarmoDefs { get; set; }
    }
}
