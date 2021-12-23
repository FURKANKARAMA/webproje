using Microsoft.EntityFrameworkCore.Migrations;

namespace webproje2021.Data.Migrations
{
    public partial class Tablolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminsifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullanicisifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urunadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kalorisi = table.Column<int>(type: "int", nullable: false),
                    fiyati = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "kullanici");

            migrationBuilder.DropTable(
                name: "urunler");
        }
    }
}
