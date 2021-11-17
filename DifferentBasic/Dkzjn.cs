using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DifferentBasic
{
    public partial class Dkzjn : DbContext
    {
        public Dkzjn()
            : base("name=Dkzjn")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<AttachmentType> AttachmentTypes { get; set; }
        public virtual DbSet<CompanyContact> CompanyContacts { get; set; }
        public virtual DbSet<CompanyContactType> CompanyContactTypes { get; set; }
        public virtual DbSet<CompanyEmail> CompanyEmails { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentDkzjn> ContentDkzjns { get; set; }
        public virtual DbSet<ContentType> ContentTypes { get; set; }
        public virtual DbSet<ControlType> ControlTypes { get; set; }
        public virtual DbSet<EmailType> EmailTypes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<sysdiagram> Sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Attachments)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Attachments1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.CompanyContacts)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.CompanyContacts1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.CompanyEmails)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.CompanyEmails1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Contents)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Contents1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Menus)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Menus1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Sliders)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Sliders1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.LastEditedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttachmentType>()
                .HasMany(e => e.Attachments)
                .WithRequired(e => e.AttachmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyContactType>()
                .HasMany(e => e.CompanyContacts)
                .WithRequired(e => e.CompanyContactType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.LanguageCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .HasMany(e => e.Attachments)
                .WithRequired(e => e.Content)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Content>()
                .HasMany(e => e.Content11)
                .WithOptional(e => e.Content2)
                .HasForeignKey(e => e.ContentId);

            modelBuilder.Entity<ContentDkzjn>()
                .Property(e => e.LanguageCode)
                .IsFixedLength()
                .IsUnicode(false);

            //modelBuilder.Entity<ContentDkzjn>()
            //    .HasOptional(e => e.ContentDkzjn1)
            //    .WithRequired(e => e.ContentDkzjn2);

            //modelBuilder.Entity<ContentDkzjn>()
            //    .HasOptional(e => e.ContentDkzjn11)
            //    .WithRequired(e => e.ContentDkzjn3);

            modelBuilder.Entity<Language>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.CultureName)
                .IsFixedLength();

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Contents)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Menus)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Sliders)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.LanguageCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Slider>()
                .Property(e => e.LanguageCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Slider>()
                .HasMany(e => e.Sliders1)
                .WithOptional(e => e.Slider1)
                .HasForeignKey(e => e.SliderId);
        }
    }
}
