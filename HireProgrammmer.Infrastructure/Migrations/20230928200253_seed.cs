using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireProgrammer.Infrastructure.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25f73449-f9e8-40b4-87ee-93fc6c242339", "2ffb8037-ca11-425b-9e4b-f7bbe5c4cdea", "Programmer", "PROGRAMMER" },
                    { "eed2d778-89cf-4c3c-a710-c8d61811f4c7", "346f9290-2e6d-4af7-bfc5-3246873cecd2", "Firm", "FIRM" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7125d323-7567-4f56-b27e-6b7044014a37", 0, "Plovdiv 5", "Kazanlak", "1dda4304-5a0a-496c-868c-f415e8819f63", "Bulgaria", "vanko@gmail.com", false, true, false, null, "Ivanikus OOD", "VANKO@GMAIL.COM", "IVANIKUS OOD", "AQAAAAEAACcQAAAAEKtDD/zZYD/BB8TYo3e/nTXKQeEryF9SeQNtf8LWHGOacJ9B/gxWpoZwLGEuY3IPkg==", "0888791001", false, "http://res.cloudinary.com/dmv8nabul/image/upload/v1671315120/images/tfcjhrtonc17iox0yoel.png", "49a5f50d-1182-40b4-9469-c5aa3f47cbc1", false, "Ivanikus OOD" },
                    { "ae724eb3-355b-48dd-bdaa-c1eaccf666c5", 0, "Edelvais 6 ", "Kazanlak", "9108d27b-acfe-49f0-94de-a834b4749d61", "Bulgaria", "kresa@mail.com", false, true, false, null, "kresa", "KRESA@MAIL.COM", "KRESA", "AQAAAAEAACcQAAAAEII3ga6LkrgS3MM1MqscAPQIhQGyUEUGZH07cLsXapqOUfEHQICQThHvssD4vDT2pg==", "0886121260", false, "http://res.cloudinary.com/dmv8nabul/image/upload/v1671315197/images/sayxo7gbosyd1w5xd72r.png", "856af79c-1995-4639-9e37-8e9690db26f4", false, "kresa" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsFunctionalLanguage", "Name" },
                values: new object[,]
                {
                    { 1, false, "C#" },
                    { 2, false, "C" },
                    { 3, false, "C++" },
                    { 4, false, "HTML 5" },
                    { 5, false, "CSS 3" },
                    { 6, false, "Java" },
                    { 7, false, "Java Script" },
                    { 8, false, "Python" },
                    { 9, false, "PHP" },
                    { 10, false, "Larvel" },
                    { 11, false, "SQL" },
                    { 12, true, "Haskel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "eed2d778-89cf-4c3c-a710-c8d61811f4c7", "7125d323-7567-4f56-b27e-6b7044014a37" },
                    { "25f73449-f9e8-40b4-87ee-93fc6c242339", "ae724eb3-355b-48dd-bdaa-c1eaccf666c5" }
                });

            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "Id", "IsActive", "UserId" },
                values: new object[] { 1, true, "7125d323-7567-4f56-b27e-6b7044014a37" });

            migrationBuilder.InsertData(
                table: "Programmers",
                columns: new[] { "Id", "Experience", "IsActive", "ShortDescription", "UserId" },
                values: new object[] { 1, 5, true, "I have been a programmer since 2020 and I had worked in several companies - David Holding, Ferrari Technologies. I am very hard-working, passionate and goal-orientated", "ae724eb3-355b-48dd-bdaa-c1eaccf666c5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eed2d778-89cf-4c3c-a710-c8d61811f4c7", "7125d323-7567-4f56-b27e-6b7044014a37" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25f73449-f9e8-40b4-87ee-93fc6c242339", "ae724eb3-355b-48dd-bdaa-c1eaccf666c5" });

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Programmers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25f73449-f9e8-40b4-87ee-93fc6c242339");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eed2d778-89cf-4c3c-a710-c8d61811f4c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7125d323-7567-4f56-b27e-6b7044014a37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae724eb3-355b-48dd-bdaa-c1eaccf666c5");
        }
    }
}
