using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Service.Models
{
    public partial class fundicanContext : DbContext
    {
        

        public fundicanContext(DbContextOptions<fundicanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<PetType> PetTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Genre1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("genre");
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.ToTable("pet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CodGenre).HasColumnName("codGenre");

                entity.Property(e => e.CodPetType).HasColumnName("codPetType");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Observations)
                    .IsUnicode(false)
                    .HasColumnName("observations");

                entity.Property(e => e.PetName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("petName");

                entity.HasOne(d => d.CodGenreNavigation)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.CodGenre)
                    .HasConstraintName("FK__pet__codGenre__5070F446");

                entity.HasOne(d => d.CodPetTypeNavigation)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.CodPetType)
                    .HasConstraintName("FK__pet__codPetType__4F7CD00D");
            });

            modelBuilder.Entity<PetType>(entity =>
            {
                entity.ToTable("pet_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PetType1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pet_type");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("loginUser");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passwordUser");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
