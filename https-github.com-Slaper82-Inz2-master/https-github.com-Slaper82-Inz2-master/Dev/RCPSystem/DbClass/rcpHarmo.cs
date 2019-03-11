namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpHarmo")]
    public partial class rcpHarmo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rcpHarmo()
        {
            rcpHarmoDefs = new HashSet<rcpHarmoDef>();
            rcpUserHarmoes = new HashSet<rcpUserHarmo>();
        }

        [Key]
        public int IdHarmo { get; set; }

        [StringLength(30)]
        public string HarmoName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpHarmoDef> rcpHarmoDefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpUserHarmo> rcpUserHarmoes { get; set; }
    }
}
