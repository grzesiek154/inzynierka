namespace RCPSystem.DbClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public partial class zadDutyType
    {
     
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int IdType { get; set; }
        public int IdDuty { get; set; }
        public virtual zadType zadTypes { get; set; }
        public virtual zadDuty zadDutys { get; set; }
    }
}
