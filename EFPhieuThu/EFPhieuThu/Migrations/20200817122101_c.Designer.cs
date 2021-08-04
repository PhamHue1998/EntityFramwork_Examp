﻿// <auto-generated />
using System;
using EFPhieuThu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFPhieuThu.Migrations
{
    [DbContext(typeof(QliPhieuThu))]
    [Migration("20200817122101_c")]
    partial class c
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFPhieuThu.Entities.ChiTietPhieuThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NguyenLieuId")
                        .HasColumnType("int");

                    b.Property<int>("PhieuThuId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongBan")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NguyenLieuId");

                    b.HasIndex("PhieuThuId");

                    b.ToTable("chiTietPhieus");
                });

            modelBuilder.Entity("EFPhieuThu.Entities.LoaiNguyenLieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoaiNguyenLieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("loaiNguyenLieus");
                });

            modelBuilder.Entity("EFPhieuThu.Entities.NguyenLieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DonViTinh")
                        .HasColumnType("float");

                    b.Property<double>("GiaBan")
                        .HasColumnType("float");

                    b.Property<int>("LoaiNguyenLieuId")
                        .HasColumnType("int");

                    b.Property<double>("SoLuongKho")
                        .HasColumnType("float");

                    b.Property<string>("TenNguyenLieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LoaiNguyenLieuId");

                    b.ToTable("nguyenLieus");
                });

            modelBuilder.Entity("EFPhieuThu.Entities.PhieuThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienLap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ThanhTien")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("phieuThus");
                });

            modelBuilder.Entity("EFPhieuThu.Entities.ChiTietPhieuThu", b =>
                {
                    b.HasOne("EFPhieuThu.Entities.NguyenLieu", "NguyenLieu")
                        .WithMany()
                        .HasForeignKey("NguyenLieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFPhieuThu.Entities.PhieuThu", "PhieuThu")
                        .WithMany("ChiTietPhieuThus")
                        .HasForeignKey("PhieuThuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFPhieuThu.Entities.NguyenLieu", b =>
                {
                    b.HasOne("EFPhieuThu.Entities.LoaiNguyenLieu", "LoaiNguyenLieu")
                        .WithMany("NguyenLieus")
                        .HasForeignKey("LoaiNguyenLieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
