using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StockMarket.Models
{
    public partial class StockMarketContext : DbContext
    {
        public StockMarketContext()
        {
        }

        public StockMarketContext(DbContextOptions<StockMarketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CompanyEntity> CompanyEntity { get; set; }
        public virtual DbSet<StockExchangeEntity> StockExchangeEntity { get; set; }
        public virtual DbSet<StockPriceEntity> StockPriceEntity { get; set; }
        public virtual DbSet<UserEntity> UserEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-L3NOD3AR\\ROHITNAGARAJ;Database=StockMarket;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.BoardOfDirect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BriefWriteUp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ceo)
                    .HasColumnName("CEO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Companystockcode)
                    .HasColumnName("companystockcode")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ListedStockExchange).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Turnover).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.ListedStockExchangeNavigation)
                    .WithMany(p => p.CompanyEntity)
                    .HasForeignKey(d => d.ListedStockExchange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyEntity_StockExchangeEntity");
            });

            modelBuilder.Entity<StockExchangeEntity>(entity =>
            {
                entity.HasKey(e => e.Seid);

                entity.Property(e => e.Seid)
                    .HasColumnName("SEId")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brief)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockExchange)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockPriceEntity>(entity =>
            {
                entity.HasKey(e => new { e.CompanyStockCode, e.Date, e.Time });

                entity.Property(e => e.CompanyStockCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.CurrentPrice).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StockExchange)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Confirmed)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
