namespace RCPSystem.DbClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
   public class zadUserDuty
    {
        //public zadUserDuty()
        //{
        //    genUsers = new HashSet<genUser>();
        //    zadDutys = new HashSet<zadDuty>();
        //}

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdDuty { get; set; }

        public virtual genUser genUser { get; set; }
        public virtual zadDuty zadDuty { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<genUser> genUsers { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<zadDuty> zadDutys { get; set; }
    }
}
