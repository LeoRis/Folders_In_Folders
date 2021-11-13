namespace DifferentBasic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attachment
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Link { get; set; }

        public string Extra { get; set; }

        public int AttachmentTypeId { get; set; }

        public int ContentId { get; set; }

        public bool IsCover { get; set; }

        public int OrderNumber { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        [StringLength(128)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string LastEditedBy { get; set; }

        public DateTime LastEditedDate { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual AspNetUser AspNetUser1 { get; set; }

        public virtual AttachmentType AttachmentType { get; set; }

        public virtual Content Content { get; set; }
    }
}
