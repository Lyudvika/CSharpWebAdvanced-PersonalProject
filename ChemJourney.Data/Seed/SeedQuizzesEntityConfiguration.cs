using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Seed
{
    public class SeedQuizzesEntityConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasData(GenerateQuizQuestions());
        }

        private Quiz[] GenerateQuizQuestions()
        {
            ICollection<Quiz> quizzes = new HashSet<Quiz>();

            Quiz quiz;

            quiz = new Quiz()
            {
                Id = 1,
                Title = "Analytical Chemistry Basics",
                Description = "Covers fundamental methods for measuring, separating, and identifying substances.",
                CategoryId = 3
            };
            quizzes.Add(quiz);

            quiz = new Quiz()
            {
                Id = 2,
                Title = "Physical Chemistry Fundamentals",
                Description = "Explores gas laws, thermodynamics, kinetics, and quantum mechanics basics.",
                CategoryId = 2
            };
            quizzes.Add(quiz);

            quiz = new Quiz()
            {
                Id = 3,
                Title = "Introduction to Organic Chemistry",
                Description = "Introduces organic compound structure, reactions, and functional groups.",
                CategoryId = 1
            };
            quizzes.Add(quiz);

            return quizzes.ToArray();
        }
    }
}
