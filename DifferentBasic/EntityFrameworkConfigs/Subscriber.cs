namespace DifferentBasic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subscriber")]
    public partial class Subscriber
    {
        public int SubscriberId { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
