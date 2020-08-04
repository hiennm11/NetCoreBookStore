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
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    CustomerPhoneNumber = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
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
                values: new object[] { new Guid("d57d5a15-38a7-41f1-b834-9ac9d25a6d1a"), "2fbc4f9f-6c47-4d64-be9a-273c4e12aa5a", "Admin role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("d57d5a15-38a7-41f1-b834-9ac9d25a6d1a"), new Guid("d57d5a15-38a7-41f1-b834-9ac9d25a6d1a") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d57d5a15-38a7-41f1-b834-9ac9d25a6d1a"), 0, "6ac18923-972a-4fcb-a84b-55882c3fd936", new DateTime(2020, 8, 4, 9, 32, 55, 856, DateTimeKind.Local).AddTicks(285), "app-admin@abc.xyz", true, "Admin", "Admin", false, null, "app-admin@abc.xyz", "admin", "AQAAAAEAACcQAAAAEMTfFbwk+ZrXh2kE4PHV9o0nyMbBLW7nLkFNwS42lHktLg5VmFeTpNuKfgnhG3yNag==", "0985123745", false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[,]
                {
                    { "366edef8-a08b-474f-9d8e-0136b409d0c6", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(5132), "<p>Book 89 is simply dummy text of the printing and typesetting industry. Book 89 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 89 has been the book. </p><p>Book 89's Description here  </p>", null, 2020, "book-89", 46.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(5134), 1, "Book 89" },
                    { "c1b3a3a8-5cfd-4d58-bb65-fa046de6ba8d", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(5089), "<p>Book 85 is simply dummy text of the printing and typesetting industry. Book 85 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 85 has been the book. </p><p>Book 85's Description here  </p>", null, 2020, "book-85", 48.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(5090), 1, "Book 85" },
                    { "5b31c3e2-7d50-4da1-9bbc-973ed735b814", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(5045), "<p>Book 81 is simply dummy text of the printing and typesetting industry. Book 81 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 81 has been the book. </p><p>Book 81's Description here  </p>", null, 2020, "book-81", 49.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(5046), 1, "Book 81" },
                    { "7c59ec68-05fd-401d-be98-d32de44f8060", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4954), "<p>Book 77 is simply dummy text of the printing and typesetting industry. Book 77 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 77 has been the book. </p><p>Book 77's Description here  </p>", null, 2020, "book-77", 39.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4956), 1, "Book 77" },
                    { "7756e85e-2db5-4873-aff1-a0219598f7da", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4916), "<p>Book 73 is simply dummy text of the printing and typesetting industry. Book 73 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 73 has been the book. </p><p>Book 73's Description here  </p>", null, 2020, "book-73", 49.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4917), 1, "Book 73" },
                    { "69c7a1f8-528d-473f-a17f-f77c52ee5599", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4874), "<p>Book 69 is simply dummy text of the printing and typesetting industry. Book 69 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 69 has been the book. </p><p>Book 69's Description here  </p>", null, 2020, "book-69", 52.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4875), 1, "Book 69" },
                    { "279353e2-537e-4270-93e8-9e7dbd3cac01", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4832), "<p>Book 65 is simply dummy text of the printing and typesetting industry. Book 65 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 65 has been the book. </p><p>Book 65's Description here  </p>", null, 2020, "book-65", 47.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4833), 1, "Book 65" },
                    { "c29c34e8-43ef-4ca4-8df3-39329d3fd6ae", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4729), "<p>Book 61 is simply dummy text of the printing and typesetting industry. Book 61 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 61 has been the book. </p><p>Book 61's Description here  </p>", null, 2020, "book-61", 47.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4731), 1, "Book 61" },
                    { "03c1b820-6a10-4581-9225-b34670b457e6", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4690), "<p>Book 57 is simply dummy text of the printing and typesetting industry. Book 57 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 57 has been the book. </p><p>Book 57's Description here  </p>", null, 2020, "book-57", 46.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4691), 1, "Book 57" },
                    { "abb2e9e0-18ba-49cd-b914-a6fb2527e923", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4648), "<p>Book 53 is simply dummy text of the printing and typesetting industry. Book 53 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 53 has been the book. </p><p>Book 53's Description here  </p>", null, 2020, "book-53", 39.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4650), 1, "Book 53" },
                    { "a2cb72af-b919-4489-939f-813aab6b997d", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4608), "<p>Book 49 is simply dummy text of the printing and typesetting industry. Book 49 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 49 has been the book. </p><p>Book 49's Description here  </p>", null, 2020, "book-49", 41.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4609), 1, "Book 49" },
                    { "cac93b25-95b7-4f1f-8544-df67b563220e", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4496), "<p>Book 41 is simply dummy text of the printing and typesetting industry. Book 41 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 41 has been the book. </p><p>Book 41's Description here  </p>", null, 2020, "book-41", 45.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4498), 1, "Book 41" },
                    { "0218d7f0-e96a-453c-a817-b23c0c69de06", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4454), "<p>Book 37 is simply dummy text of the printing and typesetting industry. Book 37 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 37 has been the book. </p><p>Book 37's Description here  </p>", null, 2020, "book-37", 49.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4456), 1, "Book 37" },
                    { "aa0cd836-05a5-4258-bcba-3726828b4a3e", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4413), "<p>Book 33 is simply dummy text of the printing and typesetting industry. Book 33 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 33 has been the book. </p><p>Book 33's Description here  </p>", null, 2020, "book-33", 56.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4414), 1, "Book 33" },
                    { "5f4b30be-e72d-41df-9499-de6d8643a6c8", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4337), "<p>Book 29 is simply dummy text of the printing and typesetting industry. Book 29 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 29 has been the book. </p><p>Book 29's Description here  </p>", null, 2020, "book-29", 48.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4339), 1, "Book 29" },
                    { "3f6a29a0-526c-4caf-bad1-33a16c9e855e", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4296), "<p>Book 25 is simply dummy text of the printing and typesetting industry. Book 25 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 25 has been the book. </p><p>Book 25's Description here  </p>", null, 2020, "book-25", 45.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4297), 1, "Book 25" },
                    { "064bcbf9-f4e5-4d58-b2d6-6a4ac90c1abc", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4251), "<p>Book 21 is simply dummy text of the printing and typesetting industry. Book 21 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 21 has been the book. </p><p>Book 21's Description here  </p>", null, 2020, "book-21", 50.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4253), 1, "Book 21" },
                    { "e2c5009e-e913-471e-b0db-0e405408235e", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4209), "<p>Book 17 is simply dummy text of the printing and typesetting industry. Book 17 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 17 has been the book. </p><p>Book 17's Description here  </p>", null, 2020, "book-17", 45.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4210), 1, "Book 17" },
                    { "09407254-23e9-4b6a-ad28-d6fa7c981d65", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4117), "<p>Book 13 is simply dummy text of the printing and typesetting industry. Book 13 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 13 has been the book. </p><p>Book 13's Description here  </p>", null, 2020, "book-13", 39.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4119), 1, "Book 13" },
                    { "3426af09-27ed-4e79-9788-50b9c7b7bb0b", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4066), "<p>Book 9 is simply dummy text of the printing and typesetting industry. Book 9 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 9 has been the book. </p><p>Book 9's Description here  </p>", null, 2020, "book-9", 39.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4069), 1, "Book 9" },
                    { "717e475a-5e9f-4f2d-b9c6-55e3f595d75c", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(3834), "<p>Book 5 is simply dummy text of the printing and typesetting industry. Book 5 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 5 has been the book. </p><p>Book 5's Description here  </p>", null, 2020, "book-5", 44.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(3869), 1, "Book 5" },
                    { "ffd4d9fa-7e93-4f6e-8750-f0a184ecf408", 100, new DateTime(2020, 8, 4, 9, 32, 55, 843, DateTimeKind.Local).AddTicks(6361), "<p>Book 1 is simply dummy text of the printing and typesetting industry. Book 1 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 1 has been the book. </p><p>Book 1's Description here  </p>", null, 2020, "book-1", 42.0, new DateTime(2020, 8, 4, 9, 32, 55, 844, DateTimeKind.Local).AddTicks(4904), 1, "Book 1" },
                    { "73fd7b5f-5725-4998-91cf-48a7dc9fe7b7", 100, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4538), "<p>Book 45 is simply dummy text of the printing and typesetting industry. Book 45 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 45 has been the book. </p><p>Book 45's Description here  </p>", null, 2020, "book-45", 41.0, new DateTime(2020, 8, 4, 9, 32, 55, 845, DateTimeKind.Local).AddTicks(4539), 1, "Book 45" }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Code", "Name", "Value" },
                values: new object[,]
                {
                    { "73f7641a-231e-4e2d-9f6b-7100815363ee", null, "Default", 0 },
                    { "fa7462f3-33db-4a0e-999f-554500271d85", null, "Test", 10 }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "Description", "ImgPath", "Sort" },
                values: new object[,]
                {
                    { "8ef2787b-68ee-4435-97e0-d2edf9b88141", "ffd4d9fa-7e93-4f6e-8750-f0a184ecf408", "Book 1", "/MyStaticFiles/images/book-1.jpg", 1 },
                    { "feb83f10-20fd-4662-86a4-7cabd8126a7d", "a2cb72af-b919-4489-939f-813aab6b997d", "Book 49", "/MyStaticFiles/images/book-49.jpg", 1 },
                    { "f5bda504-4081-4a4b-84c6-807a4a49e722", "a2cb72af-b919-4489-939f-813aab6b997d", "Book 49", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "90bb8fdb-5f3d-4c22-b4ae-0ca8fb7218c5", "a2cb72af-b919-4489-939f-813aab6b997d", "Book 49", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "d2a865ca-a9bd-45ee-862e-6d6aeacca4a6", "abb2e9e0-18ba-49cd-b914-a6fb2527e923", "Book 53", "/MyStaticFiles/images/book-53.jpg", 1 },
                    { "77b1986d-40b7-4b57-99d9-def1dd30dcdc", "abb2e9e0-18ba-49cd-b914-a6fb2527e923", "Book 53", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "0b5c94ca-b05d-47cd-b4f0-4e59ac90fbf4", "abb2e9e0-18ba-49cd-b914-a6fb2527e923", "Book 53", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "1ecf5f1e-3cd2-4747-bad4-c54348c2134b", "03c1b820-6a10-4581-9225-b34670b457e6", "Book 57", "/MyStaticFiles/images/book-57.jpg", 1 },
                    { "8a334463-b68d-40ff-b57b-cd629f99bcdb", "03c1b820-6a10-4581-9225-b34670b457e6", "Book 57", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "e7f6132d-f35f-469a-b434-947320e4c89e", "03c1b820-6a10-4581-9225-b34670b457e6", "Book 57", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "dd859019-21cb-43de-84a4-c63f35622a6f", "c29c34e8-43ef-4ca4-8df3-39329d3fd6ae", "Book 61", "/MyStaticFiles/images/book-61.jpg", 1 },
                    { "ce27520f-95d3-41f3-abd2-e8e6720ffa32", "c29c34e8-43ef-4ca4-8df3-39329d3fd6ae", "Book 61", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "b6c5fb7f-2396-4526-8d46-1fbd6c662db2", "c29c34e8-43ef-4ca4-8df3-39329d3fd6ae", "Book 61", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "557fad04-64bd-40d9-a7c8-758fb64062b7", "279353e2-537e-4270-93e8-9e7dbd3cac01", "Book 65", "/MyStaticFiles/images/book-65.jpg", 1 },
                    { "6cb78115-3d8a-45a5-842b-c81a8361652b", "279353e2-537e-4270-93e8-9e7dbd3cac01", "Book 65", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "7045f170-fa73-4bf0-af6a-6dccc25d3c99", "279353e2-537e-4270-93e8-9e7dbd3cac01", "Book 65", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a78bf8b0-d60f-47fc-ab3f-c0dc0fbdaefd", "69c7a1f8-528d-473f-a17f-f77c52ee5599", "Book 69", "/MyStaticFiles/images/book-69.jpg", 1 },
                    { "caec7b87-f612-4d24-8344-81e52b304b22", "69c7a1f8-528d-473f-a17f-f77c52ee5599", "Book 69", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "f744486d-2ac4-4e7b-8604-08d2c5bd3c77", "366edef8-a08b-474f-9d8e-0136b409d0c6", "Book 89", "/MyStaticFiles/images/book-89.jpg", 1 },
                    { "390baec4-b1de-4d28-b207-008bb56bb31f", "c1b3a3a8-5cfd-4d58-bb65-fa046de6ba8d", "Book 85", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "703714d5-aad8-4e14-92e6-f92f5e47a7d6", "c1b3a3a8-5cfd-4d58-bb65-fa046de6ba8d", "Book 85", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "f031a0d9-5401-403b-9337-aba94be04002", "c1b3a3a8-5cfd-4d58-bb65-fa046de6ba8d", "Book 85", "/MyStaticFiles/images/book-85.jpg", 1 },
                    { "da079c1d-0c9c-4d86-96ea-14a3e6566adb", "5b31c3e2-7d50-4da1-9bbc-973ed735b814", "Book 81", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "fb654acb-37c5-4c90-a8b7-93b060552055", "5b31c3e2-7d50-4da1-9bbc-973ed735b814", "Book 81", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "8b5b6cd1-1194-4f35-aa64-e6d225ee79e4", "73fd7b5f-5725-4998-91cf-48a7dc9fe7b7", "Book 45", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "8f892936-7fbf-4fae-b265-79cde2d39a19", "5b31c3e2-7d50-4da1-9bbc-973ed735b814", "Book 81", "/MyStaticFiles/images/book-81.jpg", 1 },
                    { "8be28420-10d3-46fa-996b-27cfee42b929", "7c59ec68-05fd-401d-be98-d32de44f8060", "Book 77", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "c0fcf458-c07b-48ce-98e8-b223fb48faf2", "7c59ec68-05fd-401d-be98-d32de44f8060", "Book 77", "/MyStaticFiles/images/book-77.jpg", 1 },
                    { "dbd2735e-b561-4878-9a19-d859ff5ab82f", "7756e85e-2db5-4873-aff1-a0219598f7da", "Book 73", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "63512fae-d3ca-4c74-87ea-0651ba3aa2c4", "7756e85e-2db5-4873-aff1-a0219598f7da", "Book 73", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "d8315bd1-c3d5-4b18-bce4-8067652d8dec", "7756e85e-2db5-4873-aff1-a0219598f7da", "Book 73", "/MyStaticFiles/images/book-73.jpg", 1 },
                    { "14aa3afd-fef1-4871-bc19-d31017f7a609", "69c7a1f8-528d-473f-a17f-f77c52ee5599", "Book 69", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "cebfc859-1e45-4ece-859d-767c299f6382", "7c59ec68-05fd-401d-be98-d32de44f8060", "Book 77", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "24543996-284a-4709-98df-5c6bff763f14", "366edef8-a08b-474f-9d8e-0136b409d0c6", "Book 89", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "2b1c3f2f-380a-4d73-a334-c6ea1e30c0ea", "73fd7b5f-5725-4998-91cf-48a7dc9fe7b7", "Book 45", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "2f1d91ad-90c7-4df8-9a56-d7100e3938f6", "cac93b25-95b7-4f1f-8544-df67b563220e", "Book 41", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "4726229c-c246-4f64-9825-fcc710363562", "ffd4d9fa-7e93-4f6e-8750-f0a184ecf408", "Book 1", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "fbd15345-4dc5-41a0-a37e-5eec74c956f8", "ffd4d9fa-7e93-4f6e-8750-f0a184ecf408", "Book 1", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "886440b6-aff7-4bfd-b72e-cc301a2a7ecb", "717e475a-5e9f-4f2d-b9c6-55e3f595d75c", "Book 5", "/MyStaticFiles/images/book-5.jpg", 1 },
                    { "aeb8abbe-08b7-4294-9d18-ef5eab36a045", "717e475a-5e9f-4f2d-b9c6-55e3f595d75c", "Book 5", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "0ece1810-2850-4ded-ba9c-bd838def4c06", "717e475a-5e9f-4f2d-b9c6-55e3f595d75c", "Book 5", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "4774f800-20ed-4591-9bdc-a799c4f29373", "3426af09-27ed-4e79-9788-50b9c7b7bb0b", "Book 9", "/MyStaticFiles/images/book-9.jpg", 1 },
                    { "785f3ccc-c245-48e0-b52a-5937bba95e3a", "3426af09-27ed-4e79-9788-50b9c7b7bb0b", "Book 9", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "95eaf031-ea47-43be-9c8b-f06159175fed", "3426af09-27ed-4e79-9788-50b9c7b7bb0b", "Book 9", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "c733d15f-604b-494b-9be1-eeabac517d65", "09407254-23e9-4b6a-ad28-d6fa7c981d65", "Book 13", "/MyStaticFiles/images/book-13.jpg", 1 },
                    { "8b37740a-93e7-4a31-9d37-2ceeed4af370", "09407254-23e9-4b6a-ad28-d6fa7c981d65", "Book 13", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "383d56b7-3631-47b1-a8ec-9172098146b2", "09407254-23e9-4b6a-ad28-d6fa7c981d65", "Book 13", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "eab4130d-0854-4c4d-a944-5f3fe834dd7e", "e2c5009e-e913-471e-b0db-0e405408235e", "Book 17", "/MyStaticFiles/images/book-17.jpg", 1 },
                    { "e5eeeb86-63e8-4e53-99ca-e99424a4e847", "e2c5009e-e913-471e-b0db-0e405408235e", "Book 17", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "e9341875-6a09-4eb2-a483-b336b6762c5f", "e2c5009e-e913-471e-b0db-0e405408235e", "Book 17", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a8b4d2d7-fafe-47cc-8e75-83e9304be7bb", "064bcbf9-f4e5-4d58-b2d6-6a4ac90c1abc", "Book 21", "/MyStaticFiles/images/book-21.jpg", 1 },
                    { "7652c35f-e440-4717-9485-d08116b50f7d", "064bcbf9-f4e5-4d58-b2d6-6a4ac90c1abc", "Book 21", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "d12aa015-318a-4ad8-949a-f3e5964f6847", "064bcbf9-f4e5-4d58-b2d6-6a4ac90c1abc", "Book 21", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "8568ca2b-35c7-461d-a22d-628b20d8ea8e", "cac93b25-95b7-4f1f-8544-df67b563220e", "Book 41", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "d7f8282d-2cb1-4649-9720-0f0a1f7cc2a9", "cac93b25-95b7-4f1f-8544-df67b563220e", "Book 41", "/MyStaticFiles/images/book-41.jpg", 1 },
                    { "4b32c7dc-b18e-4f5f-8ed5-560375114da4", "0218d7f0-e96a-453c-a817-b23c0c69de06", "Book 37", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "e9f7600e-7d19-49e7-8ac0-759693ed3898", "0218d7f0-e96a-453c-a817-b23c0c69de06", "Book 37", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "08fd2102-2aa7-465f-94c5-89c596fca30a", "0218d7f0-e96a-453c-a817-b23c0c69de06", "Book 37", "/MyStaticFiles/images/book-37.jpg", 1 },
                    { "8855d54b-b6b8-497c-bcc4-12009918bd63", "aa0cd836-05a5-4258-bcba-3726828b4a3e", "Book 33", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "2cab7192-2135-40d0-97aa-b1acc6f286c5", "73fd7b5f-5725-4998-91cf-48a7dc9fe7b7", "Book 45", "/MyStaticFiles/images/book-45.jpg", 1 },
                    { "59ccbd16-b793-4b25-a86e-049449fbc57c", "aa0cd836-05a5-4258-bcba-3726828b4a3e", "Book 33", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "4657832b-b213-4ab0-bdcc-78cd27731438", "5f4b30be-e72d-41df-9499-de6d8643a6c8", "Book 29", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "db762a5f-6714-4331-961f-6fb647f75cb9", "5f4b30be-e72d-41df-9499-de6d8643a6c8", "Book 29", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "3e443101-e583-408a-adf9-f3b6c54be9ef", "5f4b30be-e72d-41df-9499-de6d8643a6c8", "Book 29", "/MyStaticFiles/images/book-29.jpg", 1 },
                    { "0a934eba-a4bd-4fea-a57a-57baebbb63d2", "3f6a29a0-526c-4caf-bad1-33a16c9e855e", "Book 25", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "876608dd-ca73-41b0-840a-1b9c35769e27", "3f6a29a0-526c-4caf-bad1-33a16c9e855e", "Book 25", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "4a5cf3f7-117c-45bf-a8e7-ed611eaca215", "3f6a29a0-526c-4caf-bad1-33a16c9e855e", "Book 25", "/MyStaticFiles/images/book-25.jpg", 1 },
                    { "02da123b-5e3f-4f15-b103-8fb54762a527", "aa0cd836-05a5-4258-bcba-3726828b4a3e", "Book 33", "/MyStaticFiles/images/book-33.jpg", 1 },
                    { "66fe2066-dedc-499d-8779-88dcc9bfba17", "366edef8-a08b-474f-9d8e-0136b409d0c6", "Book 89", "/MyStaticFiles/images/product3.jpg", 3 }
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
