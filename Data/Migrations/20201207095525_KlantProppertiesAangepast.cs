using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class KlantProppertiesAangepast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klanten");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gemeente",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Huisnummer",
                table: "AspNetUsers",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naam",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "AspNetUsers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Straat",
                table: "AspNetUsers",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voornaam",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gemeente",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Huisnummer",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Land",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Naam",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Straat",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Voornaam",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gemeente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Huisnummer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Land = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Paswoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Straat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantID);
                });
        }
    }
}
