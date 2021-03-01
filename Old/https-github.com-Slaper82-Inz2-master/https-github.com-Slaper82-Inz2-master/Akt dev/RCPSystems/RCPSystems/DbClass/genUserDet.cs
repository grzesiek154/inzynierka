namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("genUserDet")]
    public partial class genUserDet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        public DateTime? DateBirth { get; set; }

        [StringLength(255)]
        public string PlaceBirth { get; set; }

        [StringLength(255)]
        public string Adrress { get; set; }

        [StringLength(255)]
        public string Adrress2 { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        public bool IsWoman { get; set; }

        public virtual genUser genUser { get; set; }
    }
}
