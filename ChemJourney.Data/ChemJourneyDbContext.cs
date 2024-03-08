namespace ChemJourney.Web.Data
{
	using ChemJourney.Data.Configurations;
	using ChemJourney.Data.Models;
    using ChemJourney.Data.Seed;
    using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;

	public class ChemJourneyDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
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
            builder.ApplyConfiguration(new SeedElementsEntityConfiguration());

            builder.ApplyConfiguration(new PostEntityConfiguration());
            builder.ApplyConfiguration(new PostReplyEntityConfiguration());
            builder.ApplyConfiguration(new CategoryEntityConfiguration());
            builder.ApplyConfiguration(new SeedPostsEntityConfiguration());
            builder.ApplyConfiguration(new SeedPostRepliesEntityConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
