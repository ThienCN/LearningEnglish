using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace English.Models
{
    public partial class EnglishContext : DbContext
    {
        public EnglishContext()
        {
        }

        public EnglishContext(DbContextOptions<EnglishContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<Number> Number { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=English;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Animals>(entity =>
            {
                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.PronounceUrl)
                    .HasColumnName("PronounceURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SoundUrl)
                    .HasColumnName("SoundURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Vietnamese).HasMaxLength(500);
            });

            modelBuilder.Entity<Number>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });
        }
    }
}
