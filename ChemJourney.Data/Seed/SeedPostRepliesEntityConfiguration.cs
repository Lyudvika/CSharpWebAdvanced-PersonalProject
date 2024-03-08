using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace ChemJourney.Data.Seed
{
    public class SeedPostRepliesEntityConfiguration : IEntityTypeConfiguration<PostReply>
    {
        public void Configure(EntityTypeBuilder<PostReply> builder)
        {
            builder.HasData(GeneratePostReplies());
        }

        private PostReply[] GeneratePostReplies()
        {
            ICollection<PostReply> postReplies = new HashSet<PostReply>();

            PostReply reply;

            reply = new PostReply()
            {
                Id = 1,
                Content = "Resonance in organic chemistry refers to the delocalization of electrons within a molecule, often represented by multiple resonance structures. This phenomenon enhances the stability of molecules by distributing electron density. An example is the resonance in benzene, where electrons are shared across all carbon atoms, contributing to the overall stability of the aromatic ring. Resonance is crucial for understanding molecular stability and reactivity in various organic compounds.",
                PostId = 1,
                DateTime = DateTime.ParseExact("05/01/2024 11:30", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                AuthorId = Guid.Parse("8A0F20BD-0612-4F85-98C1-45BAC15088EB")
            };
            postReplies.Add(reply);

            return postReplies.ToArray();
        }
    }
}
