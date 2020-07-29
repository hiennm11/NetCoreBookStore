using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreBookStore.Data.Migrations
{
    public partial class IdentityCore_Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87c57125-ac91-463b-ab72-433a35f127fd"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Orders",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[] { new Guid("5ef2e180-48b6-477d-95cf-705b1ffd30eb"), 100, new DateTime(2020, 7, 29, 7, 56, 24, 771, DateTimeKind.Local).AddTicks(5186), "Seeded book", null, 2020, "book-01", 33000.0, new DateTime(2020, 7, 29, 7, 56, 24, 772, DateTimeKind.Local).AddTicks(7385), 1, "Book 01" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5ef2e180-48b6-477d-95cf-705b1ffd30eb"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[] { new Guid("87c57125-ac91-463b-ab72-433a35f127fd"), 100, new DateTime(2020, 7, 29, 7, 39, 33, 730, DateTimeKind.Local).AddTicks(4231), "Seeded book", null, 2020, "book-01", 33000.0, new DateTime(2020, 7, 29, 7, 39, 33, 731, DateTimeKind.Local).AddTicks(3215), 1, "Book 01" });
        }
    }
}
