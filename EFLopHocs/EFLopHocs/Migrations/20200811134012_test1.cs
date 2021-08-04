using Microsoft.EntityFrameworkCore.Migrations;

namespace EFLopHocs.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_LopID",
                table: "HocSinhs",
                column: "LopID");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_Lops_LopID",
                table: "HocSinhs",
                column: "LopID",
                principalTable: "Lops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_Lops_LopID",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_LopID",
                table: "HocSinhs");
        }
    }
}
