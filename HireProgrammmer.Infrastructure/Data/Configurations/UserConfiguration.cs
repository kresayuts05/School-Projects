using HireProgrammmer.Infrastructure.Data.Entities;
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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "ae724eb3-355b-48dd-bdaa-c1eaccf666c5",
                UserName = "kresa",
                Name = "kresa",
                NormalizedUserName = "KRESA",
                Email = "kresa@mail.com",
                NormalizedEmail = "KRESA@MAIL.COM",
                PhoneNumber = "0886121260",
                City = "Kazanlak",
                Address = "Edelvais 6 ",
                Country = "Bulgaria",
                ProfilePictureUrl = "http://res.cloudinary.com/dmv8nabul/image/upload/v1671315197/images/sayxo7gbosyd1w5xd72r.png"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "123456");

            users.Add(user);

            user = new User()
            {
                Id = "7125d323-7567-4f56-b27e-6b7044014a37",
                UserName = "Ivanikus OOD",
                Name = "Ivanikus OOD",
                NormalizedUserName = "IVANIKUS OOD",
                Email = "vanko@gmail.com",
                NormalizedEmail = "VANKO@GMAIL.COM",
                PhoneNumber = "0888791001",
                City = "Kazanlak",
                Address = "Plovdiv 5",
                Country = "Bulgaria",
                ProfilePictureUrl = "http://res.cloudinary.com/dmv8nabul/image/upload/v1671315120/images/tfcjhrtonc17iox0yoel.png"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "123456");

            users.Add(user);

            return users;
        }
    }
}
