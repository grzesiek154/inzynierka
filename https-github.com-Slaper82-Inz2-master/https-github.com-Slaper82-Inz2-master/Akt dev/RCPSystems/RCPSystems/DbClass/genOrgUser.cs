namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class genOrgUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Lp { get; set; }

        public int IdUser { get; set; }

        public int IdOrgUnit { get; set; }

        public virtual genOrgUnit genOrgUnit { get; set; }

        public virtual genUser genUser { get; set; }
    }
}
