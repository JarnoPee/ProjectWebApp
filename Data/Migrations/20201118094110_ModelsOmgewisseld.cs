using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class ModelsOmgewisseld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Algemeenheden_Opleidingen_OpleidingId",
                table: "Algemeenheden");

            migrationBuilder.DropForeignKey(
                name: "FK_Categorieen_Opleidingen_OpleidingId",
                table: "Categorieen");

            migrationBuilder.DropForeignKey(
                name: "FK_Federaties_Opleidingen_OpleidingId",
                table: "Federaties");

            migrationBuilder.DropForeignKey(
                name: "FK_Niveaus_Opleidingen_OpleidingId",
                table: "Niveaus");

            migrationBuilder.DropForeignKey(
                name: "FK_Omschrijvingen_Opleidingen_OpleidingId",
                table: "Omschrijvingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Slot_Opleidingen_OpleidingId",
                table: "Slot");

            migrationBuilder.DropForeignKey(
                name: "FK_Voorwaarden_Opleidingen_OpleidingId",
                table: "Voorwaarden");

            migrationBuilder.DropIndex(
                name: "IX_Voorwaarden_OpleidingId",
                table: "Voorwaarden");

            migrationBuilder.DropIndex(
                name: "IX_Slot_OpleidingId",
                table: "Slot");

            migrationBuilder.DropIndex(
                name: "IX_Omschrijvingen_OpleidingId",
                table: "Omschrijvingen");

            migrationBuilder.DropIndex(
                name: "IX_Niveaus_OpleidingId",
                table: "Niveaus");

            migrationBuilder.DropIndex(
                name: "IX_Federaties_OpleidingId",
                table: "Federaties");

            migrationBuilder.DropIndex(
                name: "IX_Categorieen_OpleidingId",
                table: "Categorieen");

            migrationBuilder.DropIndex(
                name: "IX_Algemeenheden_OpleidingId",
                table: "Algemeenheden");

            migrationBuilder.DropColumn(
                name: "OpleidingId",
                table: "Voorwaarden");

            migrationBuilder.DropColumn(
                name: "OpleidingId",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "OpleidingId",
                table: "Omschrijvingen");

            migrationBuilder.DropColumn(
                name: "OpleidingId",
                table: "Niveaus");

            migrationBuilder.DropColumn(
                name: "OpleidingId",
                table: "Federaties");

            migrationBuilder.DropColumn(
                name: "OpleidingId",
                table: "Categorieen");

            migrationBuilder.DropColumn(
                name: "OpleidingId",
                table: "Algemeenheden");

            migrationBuilder.AddColumn<int>(
                name: "AlgemeenhedenID",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategorieID",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FederatieID",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NiveauID",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OmschrijvingID",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SlotID",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoorwaardenID",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_AlgemeenhedenID",
                table: "Opleidingen",
                column: "AlgemeenhedenID");

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_CategorieID",
                table: "Opleidingen",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_FederatieID",
                table: "Opleidingen",
                column: "FederatieID");

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_NiveauID",
                table: "Opleidingen",
                column: "NiveauID");

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_OmschrijvingID",
                table: "Opleidingen",
                column: "OmschrijvingID");

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_SlotID",
                table: "Opleidingen",
                column: "SlotID");

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_VoorwaardenID",
                table: "Opleidingen",
                column: "VoorwaardenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingen_Algemeenheden_AlgemeenhedenID",
                table: "Opleidingen",
                column: "AlgemeenhedenID",
                principalTable: "Algemeenheden",
                principalColumn: "AlgemeenhedenID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingen_Categorieen_CategorieID",
                table: "Opleidingen",
                column: "CategorieID",
                principalTable: "Categorieen",
                principalColumn: "CategorieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingen_Federaties_FederatieID",
                table: "Opleidingen",
                column: "FederatieID",
                principalTable: "Federaties",
                principalColumn: "FederatieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingen_Niveaus_NiveauID",
                table: "Opleidingen",
                column: "NiveauID",
                principalTable: "Niveaus",
                principalColumn: "NiveauID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingen_Omschrijvingen_OmschrijvingID",
                table: "Opleidingen",
                column: "OmschrijvingID",
                principalTable: "Omschrijvingen",
                principalColumn: "OmschrijvingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingen_Slot_SlotID",
                table: "Opleidingen",
                column: "SlotID",
                principalTable: "Slot",
                principalColumn: "SlotID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingen_Voorwaarden_VoorwaardenID",
                table: "Opleidingen",
                column: "VoorwaardenID",
                principalTable: "Voorwaarden",
                principalColumn: "VoorwaardenID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingen_Algemeenheden_AlgemeenhedenID",
                table: "Opleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingen_Categorieen_CategorieID",
                table: "Opleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingen_Federaties_FederatieID",
                table: "Opleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingen_Niveaus_NiveauID",
                table: "Opleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingen_Omschrijvingen_OmschrijvingID",
                table: "Opleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingen_Slot_SlotID",
                table: "Opleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingen_Voorwaarden_VoorwaardenID",
                table: "Opleidingen");

            migrationBuilder.DropIndex(
                name: "IX_Opleidingen_AlgemeenhedenID",
                table: "Opleidingen");

            migrationBuilder.DropIndex(
                name: "IX_Opleidingen_CategorieID",
                table: "Opleidingen");

            migrationBuilder.DropIndex(
                name: "IX_Opleidingen_FederatieID",
                table: "Opleidingen");

            migrationBuilder.DropIndex(
                name: "IX_Opleidingen_NiveauID",
                table: "Opleidingen");

            migrationBuilder.DropIndex(
                name: "IX_Opleidingen_OmschrijvingID",
                table: "Opleidingen");

            migrationBuilder.DropIndex(
                name: "IX_Opleidingen_SlotID",
                table: "Opleidingen");

            migrationBuilder.DropIndex(
                name: "IX_Opleidingen_VoorwaardenID",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "AlgemeenhedenID",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "CategorieID",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "FederatieID",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "NiveauID",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "OmschrijvingID",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "SlotID",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "VoorwaardenID",
                table: "Opleidingen");

            migrationBuilder.AddColumn<int>(
                name: "OpleidingId",
                table: "Voorwaarden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpleidingId",
                table: "Slot",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpleidingId",
                table: "Omschrijvingen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpleidingId",
                table: "Niveaus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpleidingId",
                table: "Federaties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpleidingId",
                table: "Categorieen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpleidingId",
                table: "Algemeenheden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Voorwaarden_OpleidingId",
                table: "Voorwaarden",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_OpleidingId",
                table: "Slot",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Omschrijvingen_OpleidingId",
                table: "Omschrijvingen",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Niveaus_OpleidingId",
                table: "Niveaus",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Federaties_OpleidingId",
                table: "Federaties",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorieen_OpleidingId",
                table: "Categorieen",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Algemeenheden_OpleidingId",
                table: "Algemeenheden",
                column: "OpleidingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Algemeenheden_Opleidingen_OpleidingId",
                table: "Algemeenheden",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categorieen_Opleidingen_OpleidingId",
                table: "Categorieen",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Federaties_Opleidingen_OpleidingId",
                table: "Federaties",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Niveaus_Opleidingen_OpleidingId",
                table: "Niveaus",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Omschrijvingen_Opleidingen_OpleidingId",
                table: "Omschrijvingen",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Slot_Opleidingen_OpleidingId",
                table: "Slot",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voorwaarden_Opleidingen_OpleidingId",
                table: "Voorwaarden",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
