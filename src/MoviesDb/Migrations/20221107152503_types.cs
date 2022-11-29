using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_PublisherCountries_PublisherCountryId",
                table: "Movies");

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
                name: "Type",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "PublisherCountryId",
                table: "Movies",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_PublisherCountryId",
                table: "Movies",
                newName: "IX_Movies_TypeId");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "446a5531-d3c4-4607-94f9-ae4271529f70", "b4e62473-f1ce-418b-ada0-7ed73ffd78c3", "User", "USER" },
                    { "e9c42a9c-d52b-4c0c-9656-a661211b6ff2", "41266aff-3432-4a3f-9a2c-727992ffe640", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21b54ce2-ab7c-4458-b43e-1b4dd4acff53", 0, "7d3338bc-e670-4952-b687-7863c79f9568", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENsqA5gSzTLDxClkK07q7kA5eloyJZJFBAzhn8OGHpTjSfol7QUGh2JQai5LL7Ydlg==", null, false, "3be2f2d9-9976-4f3a-ac96-432027042a34", false, "admin@gmail.com" },
                    { "6b155db3-30f2-491a-a133-95e10729df23", 0, "939c7152-a3ac-4d44-9b0d-3302c92fd617", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEL6/Gm5qcbJkLl6W2xy8d6Nuh2/Zz/BvpqCOyl6hUF4nGewPs2Hdw8D98S4V4IO+gw==", null, false, "70ee17bb-3953-4001-aaa5-9d48ab3d3a0c", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9c42a9c-d52b-4c0c-9656-a661211b6ff2", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "6b155db3-30f2-491a-a133-95e10729df23" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CountryId",
                table: "Movies",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_PublisherCountries_CountryId",
                table: "Movies",
                column: "CountryId",
                principalTable: "PublisherCountries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Types_TypeId",
                table: "Movies",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_PublisherCountries_CountryId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Types_TypeId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CountryId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9c42a9c-d52b-4c0c-9656-a661211b6ff2", "21b54ce2-ab7c-4458-b43e-1b4dd4acff53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "446a5531-d3c4-4607-94f9-ae4271529f70", "6b155db3-30f2-491a-a133-95e10729df23" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "446a5531-d3c4-4607-94f9-ae4271529f70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9c42a9c-d52b-4c0c-9656-a661211b6ff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21b54ce2-ab7c-4458-b43e-1b4dd4acff53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b155db3-30f2-491a-a133-95e10729df23");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Movies",
                newName: "PublisherCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_TypeId",
                table: "Movies",
                newName: "IX_Movies_PublisherCountryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_PublisherCountries_PublisherCountryId",
                table: "Movies",
                column: "PublisherCountryId",
                principalTable: "PublisherCountries",
                principalColumn: "Id");
        }
    }
}
