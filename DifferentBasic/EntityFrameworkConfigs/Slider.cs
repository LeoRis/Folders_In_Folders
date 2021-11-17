namespace DifferentBasic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Slider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Slider()
        {
            Sliders1 = new HashSet<Slider>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Intro { get; set; }

        public string Content { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        [StringLength(500)]
        public string Picture { get; set; }

        [Required]
        [StringLength(2)]
        public string LanguageCode { get; set; }

        public int? MenuId { get; set; }

        public int? SliderId { get; set; }

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

        public virtual Language Language { get; set; }

        public virtual Menu Menu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slider> Sliders1 { get; set; }

        public virtual Slider Slider1 { get; set; }
    }
}
