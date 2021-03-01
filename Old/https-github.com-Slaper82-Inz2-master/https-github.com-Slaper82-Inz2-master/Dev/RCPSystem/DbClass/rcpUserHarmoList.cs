namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpUserHarmoList")]
    public partial class rcpUserHarmoList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        [Column(Order = 0)]
        public int Id { get; set; }

     
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

    
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHarmo { get; set; }

 
        public DateTime ValidFrom { get; set; }

   
        public DateTime ValidTo { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual rcpHarmo rcpHarmo { get; set; }
    }
}
