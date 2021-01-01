﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proje.Models;

namespace proje.Migrations
{
    [DbContext(typeof(PlaneVeriContext))]
    partial class PlaneVeriContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("proje.Models.Bilet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BiletFiyati")
                        .HasColumnName("biletFiyati")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnName("kullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("SeferId")
                        .HasColumnName("SeferID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("SeferId");

                    b.ToTable("bilet");
                });

            modelBuilder.Entity("proje.Models.Havalimanlari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("KonumId")
                        .HasColumnName("KonumID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KonumId");

                    b.ToTable("Havalimanlari");
                });

            modelBuilder.Entity("proje.Models.IletisimBilgileri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnName("eposta")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Konum")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("TelNo")
                        .HasColumnName("telNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IletisimBilgileri");
                });

            modelBuilder.Entity("proje.Models.Konum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Konum1")
                        .IsRequired()
                        .HasColumnName("konum")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("UstKonumId")
                        .HasColumnName("UstKonumID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UstKonumId");

                    b.ToTable("Konum");
                });

            modelBuilder.Entity("proje.Models.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("Cinsiyet")
                        .HasColumnName("cinsiyet")
                        .HasColumnType("bit")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<DateTime>("DogumTarih")
                        .HasColumnName("dogumTarih")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("KimlikNo")
                        .HasColumnName("kimlikNo")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciTuru")
                        .HasColumnName("kullaniciTuru")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnName("telNo")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("proje.Models.Sefer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HavalimanId")
                        .HasColumnType("int");

                    b.Property<string>("InisYeri")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("KalkisYeri")
                        .IsRequired()
                        .HasColumnName("kalkisYeri")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("SeferTarihi")
                        .HasColumnType("datetime");

                    b.Property<int>("UcakId")
                        .HasColumnType("int");

                    b.Property<byte>("YolcuSayisi")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("HavalimanId");

                    b.HasIndex("UcakId");

                    b.ToTable("Sefer");
                });

            modelBuilder.Entity("proje.Models.Ucaklar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ad")
                        .HasColumnType("int");

                    b.Property<byte>("KoltukSayisi")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Ucaklar");
                });

            modelBuilder.Entity("proje.Models.Bilet", b =>
                {
                    b.HasOne("proje.Models.Kullanici", "Kullanici")
                        .WithMany("Bilets")
                        .HasForeignKey("KullaniciId")
                        .HasConstraintName("FK_bilet_Kullanici")
                        .IsRequired();

                    b.HasOne("proje.Models.Sefer", "Sefer")
                        .WithMany("Bilets")
                        .HasForeignKey("SeferId")
                        .HasConstraintName("FK_bilet_Sefer")
                        .IsRequired();
                });

            modelBuilder.Entity("proje.Models.Havalimanlari", b =>
                {
                    b.HasOne("proje.Models.Konum", "Konum")
                        .WithMany("Havalimanlaris")
                        .HasForeignKey("KonumId")
                        .HasConstraintName("FK_Havalimanlari_Konum")
                        .IsRequired();
                });

            modelBuilder.Entity("proje.Models.Konum", b =>
                {
                    b.HasOne("proje.Models.Konum", "UstKonum")
                        .WithMany("InverseUstKonum")
                        .HasForeignKey("UstKonumId")
                        .HasConstraintName("FK_Konum_Konum");
                });

            modelBuilder.Entity("proje.Models.Sefer", b =>
                {
                    b.HasOne("proje.Models.Havalimanlari", "Havaliman")
                        .WithMany("Sefers")
                        .HasForeignKey("HavalimanId")
                        .HasConstraintName("FK_Sefer_Havalimanlari")
                        .IsRequired();

                    b.HasOne("proje.Models.Ucaklar", "Ucak")
                        .WithMany("Sefers")
                        .HasForeignKey("UcakId")
                        .HasConstraintName("FK_Sefer_Ucaklar")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
