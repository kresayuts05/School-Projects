using HireProgrammer.Infrastructure.Data.Configurations;
using HireProgrammer.Infrastructure.Data.Entities;
using HireProgrammmer.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HireProgrammer.Infrastructure.Data.Configurations.UserRoleConfiguration;

namespace HireProgrammer.Infrastructure.Data
{
    public class HireProgrammerDbContext : IdentityDbContext<User>
    {
        public HireProgrammerDbContext(DbContextOptions<HireProgrammerDbContext> options, bool seed = true)
          : base(options)
        {

        }


        public DbSet<Language> Languages { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Programmer> Programmers { get; set; }
        public DbSet<ProgrammerLanguage> ProgrammersLanguages { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                   .Property(u => u.UserName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(60)
                .IsRequired();

            builder.Entity<ProgrammerLanguage>()
                .HasKey(pk => new { pk.LanguageId, pk.ProgrammerId });

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new LanguagesConfiguration());
            builder.ApplyConfiguration(new ProgrammerConfiguration());
            builder.ApplyConfiguration(new FirmConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UsersRolesConifiguration());

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}