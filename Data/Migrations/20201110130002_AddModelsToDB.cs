using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class AddModelsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 100, nullable: false),
                    Voornaam = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Land = table.Column<string>(maxLength: 100, nullable: false),
                    Straat = table.Column<string>(maxLength: 255, nullable: false),
                    Huisnummer = table.Column<string>(maxLength: 10, nullable: false),
                    Postcode = table.Column<string>(maxLength: 20, nullable: false),
                    Gemeente = table.Column<string>(maxLength: 100, nullable: false),
                    Paswoord = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantID);
                });

            migrationBuilder.CreateTable(
                name: "Opleidingen",
                columns: table => new
                {
                    OpleidingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Prijs = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opleidingen", x => x.OpleidingID);
                });

            migrationBuilder.CreateTable(
                name: "Algemeenheden",
                columns: table => new
                {
                    AlgemeenhedenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Algemeenheden", x => x.AlgemeenhedenID);
                    table.ForeignKey(
                        name: "FK_Algemeenheden_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorieen",
                columns: table => new
                {
                    CategorieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 50, nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorieen", x => x.CategorieID);
                    table.ForeignKey(
                        name: "FK_Categorieen_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Federaties",
                columns: table => new
                {
                    FederatieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Federaties", x => x.FederatieID);
                    table.ForeignKey(
                        name: "FK_Federaties_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Niveaus",
                columns: table => new
                {
                    NiveauID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveaus", x => x.NiveauID);
                    table.ForeignKey(
                        name: "FK_Niveaus_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Omschrijvingen",
                columns: table => new
                {
                    OmschrijvingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Omschrijvingen", x => x.OmschrijvingID);
                    table.ForeignKey(
                        name: "FK_Omschrijvingen_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slot",
                columns: table => new
                {
                    SlotID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slot", x => x.SlotID);
                    table.ForeignKey(
                        name: "FK_Slot_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voorwaarden",
                columns: table => new
                {
                    VoorwaardenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voorwaarden", x => x.VoorwaardenID);
                    table.ForeignKey(
                        name: "FK_Voorwaarden_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Algemeenheden_OpleidingId",
                table: "Algemeenheden",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorieen_OpleidingId",
                table: "Categorieen",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Federaties_OpleidingId",
                table: "Federaties",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Niveaus_OpleidingId",
                table: "Niveaus",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Omschrijvingen_OpleidingId",
                table: "Omschrijvingen",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_OpleidingId",
                table: "Slot",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Voorwaarden_OpleidingId",
                table: "Voorwaarden",
                column: "OpleidingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Algemeenheden");

            migrationBuilder.DropTable(
                name: "Categorieen");

            migrationBuilder.DropTable(
                name: "Federaties");

            migrationBuilder.DropTable(
                name: "Klanten");

            migrationBuilder.DropTable(
                name: "Niveaus");

            migrationBuilder.DropTable(
                name: "Omschrijvingen");

            migrationBuilder.DropTable(
                name: "Slot");

            migrationBuilder.DropTable(
                name: "Voorwaarden");

            migrationBuilder.DropTable(
                name: "Opleidingen");
        }
    }
}
