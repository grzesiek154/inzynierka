namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadTaskProduction")]
    public partial class zadTaskProduction
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUser { get; set; }

        public DateTime? Start { get; set; }

        public int? IdTask { get; set; }

        public DateTime? Stop { get; set; }

        public bool? Active { get; set; }

        public string AddInfo { get; set; }

        public virtual zadTaskList zadTaskList { get; set; }
        public virtual genUser genUser { get; set; }
    }
}
