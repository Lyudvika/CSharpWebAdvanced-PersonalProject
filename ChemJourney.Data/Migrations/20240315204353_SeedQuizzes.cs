using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class SeedQuizzes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "CategoryId", "Description", "Title" },
                values: new object[] { 1, 3, "Covers fundamental methods for measuring, separating, and identifying substances.", "Analytical Chemistry Basics" });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "CategoryId", "Description", "Title" },
                values: new object[] { 2, 2, "Explores gas laws, thermodynamics, kinetics, and quantum mechanics basics.", "Physical Chemistry Fundamentals" });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "CategoryId", "Description", "Title" },
                values: new object[] { 3, 1, "Introduces organic compound structure, reactions, and functional groups.", "Introduction to Organic Chemistry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
