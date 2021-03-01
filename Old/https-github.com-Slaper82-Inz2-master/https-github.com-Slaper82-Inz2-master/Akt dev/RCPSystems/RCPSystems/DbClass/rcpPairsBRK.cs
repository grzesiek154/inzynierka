namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpPairsBRK")]
    public partial class rcpPairsBRK
    {
        public int IdUser { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? Stop { get; set; }

        [Key]
        public int Lp { get; set; }

        public virtual genUser genUser { get; set; }
    }
}
