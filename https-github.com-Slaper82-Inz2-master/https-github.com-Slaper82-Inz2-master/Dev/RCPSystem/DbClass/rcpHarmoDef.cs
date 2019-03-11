namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpHarmoDef")]
    public partial class rcpHarmoDef
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; set; }

        public int IdHarmo { get; set; }
   
        public int WDay { get; set; }

        public int IdDay { get; set; }

        public virtual rcpDay rcpDay { get; set; }

        public virtual rcpHarmo rcpHarmo { get; set; }
    }
}
