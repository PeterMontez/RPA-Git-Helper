using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GitManager.Model;

public partial class RepositoriesContext : DbContext
{
    public RepositoriesContext()
    {
    }

    public RepositoriesContext(DbContextOptions<RepositoriesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<Repository> Repositories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CT-C-0018C\\SQLEXPRESS;Initial Catalog=Repositories;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Folder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Folder__3213E83F8BB4D381");

            entity.ToTable("Folder");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Path)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Repository>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reposito__3213E83F7D1F0B1D");

            entity.ToTable("Repository");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdMainFolder).HasColumnName("id_main_folder");
            entity.Property(e => e.Path)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdMainFolderNavigation).WithMany(p => p.Repositories)
                .HasForeignKey(d => d.IdMainFolder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Repositor__id_ma__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
