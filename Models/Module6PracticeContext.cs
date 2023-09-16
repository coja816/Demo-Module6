using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo_Module6.Models;

public partial class Module6PracticeContext : DbContext
{
    public Module6PracticeContext()
    {
    }

    public Module6PracticeContext(DbContextOptions<Module6PracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CustMasterTbl> CustMasterTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-PJRS4CVJ;Initial Catalog=Module6Practice;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustMasterTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustMasterTBL");

            entity.Property(e => e.CustCd)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.InsertBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
