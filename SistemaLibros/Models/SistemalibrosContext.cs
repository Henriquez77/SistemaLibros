using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaLibros.Models;

public partial class SistemalibrosContext : DbContext
{
    public SistemalibrosContext()
    {
    }

    public SistemalibrosContext(DbContextOptions<SistemalibrosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=sistemalibros;Uid=root;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("PRIMARY");

            entity.ToTable("libros");

            entity.Property(e => e.IdLibro)
                .HasColumnType("int(11)")
                .HasColumnName("id_libro");
            entity.Property(e => e.AutorLibro)
                .HasMaxLength(255)
                .HasColumnName("autor_libro");
            entity.Property(e => e.DescripcionLibro)
                .HasMaxLength(255)
                .HasColumnName("descripcion_libro");
            entity.Property(e => e.ImagenLibro)
                .HasMaxLength(255)
                .HasColumnName("imagen_libro");
            entity.Property(e => e.NumejemplaresLibro)
                .HasColumnType("int(11)")
                .HasColumnName("numejemplares_libro");
            entity.Property(e => e.TituloLibro)
                .HasMaxLength(255)
                .HasColumnName("titulo_libro");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.Property(e => e.IdRol)
                .HasColumnType("int(11)")
                .HasColumnName("id_rol");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(255)
                .HasColumnName("nombre_rol");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.RolidUsuario, "rolid_usuario");

            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_usuario");
            entity.Property(e => e.AliasUsuario)
                .HasMaxLength(255)
                .HasColumnName("alias_usuario");
            entity.Property(e => e.ContraseniaUsuario)
                .HasMaxLength(255)
                .HasColumnName("contrasenia_usuario");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(255)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.RolidUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("rolid_usuario");

            entity.HasOne(d => d.RolidUsuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolidUsuario)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("usuarios_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
