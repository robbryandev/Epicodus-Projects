using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGramApp.Migrations
{
    public partial class ResetMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DbOrders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirmation_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cost = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbOrders", x => x.order_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    like_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    picture_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.like_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    picture_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fileName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.picture_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:GalleryGramApp/Migrations/20230126194359_ResetMigrations.cs
                    { "4947bdd7-f278-4a59-af75-be8bac04c6f5", 0, "5881f98c-5d62-4965-816f-196853fd512d", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAENdGs0NuYQ3hL/w4NHD8vpan672hvJM5MrodVncnAx4wzx8LVbr+exYoy3uPyLcybA==", null, false, "63668cf8-dcd0-4a57-ab44-4cadb6fbb1c3", false, "david@gmail.com" },
                    { "775b665d-b75a-40c5-9fd4-1c43e4e81fe4", 0, "4564d144-ba8d-463d-b2ee-96e6e81205cf", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEL2HuVNq4BRN8RQW8ZS1bCG16olIbVTPZn0RWAe1SUaqv8HN/Msibq100hOU1P/PMg==", null, false, "68fd7897-5504-40d1-9e86-a48efa559ae3", false, "lucas@gmail.com" },
                    { "ec793050-aa29-47ad-af21-bf87286fa27d", 0, "3a781fd2-bdcd-490f-951c-c39f7cd0cdfb", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAEPQ/Dm3d9/Qb9QECYs1NKb5u2wHokvw/D2uI92h0BL1qLKNiH5QDmgzzvz1h6PAR5w==", null, false, "06db2b9f-5901-4115-8a30-104e6f0cad64", false, "robert@gmail.com" }
========
                    { "2ccf0c85-7e64-49c5-8a7c-75ba8505bfc8", 0, "4c61cfea-bed8-4858-bbc4-7b00190683b6", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAEDBbhF7xN4S7yZ8+GJBIjWB3sxdwNmAOiMP07PV8vAtRUcSS3M6li3XavBb7neaAog==", null, false, "714237df-b0bc-4476-9bca-189be44094cc", false, "david@gmail.com" },
                    { "488207d6-11dc-4f2c-9d25-012a1f9932f5", 0, "305333cd-6b23-4c39-97f8-b0773d70eddb", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAEInCM9AEExJIORuZCBpicGldcSR1KjPLhudQ8Sqo5f+Cj7pypKn9jErKjq77OUG0FQ==", null, false, "be38895d-1719-4fe7-ba89-a52ca9f9fb67", false, "robert@gmail.com" },
                    { "d15d195a-5d77-4f4a-8860-5e89f04b6ee0", 0, "5ce53002-009a-4283-9a39-5cb8d1c4a0c7", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEFpERX5Hl76AVHlUjXRVwU/Y0RJonOisE7H1u1sdb67TY/1a+dXFXPddnHLyN2uJIA==", null, false, "d428232c-0b53-4fd7-8d51-f66081d1e9f2", false, "lucas@gmail.com" }
>>>>>>>> main:GalleryGramApp/Migrations/20230126160738_initial.cs
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "picture_id", "fileName", "user_id" },
                values: new object[,]
                {
<<<<<<<< HEAD:GalleryGramApp/Migrations/20230126194359_ResetMigrations.cs
                    { 1, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg", "4947bdd7-f278-4a59-af75-be8bac04c6f5" },
                    { 2, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg", "4947bdd7-f278-4a59-af75-be8bac04c6f5" },
                    { 3, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg", "4947bdd7-f278-4a59-af75-be8bac04c6f5" },
                    { 4, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg", "ec793050-aa29-47ad-af21-bf87286fa27d" },
                    { 5, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg", "ec793050-aa29-47ad-af21-bf87286fa27d" },
                    { 6, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg", "ec793050-aa29-47ad-af21-bf87286fa27d" },
                    { 7, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg", "775b665d-b75a-40c5-9fd4-1c43e4e81fe4" },
                    { 8, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg", "775b665d-b75a-40c5-9fd4-1c43e4e81fe4" },
                    { 9, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg", "775b665d-b75a-40c5-9fd4-1c43e4e81fe4" }
========
                    { 1, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg", "2ccf0c85-7e64-49c5-8a7c-75ba8505bfc8" },
                    { 2, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg", "2ccf0c85-7e64-49c5-8a7c-75ba8505bfc8" },
                    { 3, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg", "2ccf0c85-7e64-49c5-8a7c-75ba8505bfc8" },
                    { 4, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg", "488207d6-11dc-4f2c-9d25-012a1f9932f5" },
                    { 5, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg", "488207d6-11dc-4f2c-9d25-012a1f9932f5" },
                    { 6, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg", "488207d6-11dc-4f2c-9d25-012a1f9932f5" },
                    { 7, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg", "d15d195a-5d77-4f4a-8860-5e89f04b6ee0" },
                    { 8, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg", "d15d195a-5d77-4f4a-8860-5e89f04b6ee0" },
                    { 9, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg", "d15d195a-5d77-4f4a-8860-5e89f04b6ee0" }
>>>>>>>> main:GalleryGramApp/Migrations/20230126160738_initial.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DbOrders");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
