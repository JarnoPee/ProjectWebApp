using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class NamenAangepast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingId",
                table: "OpgeslagenOpleidingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opleidingen",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "OpleidingID",
                table: "Opleidingen");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Opleidingen",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opleidingen",
                table: "Opleidingen",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingId",
                table: "OpgeslagenOpleidingen",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingId",
                table: "OpgeslagenOpleidingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opleidingen",
                table: "Opleidingen");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Opleidingen");

            migrationBuilder.AddColumn<int>(
                name: "OpleidingID",
                table: "Opleidingen",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opleidingen",
                table: "Opleidingen",
                column: "OpleidingID");

            migrationBuilder.AddForeignKey(
                name: "FK_OpgeslagenOpleidingen_Opleidingen_OpleidingId",
                table: "OpgeslagenOpleidingen",
                column: "OpleidingId",
                principalTable: "Opleidingen",
                principalColumn: "OpleidingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
