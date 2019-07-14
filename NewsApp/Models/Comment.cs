namespace NewsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("Comment")]
        [Required]
        public string Comments { get; set; }

        public int NewsId { get; set; }

        public virtual News News { get; set; }
    }
}
