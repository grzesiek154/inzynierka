namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zadDutyType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IdType { get; set; }

        public int IdDuty { get; set; }

        public virtual zadDuty zadDuty { get; set; }

        public virtual zadType zadType { get; set; }
    }
}
