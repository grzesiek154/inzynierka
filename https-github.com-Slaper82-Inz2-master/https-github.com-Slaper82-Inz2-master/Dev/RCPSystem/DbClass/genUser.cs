namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class genUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public genUser()
        {
            genLogins = new HashSet<genLogin>();
            genOrgUnitPrivs = new HashSet<genOrgUnitPriv>();
            genOrgUsers = new HashSet<genOrgUser>();
            rcpTransactions = new HashSet<rcpTransactionAll>();
            rcpUserHarmoes = new HashSet<rcpUserHarmo>();
            zadOrders = new HashSet<zadOrder>();
            zadTaskProductions = new HashSet<zadTaskProduction>();
        }

        [Key]
        public int IdUser { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        public int IdRole { get; set; }

        public int Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<genLogin> genLogins { get; set; }

        public virtual genRole genRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<genOrgUnitPriv> genOrgUnitPrivs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<genOrgUser> genOrgUsers { get; set; }

        public virtual genUserDet genUserDet { get; set; }

      //  public virtual rcpPairsBRK rcpPairsBRK { get; set; }

       // public virtual rcpPairsIO rcpPairsIO { get; set; }

       // public virtual rcpPairsOnB rcpPairsOnB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpTransactionAll> rcpTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpUserHarmo> rcpUserHarmoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadOrder> zadOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadTaskProduction> zadTaskProductions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpPairsIO> rcpPairsIOs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpPairsBRK> rcpPairsBRK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rcpPairsOnB> rcpPairsOnB { get; set; }

    }
}
