using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Infrastructure.Data.Configurations
{
        internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
        {
            public void Configure(EntityTypeBuilder<IdentityRole> builder)
            {
                builder.HasData(new List<IdentityRole>
                {
                  new IdentityRole {
                    Id ="25f73449-f9e8-40b4-87ee-93fc6c242339" ,
                    Name = "Programmer",
                    NormalizedName = "PROGRAMMER"
                  },
                  new IdentityRole {
                    Id = "eed2d778-89cf-4c3c-a710-c8d61811f4c7",
                    Name = "Firm",
                    NormalizedName = "FIRM"
                  },
                });
            }
        }
}
