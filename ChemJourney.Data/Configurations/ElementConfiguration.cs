using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Configurations
{
    public class ElementConfiguration : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> builder)
        {
            builder.HasOne(e => e.ChemicalGroupBlock)
                .WithMany(c => c.Elements)
                .HasForeignKey(e => e.ChemicalGroupBlockId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
