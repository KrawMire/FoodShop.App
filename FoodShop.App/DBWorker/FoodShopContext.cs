using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodShop.App
{
    public partial class FoodShopContext : DbContext
    {
        string connectionString;

        public FoodShopContext(string connection)
        {
            this.connectionString = connection;
        }

        public FoodShopContext(DbContextOptions<FoodShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeMainInfo> EmployeeMainInfo { get; set; }
        public virtual DbSet<EmployeeShopInfo> EmployeeShopInfo { get; set; }
        public virtual DbSet<EmployeeWorkInfo> EmployeeWorkInfo { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductInShop> ProductInShop { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(this.connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeMainInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EmployeeShopInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF18B1B4DC6");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.EmployeeShopInfo)
                    .HasForeignKey<EmployeeShopInfo>(d => d.EmployeeId)
                    .HasConstraintName("FK_2");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.EmployeeShopInfo)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_1");
            });

            modelBuilder.Entity<EmployeeWorkInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF1E58BE30B");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Position).IsRequired();

                entity.Property(e => e.WorkDateFrom).HasColumnType("date");

                entity.Property(e => e.WorkDateTo).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.EmployeeWorkInfo)
                    .HasForeignKey<EmployeeWorkInfo>(d => d.EmployeeId)
                    .HasConstraintName("FK_6");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductInShop>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ShopId })
                    .HasName("PK__ProductI__3270938F00E054A7");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInShop)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_3");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ProductInShop)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_4");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProductInShop)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_5");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsRequired();
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserInfo__1788CCAC5E580C5C");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserInfo)
                    .HasForeignKey<UserInfo>(d => d.UserId)
                    .HasConstraintName("FK_7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
