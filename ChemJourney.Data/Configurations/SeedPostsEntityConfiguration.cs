using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Configurations
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
                DateTime = DateTime.UtcNow,
                WriterId = Guid.Parse("0C732953-0A4F-400C-B82A-142A89E37DE6")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 2,
                Title = "Demystifying Gibbs Free Energy",
                Content = "I'm struggling to grasp the concept of Gibbs free energy. How does it relate to spontaneity in chemical reactions, and what are the key factors that affect it?",
                CategoryId = 2,
                DateTime = DateTime.UtcNow,
                WriterId = Guid.Parse("0C732953-0A4F-400C-B82A-142A89E37DE6")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 3,
                Title = "Unraveling Coordination Compounds",
                Content = "What are the main differences between coordination compounds and complex ions? How do ligands influence the properties of coordination compounds?",
                CategoryId = 3,
                DateTime = DateTime.UtcNow,
                WriterId = Guid.Parse("0C732953-0A4F-400C-B82A-142A89E37DE6")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 4,
                Title = "HPLC vs. GC: Need Guidance",
                Content = "I need help understanding the principles behind chromatography techniques. How does high-performance liquid chromatography (HPLC) differ from gas chromatography (GC), and in what situations would one be preferred over the other?",
                CategoryId = 4,
                DateTime = DateTime.UtcNow,
                WriterId = Guid.Parse("466EF5F1-5313-4A18-A5AB-702F27231479")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 5,
                Title = "Cracking the Enzyme Code",
                Content = "Could someone explain the role of enzymes in biochemical reactions? How do factors like pH and temperature affect enzyme activity, and are there any real-world applications of this knowledge?",
                CategoryId = 5,
                DateTime = DateTime.UtcNow,
                WriterId = Guid.Parse("FEA4DF6C-FE3F-4947-B0DE-06717B262E1E")
            };
            posts.Add(post);

            post = new Post()
            {
                Id = 6,
                Title = "Nanotechnology",
                Content = "I recently came across the term 'nanotechnology' in the context of chemistry. Can someone shed light on how nanotechnology intersects with chemistry, and what are some notable applications or advancements in this interdisciplinary field?",
                CategoryId = 6,
                DateTime = DateTime.UtcNow,
                WriterId = Guid.Parse("466EF5F1-5313-4A18-A5AB-702F27231479")
            };
            posts.Add(post);

            return posts.ToArray();
        }
    }
}
