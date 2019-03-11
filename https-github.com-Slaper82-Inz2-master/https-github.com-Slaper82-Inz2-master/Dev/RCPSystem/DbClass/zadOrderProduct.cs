namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadOrderProduct")]
    public partial class zadOrderProduct
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int IdKey { get; set; }

        public int IdOrder { get; set; }

        public int IdProduct { get; set; }

        public int Quantity { get; set; }

        public bool? Active { get; set; }

        public virtual zadOrder zadOrder { get; set; }

        public virtual zadProduct zadProduct { get; set; }
    }
}
