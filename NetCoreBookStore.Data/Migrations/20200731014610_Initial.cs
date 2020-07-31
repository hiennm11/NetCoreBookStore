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
                values: new object[] { new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2"), "83c5927e-3b61-45d8-88aa-34cf8c6420cc", "Admin role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2"), new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2"), 0, "45fc088d-1ffc-4bd2-82d8-424cc9a51a6f", new DateTime(2020, 7, 31, 8, 46, 10, 79, DateTimeKind.Local).AddTicks(3810), "app-admin@abc.xyz", true, "Admin", "Admin", false, null, "app-admin@abc.xyz", "admin", "AQAAAAEAACcQAAAAEJ3ChWtoD1embU+yb5IvYuX+v6xhYt6C1n6coLiiHbn0VZOi+jVsP6gduf7DPY65zQ==", "0985123745", false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[,]
                {
                    { "1a3b9099-e755-4bb1-a7d9-1a0c580e768f", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4977), "Seeded book", null, 2020, "book-89", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4979), 1, "Book 89" },
                    { "f6fee8a9-4079-4279-87f0-020338d5539b", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4905), "Seeded book", null, 2020, "book-85", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4907), 1, "Book 85" },
                    { "76309a43-eace-4ce8-9597-9a9dfd954aef", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4794), "Seeded book", null, 2020, "book-81", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4797), 1, "Book 81" },
                    { "ff6ff11a-00d0-4c7f-aab1-8db92fd12a15", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4683), "Seeded book", null, 2020, "book-77", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4685), 1, "Book 77" },
                    { "60726fc9-b641-4a7a-aea4-26288ffaddc3", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4616), "Seeded book", null, 2020, "book-73", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4618), 1, "Book 73" },
                    { "602594bb-c561-4261-a6ee-477818418c27", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4547), "Seeded book", null, 2020, "book-69", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4548), 1, "Book 69" },
                    { "ebb5f6cc-af3d-4eec-bf18-0122427ca937", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4476), "Seeded book", null, 2020, "book-65", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4478), 1, "Book 65" },
                    { "ed828d55-9587-4ca5-98e7-8ca4070eac54", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4409), "Seeded book", null, 2020, "book-61", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4411), 1, "Book 61" },
                    { "2dae4027-3766-41b5-a7a8-5539271add43", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4347), "Seeded book", null, 2020, "book-57", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4349), 1, "Book 57" },
                    { "9934542f-77c6-4784-a06f-a6032fb675e9", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4280), "Seeded book", null, 2020, "book-53", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4282), 1, "Book 53" },
                    { "dc36b925-0830-4ecc-91f0-3f01383d5774", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4180), "Seeded book", null, 2020, "book-49", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4182), 1, "Book 49" },
                    { "1eb02c94-5042-4313-93cd-76be9619dc44", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4057), "Seeded book", null, 2020, "book-41", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4059), 1, "Book 41" },
                    { "c707d27f-eb52-4120-bc61-f06ec1adee1b", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3996), "Seeded book", null, 2020, "book-37", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3998), 1, "Book 37" },
                    { "865fc585-8d8d-4732-aac9-af45a463c5fc", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3931), "Seeded book", null, 2020, "book-33", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3933), 1, "Book 33" },
                    { "44f9cd80-aca5-4d2a-bb03-7e4d0e22729f", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3819), "Seeded book", null, 2020, "book-29", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3821), 1, "Book 29" },
                    { "f027c8df-4cd0-4a65-b736-33daea3bc19c", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3760), "Seeded book", null, 2020, "book-25", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3762), 1, "Book 25" },
                    { "f6e045fc-348d-4187-a699-245dfe161576", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3691), "Seeded book", null, 2020, "book-21", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3693), 1, "Book 21" },
                    { "80bf9afd-f4ca-4202-87b5-e33f5012b6b4", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3622), "Seeded book", null, 2020, "book-17", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3624), 1, "Book 17" },
                    { "33ac3cfb-73ad-40f9-b190-a945941aa7a9", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3544), "Seeded book", null, 2020, "book-13", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3546), 1, "Book 13" },
                    { "60721ecf-f9ca-4e37-a5c7-4be6e8091f33", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3448), "Seeded book", null, 2020, "book-9", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(3454), 1, "Book 9" },
                    { "fa4795c0-aafe-4b8b-8551-edd7bb0e096a", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(2911), "Seeded book", null, 2020, "book-5", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(2961), 1, "Book 5" },
                    { "593e92f9-f0b7-4309-bed6-a3d809e29c30", 100, new DateTime(2020, 7, 31, 8, 46, 10, 58, DateTimeKind.Local).AddTicks(4678), "Seeded book", null, 2020, "book-1", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 60, DateTimeKind.Local).AddTicks(84), 1, "Book 1" },
                    { "55dcfb6f-c301-46c1-86c9-577ba97f544f", 100, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4119), "Seeded book", null, 2020, "book-45", 33000.0, new DateTime(2020, 7, 31, 8, 46, 10, 61, DateTimeKind.Local).AddTicks(4121), 1, "Book 45" }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Code", "Name", "Value" },
                values: new object[,]
                {
                    { "08c3ff1c-d6e4-430a-b81b-1e98e26c734f", null, "Default", 0 },
                    { "426ebd3f-aab4-479c-a3a0-6dda41ba33c6", null, "Test", 10 }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "Description", "ImgPath", "Sort" },
                values: new object[,]
                {
                    { "1bc7a5d3-cc54-4552-9151-006f65a9c481", "593e92f9-f0b7-4309-bed6-a3d809e29c30", "Book 1", "/MyStaticFiles/images/book-1.jpg", 1 },
                    { "32eaf61d-5afd-4bca-8985-db0cd6964b97", "dc36b925-0830-4ecc-91f0-3f01383d5774", "Book 49", "/MyStaticFiles/images/book-49.jpg", 1 },
                    { "2e34923d-4018-41ee-bbb5-c0b69134a327", "dc36b925-0830-4ecc-91f0-3f01383d5774", "Book 49", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "86f706c8-7972-4bbf-8d03-6018b96d93a9", "dc36b925-0830-4ecc-91f0-3f01383d5774", "Book 49", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "226d2d0c-c66c-4f8d-829b-12a3355bbc1e", "9934542f-77c6-4784-a06f-a6032fb675e9", "Book 53", "/MyStaticFiles/images/book-53.jpg", 1 },
                    { "bb148705-4c43-400b-af61-99edb90c0ee2", "9934542f-77c6-4784-a06f-a6032fb675e9", "Book 53", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "fd978078-542f-408c-9a07-d6405737eee9", "9934542f-77c6-4784-a06f-a6032fb675e9", "Book 53", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "c93d05b5-01a9-4655-8e1b-a835a9522f64", "2dae4027-3766-41b5-a7a8-5539271add43", "Book 57", "/MyStaticFiles/images/book-57.jpg", 1 },
                    { "120ee072-4598-429f-b138-28c7c8ad1e3a", "2dae4027-3766-41b5-a7a8-5539271add43", "Book 57", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "bb1fb524-8ef5-41ea-838c-c1217f7cf933", "2dae4027-3766-41b5-a7a8-5539271add43", "Book 57", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "0243fd70-141d-4e05-845b-ca10c3c60c30", "ed828d55-9587-4ca5-98e7-8ca4070eac54", "Book 61", "/MyStaticFiles/images/book-61.jpg", 1 },
                    { "c01b8db0-977f-4db0-bda0-111849e773bf", "ed828d55-9587-4ca5-98e7-8ca4070eac54", "Book 61", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "9f6b6ce2-bd1b-4afc-8bec-a725516acfe1", "ed828d55-9587-4ca5-98e7-8ca4070eac54", "Book 61", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "ad652e0e-fbed-49a4-821e-56decf32c5f6", "ebb5f6cc-af3d-4eec-bf18-0122427ca937", "Book 65", "/MyStaticFiles/images/book-65.jpg", 1 },
                    { "0fe57248-bb7a-47e5-96ab-2140a304ebe6", "ebb5f6cc-af3d-4eec-bf18-0122427ca937", "Book 65", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "1ecdbcf0-21fc-4fc6-9077-8005a98684f0", "ebb5f6cc-af3d-4eec-bf18-0122427ca937", "Book 65", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a31ccd17-759b-43a7-9970-fab978374b75", "602594bb-c561-4261-a6ee-477818418c27", "Book 69", "/MyStaticFiles/images/book-69.jpg", 1 },
                    { "240516ba-1bcc-4b57-b153-f7ff11123aad", "602594bb-c561-4261-a6ee-477818418c27", "Book 69", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "3e897950-4056-4810-b385-07cc48f17a97", "1a3b9099-e755-4bb1-a7d9-1a0c580e768f", "Book 89", "/MyStaticFiles/images/book-89.jpg", 1 },
                    { "8a2e9fe0-c630-4786-b6b2-74d78f9d9dfd", "f6fee8a9-4079-4279-87f0-020338d5539b", "Book 85", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "73f017e5-8d27-417b-8886-8766ded5694e", "f6fee8a9-4079-4279-87f0-020338d5539b", "Book 85", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "95f61cf5-e106-45fb-9f7c-d11ce02170f1", "f6fee8a9-4079-4279-87f0-020338d5539b", "Book 85", "/MyStaticFiles/images/book-85.jpg", 1 },
                    { "076fbc43-9c7a-485d-b871-cdceb9e9239a", "76309a43-eace-4ce8-9597-9a9dfd954aef", "Book 81", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a5c15520-519e-469a-a2a7-711fa48eeb15", "76309a43-eace-4ce8-9597-9a9dfd954aef", "Book 81", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "f8c670fe-c0b0-4ae6-a284-0da6b111e6f6", "55dcfb6f-c301-46c1-86c9-577ba97f544f", "Book 45", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "bbe27580-2cca-40a6-a8fb-3e0e27b54de9", "76309a43-eace-4ce8-9597-9a9dfd954aef", "Book 81", "/MyStaticFiles/images/book-81.jpg", 1 },
                    { "6f875d37-3806-42aa-8840-290ea3a751d8", "ff6ff11a-00d0-4c7f-aab1-8db92fd12a15", "Book 77", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "09842bd0-acad-4155-891a-d1f101a1d965", "ff6ff11a-00d0-4c7f-aab1-8db92fd12a15", "Book 77", "/MyStaticFiles/images/book-77.jpg", 1 },
                    { "167fa017-b42a-46be-bf26-9b422f7ece47", "60726fc9-b641-4a7a-aea4-26288ffaddc3", "Book 73", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "b93c73d2-5dc4-46ee-8163-b31e19dbe38b", "60726fc9-b641-4a7a-aea4-26288ffaddc3", "Book 73", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "7605d0bd-9ee5-4080-9f6d-d2cb4630f545", "60726fc9-b641-4a7a-aea4-26288ffaddc3", "Book 73", "/MyStaticFiles/images/book-73.jpg", 1 },
                    { "a37483bc-35d1-4712-b652-d3744e9c222d", "602594bb-c561-4261-a6ee-477818418c27", "Book 69", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "94eb1ad2-8299-458d-b615-a090c8e8108e", "ff6ff11a-00d0-4c7f-aab1-8db92fd12a15", "Book 77", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "0d42cb1e-5f10-4f1e-83ae-cf5e568173e4", "1a3b9099-e755-4bb1-a7d9-1a0c580e768f", "Book 89", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "8538ce1f-30cd-4ff9-a972-2cc39b5f3c89", "55dcfb6f-c301-46c1-86c9-577ba97f544f", "Book 45", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "c40cb235-d81b-43af-8dff-9e6603734d62", "1eb02c94-5042-4313-93cd-76be9619dc44", "Book 41", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "93358177-8fe5-4a78-b2e1-8568c567faab", "593e92f9-f0b7-4309-bed6-a3d809e29c30", "Book 1", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "ace45618-db22-44be-bac3-90b650e4bcbd", "593e92f9-f0b7-4309-bed6-a3d809e29c30", "Book 1", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "f604a9fe-c03a-44be-86b7-0a00fa7c5072", "fa4795c0-aafe-4b8b-8551-edd7bb0e096a", "Book 5", "/MyStaticFiles/images/book-5.jpg", 1 },
                    { "4b6ec743-853e-4c16-b36f-feda66772062", "fa4795c0-aafe-4b8b-8551-edd7bb0e096a", "Book 5", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "16210f40-5cc9-4b99-aeaf-1cdf55a3167d", "fa4795c0-aafe-4b8b-8551-edd7bb0e096a", "Book 5", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "78b019ce-0841-4e16-a94e-a1c55e1c9422", "60721ecf-f9ca-4e37-a5c7-4be6e8091f33", "Book 9", "/MyStaticFiles/images/book-9.jpg", 1 },
                    { "26dfb064-08bd-442d-84ca-6353e145539f", "60721ecf-f9ca-4e37-a5c7-4be6e8091f33", "Book 9", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "e58103a6-3301-4f21-8997-1540bb834d87", "60721ecf-f9ca-4e37-a5c7-4be6e8091f33", "Book 9", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "dccd6a5d-c18c-4cb8-a1e3-998d9d047bd1", "33ac3cfb-73ad-40f9-b190-a945941aa7a9", "Book 13", "/MyStaticFiles/images/book-13.jpg", 1 },
                    { "00c1ca78-0353-4f8c-b0fc-1dfe451fcc6c", "33ac3cfb-73ad-40f9-b190-a945941aa7a9", "Book 13", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "f298f15f-dba6-4a1e-8ba3-3eb792828af9", "33ac3cfb-73ad-40f9-b190-a945941aa7a9", "Book 13", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "f1a593f7-3e9b-4fc4-9040-5c794582cc31", "80bf9afd-f4ca-4202-87b5-e33f5012b6b4", "Book 17", "/MyStaticFiles/images/book-17.jpg", 1 },
                    { "6e6ae6bc-7429-456d-b25b-8578a99b7848", "80bf9afd-f4ca-4202-87b5-e33f5012b6b4", "Book 17", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "764aee56-590a-444d-8246-440a812eb61a", "80bf9afd-f4ca-4202-87b5-e33f5012b6b4", "Book 17", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "c4a6740e-3863-4fe4-baf1-415e999d9392", "f6e045fc-348d-4187-a699-245dfe161576", "Book 21", "/MyStaticFiles/images/book-21.jpg", 1 },
                    { "dc6ed6b6-46fc-43d5-afd5-d56597f0cd72", "f6e045fc-348d-4187-a699-245dfe161576", "Book 21", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "586b8fec-a0e9-4ac8-a023-8118234df120", "f6e045fc-348d-4187-a699-245dfe161576", "Book 21", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "6e672e17-263a-4452-98dd-a83f1b7634de", "1eb02c94-5042-4313-93cd-76be9619dc44", "Book 41", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "6934662d-b56a-4130-b776-5af9b4dd5f64", "1eb02c94-5042-4313-93cd-76be9619dc44", "Book 41", "/MyStaticFiles/images/book-41.jpg", 1 },
                    { "16ba4778-389e-4be7-9655-853a2cd2caab", "c707d27f-eb52-4120-bc61-f06ec1adee1b", "Book 37", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "241d073b-66d6-405e-8f1b-e3b0101eb12f", "c707d27f-eb52-4120-bc61-f06ec1adee1b", "Book 37", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "86a21389-d4b7-4618-98de-622cff27e19b", "c707d27f-eb52-4120-bc61-f06ec1adee1b", "Book 37", "/MyStaticFiles/images/book-37.jpg", 1 },
                    { "2191bc20-8acc-4c34-88ef-6b9f0f7967cc", "865fc585-8d8d-4732-aac9-af45a463c5fc", "Book 33", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "4cc150a9-7eb5-41e9-8e2a-d407f25663dc", "55dcfb6f-c301-46c1-86c9-577ba97f544f", "Book 45", "/MyStaticFiles/images/book-45.jpg", 1 },
                    { "48d06958-f4d7-4851-90f0-d1eface39531", "865fc585-8d8d-4732-aac9-af45a463c5fc", "Book 33", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "00cb6749-7c47-481d-850d-96c650a3cd44", "44f9cd80-aca5-4d2a-bb03-7e4d0e22729f", "Book 29", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "48447695-67c6-4bee-b011-6b54f90598d5", "44f9cd80-aca5-4d2a-bb03-7e4d0e22729f", "Book 29", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "0cec6ff3-1bc9-4dd0-8e00-bebda6161601", "44f9cd80-aca5-4d2a-bb03-7e4d0e22729f", "Book 29", "/MyStaticFiles/images/book-29.jpg", 1 },
                    { "1cf222fe-6c34-4ac1-b202-00c8a6849a49", "f027c8df-4cd0-4a65-b736-33daea3bc19c", "Book 25", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "08b4e402-64b7-4f07-9f28-a5aaa04ee9ae", "f027c8df-4cd0-4a65-b736-33daea3bc19c", "Book 25", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "fa659114-f0be-4a03-9c59-17f5d3672ae9", "f027c8df-4cd0-4a65-b736-33daea3bc19c", "Book 25", "/MyStaticFiles/images/book-25.jpg", 1 },
                    { "6210cf1d-e07e-4a9c-9cd9-81c5e2c46c91", "865fc585-8d8d-4732-aac9-af45a463c5fc", "Book 33", "/MyStaticFiles/images/book-33.jpg", 1 },
                    { "0f11e19e-ce2f-49af-907d-ad971affbb5b", "1a3b9099-e755-4bb1-a7d9-1a0c580e768f", "Book 89", "/MyStaticFiles/images/product3.jpg", 3 }
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
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
