﻿// <auto-generated />
using System;
using HireProgrammer.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HireProgrammer.Infrastructure.Migrations
{
    [DbContext(typeof(HireProgrammerDbContext))]
    [Migration("20230928200253_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HireProgrammer.Infrastructure.Data.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsFunctionalLanguage")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsFunctionalLanguage = false,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            IsFunctionalLanguage = false,
                            Name = "C"
                        },
                        new
                        {
                            Id = 3,
                            IsFunctionalLanguage = false,
                            Name = "C++"
                        },
                        new
                        {
                            Id = 4,
                            IsFunctionalLanguage = false,
                            Name = "HTML 5"
                        },
                        new
                        {
                            Id = 5,
                            IsFunctionalLanguage = false,
                            Name = "CSS 3"
                        },
                        new
                        {
                            Id = 6,
                            IsFunctionalLanguage = false,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 7,
                            IsFunctionalLanguage = false,
                            Name = "Java Script"
                        },
                        new
                        {
                            Id = 8,
                            IsFunctionalLanguage = false,
                            Name = "Python"
                        },
                        new
                        {
                            Id = 9,
                            IsFunctionalLanguage = false,
                            Name = "PHP"
                        },
                        new
                        {
                            Id = 10,
                            IsFunctionalLanguage = false,
                            Name = "Larvel"
                        },
                        new
                        {
                            Id = 11,
                            IsFunctionalLanguage = false,
                            Name = "SQL"
                        },
                        new
                        {
                            Id = 12,
                            IsFunctionalLanguage = true,
                            Name = "Haskel"
                        });
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Firms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            UserId = "7125d323-7567-4f56-b27e-6b7044014a37"
                        });
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Benefits")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("HiringPosition")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProgrammerId")
                        .HasColumnType("int");

                    b.Property<int>("StartingSalary")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("WorkingHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.HasIndex("ProgrammerId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Programmer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Programmers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Experience = 5,
                            IsActive = true,
                            ShortDescription = "I have been a programmer since 2020 and I had worked in several companies - David Holding, Ferrari Technologies. I am very hard-working, passionate and goal-orientated",
                            UserId = "ae724eb3-355b-48dd-bdaa-c1eaccf666c5"
                        });
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.ProgrammerLanguage", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("ProgrammerId")
                        .HasColumnType("int");

                    b.HasKey("LanguageId", "ProgrammerId");

                    b.HasIndex("ProgrammerId");

                    b.ToTable("ProgrammersLanguages");
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(169)
                        .HasColumnType("nvarchar(169)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(56)
                        .HasColumnType("nvarchar(56)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ae724eb3-355b-48dd-bdaa-c1eaccf666c5",
                            AccessFailedCount = 0,
                            Address = "Edelvais 6 ",
                            City = "Kazanlak",
                            ConcurrencyStamp = "9108d27b-acfe-49f0-94de-a834b4749d61",
                            Country = "Bulgaria",
                            Email = "kresa@mail.com",
                            EmailConfirmed = false,
                            IsActive = true,
                            LockoutEnabled = false,
                            Name = "kresa",
                            NormalizedEmail = "KRESA@MAIL.COM",
                            NormalizedUserName = "KRESA",
                            PasswordHash = "AQAAAAEAACcQAAAAEII3ga6LkrgS3MM1MqscAPQIhQGyUEUGZH07cLsXapqOUfEHQICQThHvssD4vDT2pg==",
                            PhoneNumber = "0886121260",
                            PhoneNumberConfirmed = false,
                            ProfilePictureUrl = "http://res.cloudinary.com/dmv8nabul/image/upload/v1671315197/images/sayxo7gbosyd1w5xd72r.png",
                            SecurityStamp = "856af79c-1995-4639-9e37-8e9690db26f4",
                            TwoFactorEnabled = false,
                            UserName = "kresa"
                        },
                        new
                        {
                            Id = "7125d323-7567-4f56-b27e-6b7044014a37",
                            AccessFailedCount = 0,
                            Address = "Plovdiv 5",
                            City = "Kazanlak",
                            ConcurrencyStamp = "1dda4304-5a0a-496c-868c-f415e8819f63",
                            Country = "Bulgaria",
                            Email = "vanko@gmail.com",
                            EmailConfirmed = false,
                            IsActive = true,
                            LockoutEnabled = false,
                            Name = "Ivanikus OOD",
                            NormalizedEmail = "VANKO@GMAIL.COM",
                            NormalizedUserName = "IVANIKUS OOD",
                            PasswordHash = "AQAAAAEAACcQAAAAEKtDD/zZYD/BB8TYo3e/nTXKQeEryF9SeQNtf8LWHGOacJ9B/gxWpoZwLGEuY3IPkg==",
                            PhoneNumber = "0888791001",
                            PhoneNumberConfirmed = false,
                            ProfilePictureUrl = "http://res.cloudinary.com/dmv8nabul/image/upload/v1671315120/images/tfcjhrtonc17iox0yoel.png",
                            SecurityStamp = "49a5f50d-1182-40b4-9469-c5aa3f47cbc1",
                            TwoFactorEnabled = false,
                            UserName = "Ivanikus OOD"
                        });
                });

            modelBuilder.Entity("LanguageProgrammer", b =>
                {
                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<int>("ProgrammersId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesId", "ProgrammersId");

                    b.HasIndex("ProgrammersId");

                    b.ToTable("LanguageProgrammer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "25f73449-f9e8-40b4-87ee-93fc6c242339",
                            ConcurrencyStamp = "2ffb8037-ca11-425b-9e4b-f7bbe5c4cdea",
                            Name = "Programmer",
                            NormalizedName = "PROGRAMMER"
                        },
                        new
                        {
                            Id = "eed2d778-89cf-4c3c-a710-c8d61811f4c7",
                            ConcurrencyStamp = "346f9290-2e6d-4af7-bfc5-3246873cecd2",
                            Name = "Firm",
                            NormalizedName = "FIRM"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "ae724eb3-355b-48dd-bdaa-c1eaccf666c5",
                            RoleId = "25f73449-f9e8-40b4-87ee-93fc6c242339"
                        },
                        new
                        {
                            UserId = "7125d323-7567-4f56-b27e-6b7044014a37",
                            RoleId = "eed2d778-89cf-4c3c-a710-c8d61811f4c7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Firm", b =>
                {
                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Post", b =>
                {
                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.Firm", null)
                        .WithMany("Posts")
                        .HasForeignKey("FirmId");

                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.Programmer", null)
                        .WithMany("Posts")
                        .HasForeignKey("ProgrammerId");
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Programmer", b =>
                {
                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.ProgrammerLanguage", b =>
                {
                    b.HasOne("HireProgrammer.Infrastructure.Data.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.Programmer", "Programmer")
                        .WithMany()
                        .HasForeignKey("ProgrammerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Programmer");
                });

            modelBuilder.Entity("LanguageProgrammer", b =>
                {
                    b.HasOne("HireProgrammer.Infrastructure.Data.Entities.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.Programmer", null)
                        .WithMany()
                        .HasForeignKey("ProgrammersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HireProgrammmer.Infrastructure.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Firm", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("HireProgrammmer.Infrastructure.Data.Entities.Programmer", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}