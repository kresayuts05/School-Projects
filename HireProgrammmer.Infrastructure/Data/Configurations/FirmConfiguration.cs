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
    internal class FirmConfiguration : IEntityTypeConfiguration<Firm>
    {
        public void Configure(EntityTypeBuilder<Firm> builder)
        {
            builder.HasData(new Firm()
            {
                Id = 1,
                UserId = "7125d323-7567-4f56-b27e-6b7044014a37"
            });
        }
    }
}
