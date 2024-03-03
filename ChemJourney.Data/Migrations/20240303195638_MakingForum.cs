using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class MakingForum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "ChemicalGroupBlocks",
                comment: "The types of chemical group blocks that exist in the periodic table.");

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Elements",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                comment: "The symbol of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The symbol of the element");

            migrationBuilder.AlterColumn<string>(
                name: "StandardState",
                table: "Elements",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "The standard state of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The standard state of the element");

            migrationBuilder.AlterColumn<string>(
                name: "OxidationStates",
                table: "Elements",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "The standart state of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The standart state of the element");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Elements",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "The number of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The number of the element");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalGroupBlocks",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "The Name of the chemical group block.",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The Name of the chemical group block.");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of the category")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of the category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Categories that a post might have.");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of the post.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Title of the post."),
                    Content = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Content of the post."),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category ID of the post."),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time when the post has been posted."),
                    UserId = table.Column<int>(type: "int", nullable: false, comment: "Id of the user who wrote the post."),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "A post that an user can submit to the forum.");

            migrationBuilder.CreateTable(
                name: "PostReplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of the post reply.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Content of the reply."),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time when the reply is given."),
                    UserId = table.Column<int>(type: "int", nullable: false, comment: "User Id of the person who gave the reply."),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostReplies_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostReplies_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                },
                comment: "Replies that are given to a post.");

            migrationBuilder.CreateIndex(
                name: "IX_PostReplies_PostId",
                table: "PostReplies",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReplies_UserId1",
                table: "PostReplies",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId1",
                table: "Posts",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostReplies");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AlterTable(
                name: "ChemicalGroupBlocks",
                oldComment: "The types of chemical group blocks that exist in the periodic table.");

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The symbol of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldComment: "The symbol of the element");

            migrationBuilder.AlterColumn<string>(
                name: "StandardState",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The standard state of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "The standard state of the element");

            migrationBuilder.AlterColumn<string>(
                name: "OxidationStates",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The standart state of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "The standart state of the element");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The number of the element",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "The number of the element");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalGroupBlocks",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The Name of the chemical group block.",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "The Name of the chemical group block.");
        }
    }
}
