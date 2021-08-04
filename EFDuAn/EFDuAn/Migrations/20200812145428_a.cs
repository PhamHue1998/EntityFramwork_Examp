using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDuAn.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_phanCongs_DuAnId",
                table: "phanCongs",
                column: "DuAnId");

            migrationBuilder.CreateIndex(
                name: "IX_phanCongs_NhanVienId",
                table: "phanCongs",
                column: "NhanVienId");

            migrationBuilder.AddForeignKey(
                name: "FK_phanCongs_duAns_DuAnId",
                table: "phanCongs",
                column: "DuAnId",
                principalTable: "duAns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_phanCongs_nhanViens_NhanVienId",
                table: "phanCongs",
                column: "NhanVienId",
                principalTable: "nhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_phanCongs_duAns_DuAnId",
                table: "phanCongs");

            migrationBuilder.DropForeignKey(
                name: "FK_phanCongs_nhanViens_NhanVienId",
                table: "phanCongs");

            migrationBuilder.DropIndex(
                name: "IX_phanCongs_DuAnId",
                table: "phanCongs");

            migrationBuilder.DropIndex(
                name: "IX_phanCongs_NhanVienId",
                table: "phanCongs");
        }
    }
}
