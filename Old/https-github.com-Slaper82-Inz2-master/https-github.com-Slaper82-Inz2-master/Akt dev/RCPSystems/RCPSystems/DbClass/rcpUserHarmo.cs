namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpUserHarmo")]
    public partial class rcpUserHarmo
    {
        public int IdUser { get; set; }

        public int IdHarmo { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }

        public int Id { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual rcpHarmo rcpHarmo { get; set; }
    }
}
