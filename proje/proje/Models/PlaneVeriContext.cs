using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace proje.Models
{
    public partial class PlaneVeriContext : DbContext
    {
        public PlaneVeriContext()
        {
        }

        public PlaneVeriContext(DbContextOptions<PlaneVeriContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bilet> Bilets { get; set; }
        public virtual DbSet<Havalimanlari> Havalimanlaris { get; set; }
        public virtual DbSet<IletisimBilgileri> IletisimBilgileris { get; set; }
        public virtual DbSet<Konum> Konums { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<Sefer> Sefers { get; set; }
        public virtual DbSet<Ucaklar> Ucaklars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;Trusted_Connection=true;Database=PlaneVeri");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Bilet>(entity =>
            {
                entity.ToTable("bilet");

                entity.Property(e => e.BiletFiyati).HasColumnName("biletFiyati");

                entity.Property(e => e.KullaniciId).HasColumnName("kullaniciID");

                entity.Property(e => e.SeferId).HasColumnName("SeferID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Bilets)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bilet_Kullanici");

                entity.HasOne(d => d.Sefer)
                    .WithMany(p => p.Bilets)
                    .HasForeignKey(d => d.SeferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bilet_Sefer");
            });

            modelBuilder.Entity<Havalimanlari>(entity =>
            {
                entity.ToTable("Havalimanlari");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KonumId).HasColumnName("KonumID");

                entity.HasOne(d => d.Konum)
                    .WithMany(p => p.Havalimanlaris)
                    .HasForeignKey(d => d.KonumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Havalimanlari_Konum");
            });

            modelBuilder.Entity<IletisimBilgileri>(entity =>
            {
                entity.ToTable("IletisimBilgileri");

                entity.Property(e => e.Eposta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("eposta");

                entity.Property(e => e.Konum)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TelNo).HasColumnName("telNo");
            });

            modelBuilder.Entity<Konum>(entity =>
            {
                entity.ToTable("Konum");

                entity.Property(e => e.Konum1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("konum");

                entity.Property(e => e.UstKonumId).HasColumnName("UstKonumID");

                entity.HasOne(d => d.UstKonum)
                    .WithMany(p => p.InverseUstKonum)
                    .HasForeignKey(d => d.UstKonumId)
                    .HasConstraintName("FK_Konum_Konum");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("Kullanici");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .HasColumnName("cinsiyet")
                    .IsFixedLength(true);

                entity.Property(e => e.DogumTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("dogumTarih");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KimlikNo).HasColumnName("kimlikNo");

                entity.Property(e => e.KullaniciTuru).HasColumnName("kullaniciTuru");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("password");

                entity.Property(e => e.Soyad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("telNo");
            });

            modelBuilder.Entity<Sefer>(entity =>
            {
                entity.ToTable("Sefer");

                entity.Property(e => e.InisYeri)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KalkisYeri)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("kalkisYeri");

                entity.Property(e => e.SeferTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.Havaliman)
                    .WithMany(p => p.Sefers)
                    .HasForeignKey(d => d.HavalimanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sefer_Havalimanlari");

                entity.HasOne(d => d.Ucak)
                    .WithMany(p => p.Sefers)
                    .HasForeignKey(d => d.UcakId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sefer_Ucaklar");
            });

            modelBuilder.Entity<Ucaklar>(entity =>
            {
                entity.ToTable("Ucaklar");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
