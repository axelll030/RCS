namespace MyFirstWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Vards")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Uzvards")]
        public string LastName { get; set; }
    }
}
