namespace NewsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Virsraksts")]
        public string Name { get; set; }

        [StringLength(100)]
        [Required]
        [DisplayName("Autors")]
        public string Author { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [DisplayName("Ziņa")]
        public string Article { get; set; }

        [Column(TypeName = "date")]
        [Required]
        [DisplayName("Datums")]
        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Picture { get; set; }

        [Required]
        public int TopicId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
