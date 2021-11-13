namespace DifferentBasic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContentDkzjn")]
    public partial class ContentDkzjn
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Godina { get; set; }

        [Required]
        public string DogOrgan { get; set; }

        [Required]
        public string Zalitel { get; set; }

        [Required]
        public string Postapka { get; set; }

        [Required]
        public string DrPostapka { get; set; }

        [Required]
        public string Predmet { get; set; }

        [Required]
        public string Resenie { get; set; }

        [Required]
        public string Sednica { get; set; }

        [Required]
        [StringLength(50)]
        public string Oglas { get; set; }

        public int OrderNumber { get; set; }

        public bool IsShowable { get; set; }

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

        [Required]
        [StringLength(2)]
        public string LanguageCode { get; set; }

        public int MenuId { get; set; }

        public int ContentTypeId { get; set; }

        public string Attachment { get; set; }

        public virtual ContentDkzjn ContentDkzjn1 { get; set; }

        public virtual ContentDkzjn ContentDkzjn2 { get; set; }

        public virtual ContentDkzjn ContentDkzjn11 { get; set; }

        public virtual ContentDkzjn ContentDkzjn3 { get; set; }
    }
}
