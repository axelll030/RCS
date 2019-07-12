namespace NewsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Topic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Topic()
        {
            News = new List<News>();
        }

        public int Id { get; set; }

        [Column("Topic")]
        [StringLength(50)]
        public string Topics { get; set; }

        public virtual List<News> News { get; set; }
    }
}
