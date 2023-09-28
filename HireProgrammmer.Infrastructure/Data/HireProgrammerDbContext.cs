using HireProgrammer.Infrastructure.Data.Entities;
using HireProgrammmer.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}