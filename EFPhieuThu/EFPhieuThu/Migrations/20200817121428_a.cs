using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFPhieuThu.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loaiNguyenLieus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiNguyenLieu = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiNguyenLieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phieuThus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(nullable: false),
                    NhanVienLap = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    ThanhTien = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phieuThus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nguyenLieus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiNguyenLieuId = table.Column<int>(nullable: false),
                    TenNguyenLieu = table.Column<string>(nullable: true),
                    GiaBan = table.Column<double>(nullable: false),
                    DonViTinh = table.Column<double>(nullable: false),
                    SoLuongKho = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguyenLieus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nguyenLieus_loaiNguyenLieus_LoaiNguyenLieuId",
                        column: x => x.LoaiNguyenLieuId,
                        principalTable: "loaiNguyenLieus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietPhieus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenLieuId = table.Column<int>(nullable: false),
                    PhieuThuId = table.Column<int>(nullable: false),
                    SoLuongBan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietPhieus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chiTietPhieus_nguyenLieus_NguyenLieuId",
                        column: x => x.NguyenLieuId,
                        principalTable: "nguyenLieus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietPhieus_phieuThus_PhieuThuId",
                        column: x => x.PhieuThuId,
                        principalTable: "phieuThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chiTietPhieus_NguyenLieuId",
                table: "chiTietPhieus",
                column: "NguyenLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietPhieus_PhieuThuId",
                table: "chiTietPhieus",
                column: "PhieuThuId");

            migrationBuilder.CreateIndex(
                name: "IX_nguyenLieus_LoaiNguyenLieuId",
                table: "nguyenLieus",
                column: "LoaiNguyenLieuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietPhieus");

            migrationBuilder.DropTable(
                name: "nguyenLieus");

            migrationBuilder.DropTable(
                name: "phieuThus");

            migrationBuilder.DropTable(
                name: "loaiNguyenLieus");
        }
    }
}
