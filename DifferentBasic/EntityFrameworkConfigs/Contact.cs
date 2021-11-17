namespace DifferentBasic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Company { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsContact { get; set; }
    }
}
