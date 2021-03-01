namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpPairsIO")]
    public partial class rcpPairsIO
    {
       
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? Stop { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Lp { get; set; }

        public virtual genUser genUser { get; set; }

    }
}
