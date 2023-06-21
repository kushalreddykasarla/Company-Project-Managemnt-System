using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class mssqlcontainer_migration_192 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f016cc4-f98b-4915-9f63-e0c1d8502629");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acde71e3-ff72-4519-93fa-e8e0ba16e052");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b31a22eb-5847-4906-9799-1dd22da2ad6a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26c050ba-a16a-42ad-a00b-0afb84660c97", null, "User", "USER" },
                    { "534cc853-d3ea-427f-8931-4c856081771d", null, "SubAdmin", "SUBADMIN" },
                    { "5b3be2fb-7666-41c4-af23-7f6ab581f775", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26c050ba-a16a-42ad-a00b-0afb84660c97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "534cc853-d3ea-427f-8931-4c856081771d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b3be2fb-7666-41c4-af23-7f6ab581f775");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f016cc4-f98b-4915-9f63-e0c1d8502629", null, "Admin", "ADMIN" },
                    { "acde71e3-ff72-4519-93fa-e8e0ba16e052", null, "User", "USER" },
                    { "b31a22eb-5847-4906-9799-1dd22da2ad6a", null, "SubAdmin", "SUBADMIN" }
                });
        }
    }
}
