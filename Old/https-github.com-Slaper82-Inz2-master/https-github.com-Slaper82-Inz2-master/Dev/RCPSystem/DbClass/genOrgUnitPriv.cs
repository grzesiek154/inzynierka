namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("genOrgUnitPriv")]
    public partial class genOrgUnitPriv
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrgUnit { get; set; }

        public bool? Active { get; set; }

        public virtual genOrgUnit genOrgUnit { get; set; }

        public virtual genUser genUser { get; set; }
    }
}
