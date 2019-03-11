namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadProdElem")]
    public partial class zadProdElem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int IdElement { get; set; }

        public int IdProduct { get; set; }

        public virtual zadElement zadElement { get; set; }

        public virtual zadProduct zadProduct { get; set; }
    }
}
