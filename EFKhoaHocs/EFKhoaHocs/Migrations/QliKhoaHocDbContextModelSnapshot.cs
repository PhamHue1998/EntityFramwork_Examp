﻿// <auto-generated />
using System;
using EFKhoaHocs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFKhoaHocs.Migrations
{
    [DbContext(typeof(QliKhoaHocDbContext))]
    partial class QliKhoaHocDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFKhoaHocs.Entities.HocVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhoaHocID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueQuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KhoaHocID");

                    b.ToTable("hocViens");
                });

            modelBuilder.Entity("EFKhoaHocs.Entities.KhoaHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("HocPhi")
                        .HasColumnType("float");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKhoaHoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KhoaHocs");
                });

            modelBuilder.Entity("EFKhoaHocs.Entities.NgayHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhoaHocID")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KhoaHocID");

                    b.ToTable("ngayHocs");
                });

            modelBuilder.Entity("EFKhoaHocs.Entities.HocVien", b =>
                {
                    b.HasOne("EFKhoaHocs.Entities.KhoaHoc", "KhoaHoc")
                        .WithMany("HocViens")
                        .HasForeignKey("KhoaHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFKhoaHocs.Entities.NgayHoc", b =>
                {
                    b.HasOne("EFKhoaHocs.Entities.KhoaHoc", "KhoaHoc")
                        .WithMany()
                        .HasForeignKey("KhoaHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}