namespace ChemJourney.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using ChemJourney.Data.Models;
    using System.Reflection;

    public class ChemJourneyDbContext : IdentityDbContext
    {
        public ChemJourneyDbContext(DbContextOptions<ChemJourneyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Element> Elements { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly confAssembly = Assembly.GetAssembly(typeof(ChemJourneyDbContext)) ??
                Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(confAssembly);

            base.OnModelCreating(builder);
        }
    }
}
