using System;
using System.Collections.Generic;
using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorApp1.Server.Context
{
    public partial class DiMetalloContext : DbContext
    {
        public DiMetalloContext()
        {
        }

        public DiMetalloContext(DbContextOptions<DiMetalloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activo> Activos { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Insumo> Insumos { get; set; } = null!;
        public virtual DbSet<MateriaPrima> MateriaPrimas { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Repuesto> Repuestos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;trusted_connection=True;database=DiMetallo");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activo>(entity =>
            {
                entity.ToTable("Activo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Marca).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Cf)
                    .IsUnicode(false)
                    .HasColumnName("CF");

                entity.Property(e => e.Cp)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Cuit).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.NombreContacto).IsUnicode(false);

                entity.Property(e => e.NombreEmpresa).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<Insumo>(entity =>
            {
                entity.ToTable("Insumo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Foto).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<MateriaPrima>(entity =>
            {
                entity.ToTable("MateriaPrima");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("Personal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Calle).IsUnicode(false);

                entity.Property(e => e.Cf)
                    .IsUnicode(false)
                    .HasColumnName("CF");

                entity.Property(e => e.Cp)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Cuit).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.NombreContacto).IsUnicode(false);

                entity.Property(e => e.NombreEmpresa).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.ToTable("Repuesto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Foto).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
