namespace ChemJourney.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using ChemJourney.Data.Models;
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using ChemJourney.Data.Configurations;

    public class ChemJourneyDbContext : IdentityDbContext<ApplicationUser>
    {
        public ChemJourneyDbContext(DbContextOptions<ChemJourneyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Element> Elements { get; set; } = null!;

        public DbSet<ChemicalGroupBlock> ChemicalGroupBlocks { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Post> Posts { get; set; } = null!;

        public DbSet<PostReply> PostReplies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ElementEntityConfiguration());
            builder.ApplyConfiguration(new ChemicalGroupBlockEntityConfiguration());
            builder.ApplyConfiguration(new SeedElementsConfiguration());

            builder.ApplyConfiguration(new PostEntityConfiguration());
            builder.ApplyConfiguration(new CategoryEntityConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
