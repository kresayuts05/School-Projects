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
    internal class UserRoleConfiguration
    {
        public class UsersRolesConifiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
        {
            public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
            {
                builder.HasData(GiveUsersRoles());
            }

            private List<IdentityUserRole<string>> GiveUsersRoles()
            {
                var users = new List<IdentityUserRole<string>>();

                users.Add(new IdentityUserRole<string>()
                {
                    RoleId = "25f73449-f9e8-40b4-87ee-93fc6c242339",
                    UserId = "ae724eb3-355b-48dd-bdaa-c1eaccf666c5"
                });

                users.Add(new IdentityUserRole<string>()
                {
                    RoleId = "eed2d778-89cf-4c3c-a710-c8d61811f4c7",
                    UserId = "7125d323-7567-4f56-b27e-6b7044014a37"
                });

                return users;
            }
        }
    }
}
