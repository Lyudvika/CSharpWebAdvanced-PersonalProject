using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class AddingDbSetToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elements_ChemicalGroupBlock_ChemicalGroupBlockId",
                table: "Elements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalGroupBlock",
                table: "ChemicalGroupBlock");

            migrationBuilder.RenameTable(
                name: "ChemicalGroupBlock",
                newName: "ChemicalGroupBlocks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalGroupBlocks",
                table: "ChemicalGroupBlocks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Elements_ChemicalGroupBlocks_ChemicalGroupBlockId",
                table: "Elements",
                column: "ChemicalGroupBlockId",
                principalTable: "ChemicalGroupBlocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elements_ChemicalGroupBlocks_ChemicalGroupBlockId",
                table: "Elements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalGroupBlocks",
                table: "ChemicalGroupBlocks");

            migrationBuilder.RenameTable(
                name: "ChemicalGroupBlocks",
                newName: "ChemicalGroupBlock");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalGroupBlock",
                table: "ChemicalGroupBlock",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Elements_ChemicalGroupBlock_ChemicalGroupBlockId",
                table: "Elements",
                column: "ChemicalGroupBlockId",
                principalTable: "ChemicalGroupBlock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
