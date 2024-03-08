using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Configurations
{
    public class PostReplyEntityConfiguration : IEntityTypeConfiguration<PostReply>
    {
        public void Configure(EntityTypeBuilder<PostReply> builder)
        {
            builder.HasOne(pr => pr.Post)
                .WithMany(p => p.PostReplies)
                .HasForeignKey(pr => pr.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pr => pr.Author)
                .WithMany()
                .HasForeignKey(pr => pr.AuthorId)
                .IsRequired();
        }
    }
}
