namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("genOrgUnit")]
    public partial class genOrgUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public genOrgUnit()
        {
            genOrgUnitPrivs = new HashSet<genOrgUnitPriv>();
            genOrgUsers = new HashSet<genOrgUser>();
        }

        [Key]
        public int IdOrgUnit { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? IdHigherOrgUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<genOrgUnitPriv> genOrgUnitPrivs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<genOrgUser> genOrgUsers { get; set; }
    }
}
