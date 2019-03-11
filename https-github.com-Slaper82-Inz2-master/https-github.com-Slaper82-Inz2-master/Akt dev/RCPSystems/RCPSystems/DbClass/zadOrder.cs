namespace RCPSystems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadOrder")]
    public partial class zadOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zadOrder()
        {
            zadOrderProducts = new HashSet<zadOrderProduct>();
            zadTaskLists = new HashSet<zadTaskList>();
        }

        [Key]
        public int IdOrder { get; set; }

        public DateTime CreateDate { get; set; }

        public int IdUser { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public bool? Done { get; set; }

        public bool? Active { get; set; }

        public int IdClient { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual zadClient zadClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadOrderProduct> zadOrderProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadTaskList> zadTaskLists { get; set; }
    }
}
