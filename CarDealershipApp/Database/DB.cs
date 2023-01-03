using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipApp.Database;

public partial class DB : DbContext
{
    public DB()
    {
    }

    public DB(DbContextOptions<DB> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarOrder> CarOrders { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Dealer> Dealers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarDealershipDB;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Price).HasMaxLength(50);
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<CarOrder>(entity =>
        {
            entity.ToTable("CarOrder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DealerId).HasColumnName("DealerID");

            entity.HasOne(d => d.Car).WithMany(p => p.CarOrders)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK_CarOrder_Cars");

            entity.HasOne(d => d.Customer).WithMany(p => p.CarOrders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CarOrder_Customers");

            entity.HasOne(d => d.Dealer).WithMany(p => p.CarOrders)
                .HasForeignKey(d => d.DealerId)
                .HasConstraintName("FK_CarOrder_Dealers");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
            entity.Property(e => e.Tel).HasMaxLength(50);
        });

        modelBuilder.Entity<Dealer>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
            entity.Property(e => e.Tel).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
