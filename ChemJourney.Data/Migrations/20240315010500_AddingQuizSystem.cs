using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class AddingQuizSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of the quiz.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Title of the quiz."),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Quiz description."),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category ID of the quiz.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Quiz that users can solve.");

            migrationBuilder.CreateTable(
                name: "QuizQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of the question.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "The question given."),
                    OptionOne = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "First option for the quiz question."),
                    OptionTwo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Second option for the quiz question."),
                    OptionThree = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Third option for the quiz question."),
                    OptionFour = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Fourth option for the quiz question."),
                    CorrectOption = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Correct answer to the question,"),
                    QuizId = table.Column<int>(type: "int", nullable: false, comment: "Quiz ID to which the question is associated with.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizQuestions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Questions that a quiz will contain.");

            migrationBuilder.CreateTable(
                name: "QuizScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of the user scores")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "ID of the user who took the quiz."),
                    QuizId = table.Column<int>(type: "int", nullable: false, comment: "ID of the quiz."),
                    Score = table.Column<int>(type: "int", nullable: false, comment: "Score received from the quiz."),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date when the quiz was taken.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizScores_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizScores_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Information about who took which quiz.");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestions_QuizId",
                table: "QuizQuestions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizScores_QuizId",
                table: "QuizScores",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizScores_UserId",
                table: "QuizScores",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_CategoryId",
                table: "Quizzes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "QuizScores");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
