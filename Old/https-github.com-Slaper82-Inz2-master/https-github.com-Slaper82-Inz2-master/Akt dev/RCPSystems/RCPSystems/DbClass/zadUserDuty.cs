namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zadUserDuty
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdDuty { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual zadDuty zadDuty { get; set; }
    }
}
