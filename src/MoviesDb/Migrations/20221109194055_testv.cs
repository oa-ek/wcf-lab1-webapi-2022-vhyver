using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class testv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.MoviesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MovieUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d598dc8-951c-408f-a84f-e58f47ab2056", "5666eb51-3524-4fa9-8115-9409700fad6d", "User", "USER" },
                    { "a784d59d-35ba-488c-b4ee-eba0fd6e0581", "a84fd06b-296b-4166-8660-7ad7cf302fca", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3202f8cc-130e-4193-9a0d-943a0ff7656a", 0, "cb4eab94-d89f-4900-896b-a8ee427d2846", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEARnXSmWDvPj/5s1x8cj5VuxcjdJcy73Bhs72TNf5EG0XmuEQbZsqfQcvOaECjHFsw==", null, false, "68a636e3-7501-4979-8c23-cb9b0c14d9aa", false, "admin@gmail.com" },
                    { "edbc0e74-45e0-40fa-a272-d8be2c5a2498", 0, "db32535a-d0fc-43df-8179-77ca248be158", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEBzYONKNZIDabcffuJ+RUEPBLc78QjRPGicQYbGSF+lq29dIIFjlrOrJ5dWPCn/zfg==", null, false, "c5acf975-6a35-4e64-acfc-4a408e6a5933", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a784d59d-35ba-488c-b4ee-eba0fd6e0581", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "edbc0e74-45e0-40fa-a272-d8be2c5a2498" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UsersId",
                table: "MovieUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a784d59d-35ba-488c-b4ee-eba0fd6e0581", "3202f8cc-130e-4193-9a0d-943a0ff7656a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d598dc8-951c-408f-a84f-e58f47ab2056", "edbc0e74-45e0-40fa-a272-d8be2c5a2498" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d598dc8-951c-408f-a84f-e58f47ab2056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a784d59d-35ba-488c-b4ee-eba0fd6e0581");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3202f8cc-130e-4193-9a0d-943a0ff7656a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edbc0e74-45e0-40fa-a272-d8be2c5a2498");

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
        }
    }
}
