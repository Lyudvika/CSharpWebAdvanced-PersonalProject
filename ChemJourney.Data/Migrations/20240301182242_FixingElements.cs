using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class FixingElements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StandardState",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The standard state of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "The standard state of the element");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StandardState",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: true,
                comment: "The standard state of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The standard state of the element");
        }
    }
}
