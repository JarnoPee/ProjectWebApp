using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class MeerOpMeerRelatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OpgeslagenOpleidingen",
                columns: table => new
                {
                    OpgeslagenOpleidingenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlantID = table.Column<string>(nullable: true),
                    OpleidingID = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpgeslagenOpleidingen", x => x.OpgeslagenOpleidingenID);
                    table.ForeignKey(
                        name: "FK_OpgeslagenOpleidingen_AspNetUsers_KlantID",
                        column: x => x.KlantID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingID",
                        column: x => x.OpleidingID,
                        principalTable: "Opleidingen",
                        principalColumn: "OpleidingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpgeslagenOpleidingen_KlantID",
                table: "OpgeslagenOpleidingen",
                column: "KlantID");

            migrationBuilder.CreateIndex(
                name: "IX_OpgeslagenOpleidingen_OpleidingID",
                table: "OpgeslagenOpleidingen",
                column: "OpleidingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpgeslagenOpleidingen");
        }
    }
}
