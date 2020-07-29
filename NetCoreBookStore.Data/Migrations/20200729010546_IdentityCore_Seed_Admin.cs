using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreBookStore.Data.Migrations
{
    public partial class IdentityCore_Seed_Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5ef2e180-48b6-477d-95cf-705b1ffd30eb"));

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80"), new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80") });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[] { new Guid("0e66c814-4970-45ff-9c78-b2b1fd9fa62e"), 100, new DateTime(2020, 7, 29, 8, 5, 45, 941, DateTimeKind.Local).AddTicks(6848), "Seeded book", null, 2020, "book-01", 33000.0, new DateTime(2020, 7, 29, 8, 5, 45, 942, DateTimeKind.Local).AddTicks(5486), 1, "Book 01" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80"), "6a9a7a39-888b-4d69-9fe1-97ad6a22997c", "Admin role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80"), 0, "d1137a8d-3f8d-4d32-8506-48becb9e0624", new DateTime(2020, 7, 29, 8, 5, 45, 954, DateTimeKind.Local).AddTicks(3561), "app-admin@abc.xyz", true, "Admin", "Admin", false, null, "app-admin@abc.xyz", "admin", "AQAAAAEAACcQAAAAEDoHcnK98lz/DV5K7KRnLzZr39FQfaEoebwOqJtGtQcQRhCRCUmTruTxvxDptubQpQ==", "0985123745", false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80"), new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80") });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e66c814-4970-45ff-9c78-b2b1fd9fa62e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70562d6e-61e8-4124-a6e7-eefa69b64c80"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[] { new Guid("5ef2e180-48b6-477d-95cf-705b1ffd30eb"), 100, new DateTime(2020, 7, 29, 7, 56, 24, 771, DateTimeKind.Local).AddTicks(5186), "Seeded book", null, 2020, "book-01", 33000.0, new DateTime(2020, 7, 29, 7, 56, 24, 772, DateTimeKind.Local).AddTicks(7385), 1, "Book 01" });
        }
    }
}
