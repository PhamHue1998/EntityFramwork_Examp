using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFKhoaHocs.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoaHocs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoaHoc = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    HocPhi = table.Column<double>(nullable: false),
                    NgayBatDau = table.Column<DateTime>(nullable: false),
                    NgayKetThuc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hocViens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocID = table.Column<int>(nullable: false),
                    HoTen = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    QueQuan = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    Sdt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hocViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hocViens_KhoaHocs_KhoaHocID",
                        column: x => x.KhoaHocID,
                        principalTable: "KhoaHocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ngayHocs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocID = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ngayHocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ngayHocs_KhoaHocs_KhoaHocID",
                        column: x => x.KhoaHocID,
                        principalTable: "KhoaHocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hocViens_KhoaHocID",
                table: "hocViens",
                column: "KhoaHocID");

            migrationBuilder.CreateIndex(
                name: "IX_ngayHocs_KhoaHocID",
                table: "ngayHocs",
                column: "KhoaHocID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hocViens");

            migrationBuilder.DropTable(
                name: "ngayHocs");

            migrationBuilder.DropTable(
                name: "KhoaHocs");
        }
    }
}
