using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Models
{
    public partial class MSPersonaContext : DbContext
    {
        public MSPersonaContext()
        {
        }

        public MSPersonaContext(DbContextOptions<MSPersonaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=AYELENPALMIERI\\SQLEXPRESS;Database=MSPersona;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.Property(e => e.TipoEstadoCivil)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.Property(e => e.TipoGenero)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.Property(e => e.NombreLocalidad)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.EstadoCivilIdEstadoCivil).HasColumnName("EstadoCivilId_EstadoCivil");

                entity.Property(e => e.GeneroIdGenero).HasColumnName("GeneroId_Genero");

                entity.Property(e => e.LocalidadIdLocalidad).HasColumnName("LocalidadId_Localidad");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinciaIdProvincia).HasColumnName("ProvinciaId_Provincia");

                entity.HasOne(d => d.EstadoCivilIdEstadoCivilNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.EstadoCivilIdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EstadoCivilId_EstadoCivil");

                entity.HasOne(d => d.GeneroIdGeneroNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.GeneroIdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GeneroId_Genero");

                entity.HasOne(d => d.LocalidadIdLocalidadNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.LocalidadIdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LocalidadId_Localidad");

                entity.HasOne(d => d.ProvinciaIdProvinciaNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.ProvinciaIdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProvinciaId_Provincia");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.NombreProvincia)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
