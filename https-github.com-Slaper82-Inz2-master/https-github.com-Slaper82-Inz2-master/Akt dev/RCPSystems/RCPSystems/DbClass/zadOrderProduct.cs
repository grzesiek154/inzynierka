namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadOrderProduct")]
    public partial class zadOrderProduct
    {
        public int IdOrder { get; set; }

        public int IdProduct { get; set; }

        public bool? Active { get; set; }

        public int Quantity { get; set; }

        [Key]
        public int IdKey { get; set; }

        public virtual zadOrder zadOrder { get; set; }

        public virtual zadProduct zadProduct { get; set; }
    }
}
