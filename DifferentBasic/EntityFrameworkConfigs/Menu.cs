namespace DifferentBasic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            Contents = new HashSet<Content>();
            Sliders = new HashSet<Slider>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        public int? MenuType { get; set; }

        public int? MenuId { get; set; }

        public int OrderNumber { get; set; }

        [Required]
        [StringLength(2)]
        public string LanguageCode { get; set; }

        public string Intro { get; set; }

        public string Content { get; set; }

        public bool HasSlider { get; set; }

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

        public string Link { get; set; }

        [StringLength(256)]
        public string Image { get; set; }

        [StringLength(256)]
        public string ImageHover { get; set; }

        public int? ContentId { get; set; }

        public int? ContentTypeId { get; set; }

        public int MkId { get; set; }

        public int EnId { get; set; }

        public int SqId { get; set; }

        public int? NewLanguageId { get; set; }

        public string Extra1 { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual AspNetUser AspNetUser1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Content> Contents { get; set; }

        public virtual Language Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slider> Sliders { get; set; }
    }
}
