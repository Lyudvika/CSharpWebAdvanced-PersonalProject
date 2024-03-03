using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Configurations
{
    public class PostReplyEntityConfiguration : IEntityTypeConfiguration<PostReply>
    {
        public void Configure(EntityTypeBuilder<PostReply> builder)
        {
        }
    }
}
