using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireProgrammmer.Infrastructure.Data.Entities;
using HireProgrammer.Infrastructure.Data.Entities;

namespace HireProgrammer.Infrastructure.Data.Configurations
{
    internal class ProgrammersLanguagesConfiguration : IEntityTypeConfiguration<ProgrammerLanguage>
    {
        public void Configure(EntityTypeBuilder<ProgrammerLanguage> builder)
        {
            builder.HasData(CreateProgrammersLanguages());
        }

        internal static List<ProgrammerLanguage> CreateProgrammersLanguages()
        {
            var programmerLanguages = new List<ProgrammerLanguage>();

            programmerLanguages.Add(new ProgrammerLanguage
            {
                ProgrammerId = 1,
                LanguageId = 1
            });


            programmerLanguages.Add(new ProgrammerLanguage
            {
                ProgrammerId =1,
                LanguageId = 5
            });


            programmerLanguages.Add(new ProgrammerLanguage
            {
                ProgrammerId = 1,
                LanguageId = 6
            });


            programmerLanguages.Add(new ProgrammerLanguage
            {
                ProgrammerId = 1,
                LanguageId = 8
            });

            return programmerLanguages;
        }
    }
}
