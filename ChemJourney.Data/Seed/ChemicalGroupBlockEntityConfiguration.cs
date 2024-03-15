using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Seed
{
    public class ChemicalGroupBlockEntityConfiguration : IEntityTypeConfiguration<ChemicalGroupBlock>
    {
        public void Configure(EntityTypeBuilder<ChemicalGroupBlock> builder)
        {
            builder.HasData(GenerateChemicalGroupBlocks());
        }

        private ChemicalGroupBlock[] GenerateChemicalGroupBlocks()
        {
            ICollection<ChemicalGroupBlock> groupBlocks = new HashSet<ChemicalGroupBlock>();

            ChemicalGroupBlock groupBlock;

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 1,
                Name = "Nonmetal"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 2,
                Name = "Alkali Metal"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 3,
                Name = "Alkaline Earth Metal"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 4,
                Name = "Lanthanide"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 5,
                Name = "Actinide"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 6,
                Name = "Transition Metal"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 7,
                Name = "Post-Transition Metal"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 8,
                Name = "Metalloid"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 9,
                Name = "Halogen"
            };
            groupBlocks.Add(groupBlock);

            groupBlock = new ChemicalGroupBlock()
            {
                Id = 10,
                Name = "Noble Gas"
            };
            groupBlocks.Add(groupBlock);

            return groupBlocks.ToArray();
        }
    }
}
