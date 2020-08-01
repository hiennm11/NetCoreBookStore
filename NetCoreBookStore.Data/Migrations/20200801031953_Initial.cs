using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreBookStore.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    PublicationDate = table.Column<DateTime>(nullable: false),
                    Edition = table.Column<int>(nullable: false),
                    AvailableQuantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false, defaultValue: 0.0),
                    NameAlias = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DiscountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DiscountId = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    OrderTotal = table.Column<double>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookImages",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BookId = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookImages_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    BookId = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.BookId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("b132c356-3cf7-4264-a049-73fb409b83f6"), "2ae44942-3995-47a8-ac9f-e721a0930d8e", "Admin role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("b132c356-3cf7-4264-a049-73fb409b83f6"), new Guid("b132c356-3cf7-4264-a049-73fb409b83f6") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b132c356-3cf7-4264-a049-73fb409b83f6"), 0, "f8d7d222-f539-476a-95fd-b6ab950a398b", new DateTime(2020, 8, 1, 10, 19, 52, 904, DateTimeKind.Local).AddTicks(8864), "app-admin@abc.xyz", true, "Admin", "Admin", false, null, "app-admin@abc.xyz", "admin", "AQAAAAEAACcQAAAAEHG4M3QfM5UNqdnx4AX9KBKjM/mjYg2+POtuCwxPuGZAd+5aEXWHm3YCBCVDJNnMVA==", "0985123745", false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[,]
                {
                    { "665c42b0-cab8-4a6d-aa40-ee129e5648d7", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2408), "<p>Book 89 is simply dummy text of the printing and typesetting industry. Book 89 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 89 has been the book. </p><p>Book 89's Description here  </p>", null, 2020, "book-89", 51.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2410), 1, "Book 89" },
                    { "dc2726ed-54fb-4325-809e-0e9337dbedda", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2308), "<p>Book 85 is simply dummy text of the printing and typesetting industry. Book 85 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 85 has been the book. </p><p>Book 85's Description here  </p>", null, 2020, "book-85", 52.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2309), 1, "Book 85" },
                    { "4d822ec7-4778-42eb-a57a-7744bce1c4c2", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2265), "<p>Book 81 is simply dummy text of the printing and typesetting industry. Book 81 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 81 has been the book. </p><p>Book 81's Description here  </p>", null, 2020, "book-81", 56.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2266), 1, "Book 81" },
                    { "a52af41f-d5aa-49f2-8a17-588e55cb63d2", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2207), "<p>Book 77 is simply dummy text of the printing and typesetting industry. Book 77 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 77 has been the book. </p><p>Book 77's Description here  </p>", null, 2020, "book-77", 56.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2208), 1, "Book 77" },
                    { "74b4e779-4568-4ce7-89cd-910d538de1de", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2110), "<p>Book 73 is simply dummy text of the printing and typesetting industry. Book 73 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 73 has been the book. </p><p>Book 73's Description here  </p>", null, 2020, "book-73", 56.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2112), 1, "Book 73" },
                    { "421cc82f-ab9e-4279-8b66-a584dd7c5a17", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2068), "<p>Book 69 is simply dummy text of the printing and typesetting industry. Book 69 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 69 has been the book. </p><p>Book 69's Description here  </p>", null, 2020, "book-69", 53.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2070), 1, "Book 69" },
                    { "78e16958-4aef-4420-b1bf-9be01ae5ae1c", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2028), "<p>Book 65 is simply dummy text of the printing and typesetting industry. Book 65 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 65 has been the book. </p><p>Book 65's Description here  </p>", null, 2020, "book-65", 56.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(2030), 1, "Book 65" },
                    { "da470b9d-ed8a-4833-b42b-e7550f4d0370", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1985), "<p>Book 61 is simply dummy text of the printing and typesetting industry. Book 61 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 61 has been the book. </p><p>Book 61's Description here  </p>", null, 2020, "book-61", 53.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1986), 1, "Book 61" },
                    { "db27d1c5-aefb-4b36-9ac9-6d2d44ffa694", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1943), "<p>Book 57 is simply dummy text of the printing and typesetting industry. Book 57 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 57 has been the book. </p><p>Book 57's Description here  </p>", null, 2020, "book-57", 51.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1944), 1, "Book 57" },
                    { "44e65d3f-7b59-4c75-999b-ff090b00af0d", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1875), "<p>Book 53 is simply dummy text of the printing and typesetting industry. Book 53 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 53 has been the book. </p><p>Book 53's Description here  </p>", null, 2020, "book-53", 51.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1876), 1, "Book 53" },
                    { "91ca8d0c-c0bc-431a-ace8-0931cbac0586", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1836), "<p>Book 49 is simply dummy text of the printing and typesetting industry. Book 49 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 49 has been the book. </p><p>Book 49's Description here  </p>", null, 2020, "book-49", 41.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1837), 1, "Book 49" },
                    { "1d0d3674-0ef1-439c-b056-a9aa16323218", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1749), "<p>Book 41 is simply dummy text of the printing and typesetting industry. Book 41 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 41 has been the book. </p><p>Book 41's Description here  </p>", null, 2020, "book-41", 56.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1751), 1, "Book 41" },
                    { "fc23afbf-a380-4fc4-b7f2-fdb0838ff8cb", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1678), "<p>Book 37 is simply dummy text of the printing and typesetting industry. Book 37 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 37 has been the book. </p><p>Book 37's Description here  </p>", null, 2020, "book-37", 47.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1679), 1, "Book 37" },
                    { "23a03cb1-bbe0-439e-b3ad-8a32b9629b90", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1635), "<p>Book 33 is simply dummy text of the printing and typesetting industry. Book 33 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 33 has been the book. </p><p>Book 33's Description here  </p>", null, 2020, "book-33", 45.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1636), 1, "Book 33" },
                    { "d8e689f3-6d5e-4e3e-aae9-96c75242bf79", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1592), "<p>Book 29 is simply dummy text of the printing and typesetting industry. Book 29 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 29 has been the book. </p><p>Book 29's Description here  </p>", null, 2020, "book-29", 52.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1593), 1, "Book 29" },
                    { "b3af735c-3d10-4c6e-a384-0727c0e42d81", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1548), "<p>Book 25 is simply dummy text of the printing and typesetting industry. Book 25 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 25 has been the book. </p><p>Book 25's Description here  </p>", null, 2020, "book-25", 43.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1549), 1, "Book 25" },
                    { "fb10958e-e137-49d5-83ca-fceb33d618aa", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1475), "<p>Book 21 is simply dummy text of the printing and typesetting industry. Book 21 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 21 has been the book. </p><p>Book 21's Description here  </p>", null, 2020, "book-21", 44.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1476), 1, "Book 21" },
                    { "6e8f0d97-2e30-4e35-b502-924e32443a92", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1431), "<p>Book 17 is simply dummy text of the printing and typesetting industry. Book 17 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 17 has been the book. </p><p>Book 17's Description here  </p>", null, 2020, "book-17", 51.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1432), 1, "Book 17" },
                    { "16a64741-1a60-4869-b82e-63d01bd6bca4", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1384), "<p>Book 13 is simply dummy text of the printing and typesetting industry. Book 13 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 13 has been the book. </p><p>Book 13's Description here  </p>", null, 2020, "book-13", 44.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1386), 1, "Book 13" },
                    { "41246deb-a426-405a-932c-e8584cebef4a", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1328), "<p>Book 9 is simply dummy text of the printing and typesetting industry. Book 9 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 9 has been the book. </p><p>Book 9's Description here  </p>", null, 2020, "book-9", 37.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1331), 1, "Book 9" },
                    { "897d3b35-2fdc-413b-a7d2-69a9f0d5ccda", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1018), "<p>Book 5 is simply dummy text of the printing and typesetting industry. Book 5 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 5 has been the book. </p><p>Book 5's Description here  </p>", null, 2020, "book-5", 49.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1034), 1, "Book 5" },
                    { "15dde85c-1320-404e-9f73-5e8e93d09a01", 100, new DateTime(2020, 8, 1, 10, 19, 52, 891, DateTimeKind.Local).AddTicks(910), "<p>Book 1 is simply dummy text of the printing and typesetting industry. Book 1 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 1 has been the book. </p><p>Book 1's Description here  </p>", null, 2020, "book-1", 44.0, new DateTime(2020, 8, 1, 10, 19, 52, 892, DateTimeKind.Local).AddTicks(1258), 1, "Book 1" },
                    { "73e4f44b-ac8c-4463-86e0-9bb1bf4e0f6e", 100, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1794), "<p>Book 45 is simply dummy text of the printing and typesetting industry. Book 45 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 45 has been the book. </p><p>Book 45's Description here  </p>", null, 2020, "book-45", 54.0, new DateTime(2020, 8, 1, 10, 19, 52, 893, DateTimeKind.Local).AddTicks(1795), 1, "Book 45" }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Code", "Name", "Value" },
                values: new object[,]
                {
                    { "9e30eeeb-39e2-4be6-a2ca-9525484f8f58", null, "Default", 0 },
                    { "24c5fc91-c7f9-4241-aa59-430defe3af81", null, "Test", 10 }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "Description", "ImgPath", "Sort" },
                values: new object[,]
                {
                    { "d52c381e-71d4-4b92-9ae8-ad26ac9cb6a7", "15dde85c-1320-404e-9f73-5e8e93d09a01", "Book 1", "/MyStaticFiles/images/book-1.jpg", 1 },
                    { "bb33a74d-61e5-499d-acbe-db3c11eb6500", "91ca8d0c-c0bc-431a-ace8-0931cbac0586", "Book 49", "/MyStaticFiles/images/book-49.jpg", 1 },
                    { "b54fb8cd-62d8-469b-ba7e-7bcedd42fb75", "91ca8d0c-c0bc-431a-ace8-0931cbac0586", "Book 49", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "db8e5a51-f422-4138-812d-63a028403fe8", "91ca8d0c-c0bc-431a-ace8-0931cbac0586", "Book 49", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a9aeb948-8123-4d22-afd3-e529f571f918", "44e65d3f-7b59-4c75-999b-ff090b00af0d", "Book 53", "/MyStaticFiles/images/book-53.jpg", 1 },
                    { "7f6d5e46-50f1-4fbf-ac45-d80374f6dc96", "44e65d3f-7b59-4c75-999b-ff090b00af0d", "Book 53", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "5a8393de-c616-4256-91bd-5f35145c0365", "44e65d3f-7b59-4c75-999b-ff090b00af0d", "Book 53", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "7f708594-0e1e-4f5a-b440-8b7cb3fddd90", "db27d1c5-aefb-4b36-9ac9-6d2d44ffa694", "Book 57", "/MyStaticFiles/images/book-57.jpg", 1 },
                    { "c53de695-7afd-4776-931e-19567d283039", "db27d1c5-aefb-4b36-9ac9-6d2d44ffa694", "Book 57", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "4cce2cb6-9b22-47d3-a1ee-b29306dd01e7", "db27d1c5-aefb-4b36-9ac9-6d2d44ffa694", "Book 57", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "eab44d13-77b8-42b8-a42a-090cbfcf1e67", "da470b9d-ed8a-4833-b42b-e7550f4d0370", "Book 61", "/MyStaticFiles/images/book-61.jpg", 1 },
                    { "4a346761-fb16-4a15-a12d-87ee43e209d0", "da470b9d-ed8a-4833-b42b-e7550f4d0370", "Book 61", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "a57c2001-89fc-46d3-bb41-789c1e2fb8b3", "da470b9d-ed8a-4833-b42b-e7550f4d0370", "Book 61", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a0f6cebc-e78d-499a-bef9-4872333166d6", "78e16958-4aef-4420-b1bf-9be01ae5ae1c", "Book 65", "/MyStaticFiles/images/book-65.jpg", 1 },
                    { "33d45fa8-9028-4efd-9727-4ebd950e327f", "78e16958-4aef-4420-b1bf-9be01ae5ae1c", "Book 65", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "906bfbee-d0ec-49cd-9797-bd582c03331a", "78e16958-4aef-4420-b1bf-9be01ae5ae1c", "Book 65", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "2c6c6696-4c3e-407b-8c06-d249520a90e4", "421cc82f-ab9e-4279-8b66-a584dd7c5a17", "Book 69", "/MyStaticFiles/images/book-69.jpg", 1 },
                    { "0ee1fda6-a9c7-42b8-975f-39071a2aa559", "421cc82f-ab9e-4279-8b66-a584dd7c5a17", "Book 69", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "2b428d84-353c-470b-9250-5372fdafb169", "665c42b0-cab8-4a6d-aa40-ee129e5648d7", "Book 89", "/MyStaticFiles/images/book-89.jpg", 1 },
                    { "8d1fb515-908e-4b22-b91f-dffa213133aa", "dc2726ed-54fb-4325-809e-0e9337dbedda", "Book 85", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "9c9391f7-4fc2-4d19-b5e7-4c6c9b4aba94", "dc2726ed-54fb-4325-809e-0e9337dbedda", "Book 85", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "b5dd78b6-3459-40fd-bbc7-f5e33902832c", "dc2726ed-54fb-4325-809e-0e9337dbedda", "Book 85", "/MyStaticFiles/images/book-85.jpg", 1 },
                    { "af9a8569-8c25-4a83-8ec2-0d997293144e", "4d822ec7-4778-42eb-a57a-7744bce1c4c2", "Book 81", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "5b85c5f9-845e-43e6-abd7-9216e7febdeb", "4d822ec7-4778-42eb-a57a-7744bce1c4c2", "Book 81", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "a5da2497-748e-4665-9273-18caea6ed452", "73e4f44b-ac8c-4463-86e0-9bb1bf4e0f6e", "Book 45", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "c2cd9f23-0dc6-4e72-ac58-c9c1cfafccb8", "4d822ec7-4778-42eb-a57a-7744bce1c4c2", "Book 81", "/MyStaticFiles/images/book-81.jpg", 1 },
                    { "9429a39f-a09f-4553-9b06-ead931e997af", "a52af41f-d5aa-49f2-8a17-588e55cb63d2", "Book 77", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "df5a124d-bb31-45d8-929b-108852884a49", "a52af41f-d5aa-49f2-8a17-588e55cb63d2", "Book 77", "/MyStaticFiles/images/book-77.jpg", 1 },
                    { "93d69ae5-9943-45ca-8ce9-453c5d1d3da3", "74b4e779-4568-4ce7-89cd-910d538de1de", "Book 73", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "c5231ef6-f271-4d05-a126-d23fadaf9a45", "74b4e779-4568-4ce7-89cd-910d538de1de", "Book 73", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "5018922c-063f-42cb-839a-fe9d5313e0df", "74b4e779-4568-4ce7-89cd-910d538de1de", "Book 73", "/MyStaticFiles/images/book-73.jpg", 1 },
                    { "ec5c3a91-1e66-41bf-a94a-af4f56e96d3a", "421cc82f-ab9e-4279-8b66-a584dd7c5a17", "Book 69", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "af26c9d6-e259-4bc4-9215-410be0970fa4", "a52af41f-d5aa-49f2-8a17-588e55cb63d2", "Book 77", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "680a9610-7648-4f28-88cb-ef33f1a5099d", "665c42b0-cab8-4a6d-aa40-ee129e5648d7", "Book 89", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "e95a4538-3120-49c0-95cc-977d57f914fd", "73e4f44b-ac8c-4463-86e0-9bb1bf4e0f6e", "Book 45", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "e3787bd2-9a92-4153-a235-18c279e20e14", "1d0d3674-0ef1-439c-b056-a9aa16323218", "Book 41", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "dff0b5cb-fcca-4826-9ad8-532efdff9ee2", "15dde85c-1320-404e-9f73-5e8e93d09a01", "Book 1", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "00c74f77-6f6e-43d2-b25d-00e8ddc90ba7", "15dde85c-1320-404e-9f73-5e8e93d09a01", "Book 1", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "b1953e14-141f-4044-aa84-83b3deb536c5", "897d3b35-2fdc-413b-a7d2-69a9f0d5ccda", "Book 5", "/MyStaticFiles/images/book-5.jpg", 1 },
                    { "11161700-4bff-4756-878d-40f9d89cb14c", "897d3b35-2fdc-413b-a7d2-69a9f0d5ccda", "Book 5", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "fca98d0b-5005-42c3-968a-4d3d79c847a3", "897d3b35-2fdc-413b-a7d2-69a9f0d5ccda", "Book 5", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "972d5f5d-9c03-4eb6-bf28-31c291a7c129", "41246deb-a426-405a-932c-e8584cebef4a", "Book 9", "/MyStaticFiles/images/book-9.jpg", 1 },
                    { "ac8fa01f-d900-4866-b892-8ab35b3f6f51", "41246deb-a426-405a-932c-e8584cebef4a", "Book 9", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "75533d75-9275-4e4a-afc0-2ffc6116e5b2", "41246deb-a426-405a-932c-e8584cebef4a", "Book 9", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "c6f52b55-7f28-43b9-bc78-8b69174affe5", "16a64741-1a60-4869-b82e-63d01bd6bca4", "Book 13", "/MyStaticFiles/images/book-13.jpg", 1 },
                    { "df44d4a5-902a-4caf-a921-fdee82d266d5", "16a64741-1a60-4869-b82e-63d01bd6bca4", "Book 13", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "a8fe4853-2cf4-407f-9f80-88a8c48e2427", "16a64741-1a60-4869-b82e-63d01bd6bca4", "Book 13", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "b00e733b-1d8f-49f5-ad52-ae7ed2eaaa3a", "6e8f0d97-2e30-4e35-b502-924e32443a92", "Book 17", "/MyStaticFiles/images/book-17.jpg", 1 },
                    { "cd67f7db-054f-4177-9e11-40e5bc227724", "6e8f0d97-2e30-4e35-b502-924e32443a92", "Book 17", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "e59ee496-98cc-460d-9aef-f0c6be975197", "6e8f0d97-2e30-4e35-b502-924e32443a92", "Book 17", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "dd021c84-922e-4471-98f1-1ce34114bbe3", "fb10958e-e137-49d5-83ca-fceb33d618aa", "Book 21", "/MyStaticFiles/images/book-21.jpg", 1 },
                    { "c6159448-d249-4e21-b53c-47ad59f0da0f", "fb10958e-e137-49d5-83ca-fceb33d618aa", "Book 21", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "c509b1e5-4bb6-4fad-8d05-cd2c0dd325a5", "fb10958e-e137-49d5-83ca-fceb33d618aa", "Book 21", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "acc3a647-de93-4dc6-a9fb-34959ced098f", "1d0d3674-0ef1-439c-b056-a9aa16323218", "Book 41", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "cc7818bc-2a48-4c96-9645-d5410031dbda", "1d0d3674-0ef1-439c-b056-a9aa16323218", "Book 41", "/MyStaticFiles/images/book-41.jpg", 1 },
                    { "9e7566ee-bc32-4f40-9e09-c65c1a80bb59", "fc23afbf-a380-4fc4-b7f2-fdb0838ff8cb", "Book 37", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "3faf57fa-2c53-46cd-a72e-999b58c0a2cf", "fc23afbf-a380-4fc4-b7f2-fdb0838ff8cb", "Book 37", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "5452f8a3-95ad-4f5d-ac33-b2b5253676e9", "fc23afbf-a380-4fc4-b7f2-fdb0838ff8cb", "Book 37", "/MyStaticFiles/images/book-37.jpg", 1 },
                    { "17fc1915-0746-44a9-8424-975c27a62212", "23a03cb1-bbe0-439e-b3ad-8a32b9629b90", "Book 33", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "872f6653-cdca-449f-84ee-bb5aa2860a66", "73e4f44b-ac8c-4463-86e0-9bb1bf4e0f6e", "Book 45", "/MyStaticFiles/images/book-45.jpg", 1 },
                    { "b5929100-82a3-4b87-93b3-f69a542a91c3", "23a03cb1-bbe0-439e-b3ad-8a32b9629b90", "Book 33", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "0a51877d-b9d1-4385-9bf2-6490e278e3bb", "d8e689f3-6d5e-4e3e-aae9-96c75242bf79", "Book 29", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "6b342709-f739-4e1a-98f5-87d23e05d55f", "d8e689f3-6d5e-4e3e-aae9-96c75242bf79", "Book 29", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "e274af1a-f30f-4259-884a-ef8cf223caf4", "d8e689f3-6d5e-4e3e-aae9-96c75242bf79", "Book 29", "/MyStaticFiles/images/book-29.jpg", 1 },
                    { "aee8399b-800c-437d-bd06-508f58139681", "b3af735c-3d10-4c6e-a384-0727c0e42d81", "Book 25", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "63f7f695-0249-45d8-a066-f739196ed775", "b3af735c-3d10-4c6e-a384-0727c0e42d81", "Book 25", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "8f47e025-29d2-480d-bf38-3dbf3dae535f", "b3af735c-3d10-4c6e-a384-0727c0e42d81", "Book 25", "/MyStaticFiles/images/book-25.jpg", 1 },
                    { "82c5531f-165e-4d96-a63d-46a7605a5e1f", "23a03cb1-bbe0-439e-b3ad-8a32b9629b90", "Book 33", "/MyStaticFiles/images/book-33.jpg", 1 },
                    { "5bf4eb66-3fff-4a21-b312-d29bf8619498", "665c42b0-cab8-4a6d-aa40-ee129e5648d7", "Book 89", "/MyStaticFiles/images/product3.jpg", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookImages_BookId",
                table: "BookImages",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_DiscountId",
                table: "Books",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BookId",
                table: "OrderDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiscountId",
                table: "Orders",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_BookId",
                table: "ShoppingCartItems",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "BookImages");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Discounts");
        }
    }
}
