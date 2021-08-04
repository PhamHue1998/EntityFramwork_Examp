using Microsoft.EntityFrameworkCore.Migrations;

namespace EFPhieuThu.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SoLuongKho",
                table: "nguyenLieus",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "GiaBan",
                table: "nguyenLieus",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "DonViTinh",
                table: "nguyenLieus",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SoLuongKho",
                table: "nguyenLieus",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "GiaBan",
                table: "nguyenLieus",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "DonViTinh",
                table: "nguyenLieus",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
