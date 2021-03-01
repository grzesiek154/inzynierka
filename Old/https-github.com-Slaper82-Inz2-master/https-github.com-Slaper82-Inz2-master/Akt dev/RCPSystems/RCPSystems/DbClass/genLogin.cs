namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("genLogin")]
    public partial class genLogin
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        [Required]
        [StringLength(20)]
        public string Login { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public short Try { get; set; }

        public virtual genUser genUser { get; set; }
    }
}
