using Microsoft.EntityFrameworkCore.Migrations;

namespace webproje2021.Data.Migrations
{
    public partial class tablolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "kategori",
                table: "urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kategori",
                table: "urunler");
        }
    }
}
