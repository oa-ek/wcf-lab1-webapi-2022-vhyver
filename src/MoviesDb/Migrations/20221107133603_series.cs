using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class series : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1605ae69-58a9-48d9-978c-96ec02d273cd", "376d3259-ec1e-4877-87db-e140fa67462a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1605ae69-58a9-48d9-978c-96ec02d273cd", "707e4e02-dec4-4e91-bbd1-8985b071c4fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf9fc6dc-f3f9-42b7-95f2-2878eaebe826", "707e4e02-dec4-4e91-bbd1-8985b071c4fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1605ae69-58a9-48d9-978c-96ec02d273cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf9fc6dc-f3f9-42b7-95f2-2878eaebe826");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "376d3259-ec1e-4877-87db-e140fa67462a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "707e4e02-dec4-4e91-bbd1-8985b071c4fb");

            migrationBuilder.AddColumn<int>(
                name: "Seasons",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "896f1059-1c01-405b-bca5-ac6eea8622dc", "8c31ee87-75f9-4bb2-848a-10b7d8383a1a", "User", "USER" },
                    { "fa8ce995-8f77-413a-8be2-df2cb157ca55", "bd067906-e79b-4698-a285-0341b124148f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ca66c4e-d962-492e-a2a8-420af4dab53c", 0, "4ab27bb3-d110-462c-9d0a-0266d7fe1d1f", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJ8jDFLopB6+hKqw6KR7rcUvU9DWUu9NZTAZHuDu5gp4Zp/Y+EqpwSvKViC0HYzsxQ==", null, false, "e8bb124d-c48d-41f6-8b06-7b3108a2c4e2", false, "admin@gmail.com" },
                    { "3f0b7e17-7759-4198-83e0-bcbfc8ec617c", 0, "3736a4fc-9cd4-4bf7-ab17-ea66e4ea97e8", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAENbhaUsw16b92v8+v/iuPjsEFqQrK+03IQwBBF0Cw/Krt8kRY5WlScLSIGklLab3fQ==", null, false, "49848b1c-3989-4b75-8f71-bb3f153fdbd9", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "896f1059-1c01-405b-bca5-ac6eea8622dc", "1ca66c4e-d962-492e-a2a8-420af4dab53c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fa8ce995-8f77-413a-8be2-df2cb157ca55", "1ca66c4e-d962-492e-a2a8-420af4dab53c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "896f1059-1c01-405b-bca5-ac6eea8622dc", "3f0b7e17-7759-4198-83e0-bcbfc8ec617c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "896f1059-1c01-405b-bca5-ac6eea8622dc", "1ca66c4e-d962-492e-a2a8-420af4dab53c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa8ce995-8f77-413a-8be2-df2cb157ca55", "1ca66c4e-d962-492e-a2a8-420af4dab53c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "896f1059-1c01-405b-bca5-ac6eea8622dc", "3f0b7e17-7759-4198-83e0-bcbfc8ec617c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "896f1059-1c01-405b-bca5-ac6eea8622dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa8ce995-8f77-413a-8be2-df2cb157ca55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ca66c4e-d962-492e-a2a8-420af4dab53c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f0b7e17-7759-4198-83e0-bcbfc8ec617c");

            migrationBuilder.DropColumn(
                name: "Seasons",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1605ae69-58a9-48d9-978c-96ec02d273cd", "b70f65b0-8777-47e9-8b43-2ef764a8f866", "User", "USER" },
                    { "bf9fc6dc-f3f9-42b7-95f2-2878eaebe826", "d25b0b9c-a0e9-4d10-ac65-698455227826", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "376d3259-ec1e-4877-87db-e140fa67462a", 0, "04a46f87-11f5-4971-a640-3f90b26abba4", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEJyqju6E/dvTcUKmh0yEmUGswhGAZTLMnDdqvtB7Hc4LdzHvXesiD17HK52vimp6uA==", null, false, "22f4addd-831f-4d82-8236-26173962e036", false, "user@gmail.com" },
                    { "707e4e02-dec4-4e91-bbd1-8985b071c4fb", 0, "c451b330-f79d-48cf-b38d-61eba663c8c6", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEH0qRMIZwxS2pbpWiaAHz7U38GmFcF6DkEA83y5vib16IviUTW+2eBHkEu0OlS2oQQ==", null, false, "83013d5a-b36f-4c89-acb3-8985ec11513f", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1605ae69-58a9-48d9-978c-96ec02d273cd", "376d3259-ec1e-4877-87db-e140fa67462a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1605ae69-58a9-48d9-978c-96ec02d273cd", "707e4e02-dec4-4e91-bbd1-8985b071c4fb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf9fc6dc-f3f9-42b7-95f2-2878eaebe826", "707e4e02-dec4-4e91-bbd1-8985b071c4fb" });
        }
    }
}
