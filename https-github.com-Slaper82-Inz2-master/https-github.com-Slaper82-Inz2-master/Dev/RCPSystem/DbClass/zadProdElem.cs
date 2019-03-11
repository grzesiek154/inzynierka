namespace RCPSystem.DbClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadProdElem")]
    public class zadProdElem
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; set; }

        public int Quantity { get; set; }
        public int IdElement { get; set; }
        public int IdProduct { get; set; }
        public virtual zadElement zadElements { get; set; }
        public virtual zadProduct zadDutys { get; set; }

    }
}
