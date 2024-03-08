using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class FixingSizing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Content of the post.",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldComment: "Content of the post.");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "PostReplies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Content of the reply.",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Content of the reply.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                comment: "Content of the post.",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Content of the post.");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "PostReplies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Content of the reply.",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Content of the reply.");
        }
    }
}
