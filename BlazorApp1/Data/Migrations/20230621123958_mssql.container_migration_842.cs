using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class mssqlcontainer_migration_842 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "41fdb937-95b8-4959-9773-dd2d121736b8", null, "Admin", "ADMIN" },
                    { "9e7804f2-438a-4d2e-8df8-1a3c008fd72b", null, "User", "USER" },
                    { "e73fd275-0757-49db-b3a9-ad5ca04cbac0", null, "SubAdmin", "SUBADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41fdb937-95b8-4959-9773-dd2d121736b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e7804f2-438a-4d2e-8df8-1a3c008fd72b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e73fd275-0757-49db-b3a9-ad5ca04cbac0");

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
    }
}
