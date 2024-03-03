﻿using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemJourney.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Organic Chemistry"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Physical Chemistry"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Analytical Chemistry"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Inorganic Chemistry"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Biochemistry"
            };
            categories.Add(category);


            return categories.ToArray();
        }
    }
}
