using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireProgrammer.Infrastructure.Data.Entities;

namespace HireProgrammer.Infrastructure.Data.Configurations
{

    public class LanguagesConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(CreateLanguages());
        }

        internal static List<Language> CreateLanguages()
        {
            var categories = new List<Language>();

            var category = new Language()
            {
                Id = 1,
                Name = "C#"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 2,
                Name = "C"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 3,
                Name = "C++"
            };

            categories.Add(category);
            category = new Language()
            {
                Id = 4,
                Name = "HTML 5"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 5,
                Name = "CSS 3"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 6,
                Name = "Java"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 7,
                Name = "Java Script"
            };

            categories.Add(category);


            category = new Language()
            {
                Id = 8,
                Name = "Python"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 9,
                Name = "PHP"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 10,
                Name = "Larvel"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 11,
                Name = "SQL"
            };

            categories.Add(category);

            category = new Language()
            {
                Id = 12,
                Name = "Haskel",
                IsFunctionalLanguage= true
            };

            categories.Add(category);
            return categories;
        }
    }
}