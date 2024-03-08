using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace ChemJourney.Data.Seed
{
    public class SeedPostsEntityConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(GeneratePosts());
        }

        private Post[] GeneratePosts()
        {
            ICollection<Post> posts = new HashSet<Post>();

            Post post;

            post = new Post()
            {
                Id = 1,
                Title = "Decoding Organic Resonance",
                Content = "Can someone explain the concept of resonance in organic chemistry and provide examples to illustrate its significance in the stability of molecules?",
                CategoryId = 1,
                DateTime = DateTime.ParseExact("05/01/2024 10:30", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                AuthorId = Guid.Parse("2D42EE05-AABF-44FA-91C8-D4F7CD258E44")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 2,
                Title = "Demystifying Gibbs Free Energy",
                Content = "I'm struggling to grasp the concept of Gibbs free energy. How does it relate to spontaneity in chemical reactions, and what are the key factors that affect it?",
                CategoryId = 2,
                DateTime = DateTime.ParseExact("05/03/2023 15:30", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                AuthorId = Guid.Parse("FDEB91A2-491F-40B6-83F6-B0FF231F9253")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 3,
                Title = "Unraveling Coordination Compounds",
                Content = "What are the main differences between coordination compounds and complex ions? How do ligands influence the properties of coordination compounds?",
                CategoryId = 3,
                DateTime = DateTime.ParseExact("20/02/2024 20:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                AuthorId = Guid.Parse("FDEB91A2-491F-40B6-83F6-B0FF231F9253")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 4,
                Title = "HPLC vs. GC: Need Guidance",
                Content = "I need help understanding the principles behind chromatography techniques. How does high-performance liquid chromatography (HPLC) differ from gas chromatography (GC), and in what situations would one be preferred over the other?",
                CategoryId = 4,
                DateTime = DateTime.ParseExact("05/03/2023 10:30", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                AuthorId = Guid.Parse("8A0F20BD-0612-4F85-98C1-45BAC15088EB")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 5,
                Title = "Cracking the Enzyme Code",
                Content = "Could someone explain the role of enzymes in biochemical reactions? How do factors like pH and temperature affect enzyme activity, and are there any real-world applications of this knowledge?",
                CategoryId = 5,
                DateTime = DateTime.ParseExact("21/01/2024 18:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                AuthorId = Guid.Parse("8A0F20BD-0612-4F85-98C1-45BAC15088EB")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 6,
                Title = "Nanotechnology",
                Content = "I recently came across the term 'nanotechnology' in the context of chemistry. Can someone shed light on how nanotechnology intersects with chemistry, and what are some notable applications or advancements in this interdisciplinary field?",
                CategoryId = 6,
                DateTime = DateTime.ParseExact("01/01/2024 08:30", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                AuthorId = Guid.Parse("8A0F20BD-0612-4F85-98C1-45BAC15088EB")
            };
            posts.Add(post);

            return posts.ToArray();
        }
    }
}
