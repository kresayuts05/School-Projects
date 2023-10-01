using HireProgrammer.Infrastructure.Data.Entities;
using HireProgrammmer.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Infrastructure.Data.Configurations
{
    internal class ProgrammerConfiguration : IEntityTypeConfiguration<Programmer>
    {
        public void Configure(EntityTypeBuilder<Programmer> builder)
        {
            builder.HasData(new Programmer()
            {
                Id = 1,
                UserId = "ae724eb3-355b-48dd-bdaa-c1eaccf666c5",
                Experience = 5,
                ShortDescription = "I have been a programmer since 2020 and I had worked in several companies - David Holding, Ferrari Technologies. I am very hard-working, passionate and goal-orientated",
            });
        }
    }
}
