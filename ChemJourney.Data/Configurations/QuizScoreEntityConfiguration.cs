using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Configurations
{
    public class QuizScoreEntityConfiguration : IEntityTypeConfiguration<QuizScore>
    {
        public void Configure(EntityTypeBuilder<QuizScore> builder)
        {
            builder.HasOne(qs => qs.User)
                .WithMany()
                .HasForeignKey(qs => qs.UserId);

            builder.HasOne(qs => qs.Quiz)
                .WithMany()
                .HasForeignKey(qs => qs.QuizId);
        }
    }
}
