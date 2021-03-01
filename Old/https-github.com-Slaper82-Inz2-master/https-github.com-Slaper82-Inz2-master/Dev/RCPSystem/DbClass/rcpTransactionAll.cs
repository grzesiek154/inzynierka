namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;
    [Table("rcpTransactionAll")]
    public partial class rcpTransactionAll
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public long IdTrans { get; set; }

        public DateTime DateAndTime { get; set; }

        public int IdUser { get; set; }

        public int IdTransType { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual rcpTranType rcpTranType { get; set; }
    }
}
