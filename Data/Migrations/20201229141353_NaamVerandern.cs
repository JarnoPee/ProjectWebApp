using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class NaamVerandern : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpgeslagenOpleidingen_AspNetUsers_KlantID",
                table: "OpgeslagenOpleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingID",
                table: "OpgeslagenOpleidingen");

            migrationBuilder.RenameColumn(
                name: "OpleidingID",
                table: "OpgeslagenOpleidingen",
                newName: "OpleidingId");

            migrationBuilder.RenameColumn(
                name: "KlantID",
                table: "OpgeslagenOpleidingen",
                newName: "KlantId");

            migrationBuilder.RenameIndex(
                name: "IX_OpgeslagenOpleidingen_OpleidingID",
                table: "OpgeslagenOpleidingen",
                newName: "IX_OpgeslagenOpleidingen_OpleidingId");

            migrationBuilder.RenameIndex(
                name: "IX_OpgeslagenOpleidingen_KlantID",
                table: "OpgeslagenOpleidingen",
                newName: "IX_OpgeslagenOpleidingen_KlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_OpgeslagenOpleidingen_AspNetUsers_KlantId",
                table: "OpgeslagenOpleidingen",
                column: "KlantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingId",
                table: "OpgeslagenOpleidingen",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpgeslagenOpleidingen_AspNetUsers_KlantId",
                table: "OpgeslagenOpleidingen");

            migrationBuilder.DropForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingId",
                table: "OpgeslagenOpleidingen");

            migrationBuilder.RenameColumn(
                name: "OpleidingId",
                table: "OpgeslagenOpleidingen",
                newName: "OpleidingID");

            migrationBuilder.RenameColumn(
                name: "KlantId",
                table: "OpgeslagenOpleidingen",
                newName: "KlantID");

            migrationBuilder.RenameIndex(
                name: "IX_OpgeslagenOpleidingen_OpleidingId",
                table: "OpgeslagenOpleidingen",
                newName: "IX_OpgeslagenOpleidingen_OpleidingID");

            migrationBuilder.RenameIndex(
                name: "IX_OpgeslagenOpleidingen_KlantId",
                table: "OpgeslagenOpleidingen",
                newName: "IX_OpgeslagenOpleidingen_KlantID");

            migrationBuilder.AddForeignKey(
                name: "FK_OpgeslagenOpleidingen_AspNetUsers_KlantID",
                table: "OpgeslagenOpleidingen",
                column: "KlantID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingID",
                table: "OpgeslagenOpleidingen",
                column: "OpleidingID",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
