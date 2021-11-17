namespace DifferentBasic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Content")]
    public partial class Content
    {
        public Content()
        {
            Attachments = new HashSet<Attachment>();
            Content11 = new HashSet<Content>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        public string Intro { get; set; }

        [Column("Content")]
        public string Content1 { get; set; }

        public int? PairedId { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        [StringLength(500)]
        public string Icon { get; set; }

        [StringLength(500)]
        public string Tags { get; set; }

        [StringLength(500)]
        public string Picture { get; set; }

        [StringLength(500)]
        public string PictureName { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public DateTime ExtraDate { get; set; }

        public int? ExtraInt { get; set; }

        [Required]
        [StringLength(2)]
        public string LanguageCode { get; set; }

        public int? MenuId { get; set; }

        public int? ContentTypeId { get; set; }

        public int? ControlTypeId { get; set; }

        public int? ContentId { get; set; }

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

        public int ContentMkId { get; set; }

        public int ContentEnId { get; set; }

        public int ContentSqId { get; set; }

        public int? ContentNewLanguageId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual AspNetUser AspNetUser1 { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }

        public virtual ICollection<Content> Content11 { get; set; }

        public virtual Content Content2 { get; set; }

        public virtual ContentType ContentType { get; set; }

        public virtual ControlType ControlType { get; set; }

        public virtual Language Language { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
