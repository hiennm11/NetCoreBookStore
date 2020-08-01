using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreBookStore.Data.Migrations
{
    public partial class ShoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2"), new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2964f74-1c5c-419a-8377-bcc8e9ea4dc2"));

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "00c1ca78-0353-4f8c-b0fc-1dfe451fcc6c");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "00cb6749-7c47-481d-850d-96c650a3cd44");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "0243fd70-141d-4e05-845b-ca10c3c60c30");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "076fbc43-9c7a-485d-b871-cdceb9e9239a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "08b4e402-64b7-4f07-9f28-a5aaa04ee9ae");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "09842bd0-acad-4155-891a-d1f101a1d965");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "0cec6ff3-1bc9-4dd0-8e00-bebda6161601");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "0d42cb1e-5f10-4f1e-83ae-cf5e568173e4");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "0f11e19e-ce2f-49af-907d-ad971affbb5b");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "0fe57248-bb7a-47e5-96ab-2140a304ebe6");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "120ee072-4598-429f-b138-28c7c8ad1e3a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "16210f40-5cc9-4b99-aeaf-1cdf55a3167d");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "167fa017-b42a-46be-bf26-9b422f7ece47");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "16ba4778-389e-4be7-9655-853a2cd2caab");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "1bc7a5d3-cc54-4552-9151-006f65a9c481");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "1cf222fe-6c34-4ac1-b202-00c8a6849a49");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "1ecdbcf0-21fc-4fc6-9077-8005a98684f0");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "2191bc20-8acc-4c34-88ef-6b9f0f7967cc");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "226d2d0c-c66c-4f8d-829b-12a3355bbc1e");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "240516ba-1bcc-4b57-b153-f7ff11123aad");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "241d073b-66d6-405e-8f1b-e3b0101eb12f");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "26dfb064-08bd-442d-84ca-6353e145539f");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "2e34923d-4018-41ee-bbb5-c0b69134a327");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "32eaf61d-5afd-4bca-8985-db0cd6964b97");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "3e897950-4056-4810-b385-07cc48f17a97");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "48447695-67c6-4bee-b011-6b54f90598d5");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "48d06958-f4d7-4851-90f0-d1eface39531");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "4b6ec743-853e-4c16-b36f-feda66772062");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "4cc150a9-7eb5-41e9-8e2a-d407f25663dc");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "586b8fec-a0e9-4ac8-a023-8118234df120");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6210cf1d-e07e-4a9c-9cd9-81c5e2c46c91");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6934662d-b56a-4130-b776-5af9b4dd5f64");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6e672e17-263a-4452-98dd-a83f1b7634de");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6e6ae6bc-7429-456d-b25b-8578a99b7848");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6f875d37-3806-42aa-8840-290ea3a751d8");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "73f017e5-8d27-417b-8886-8766ded5694e");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "7605d0bd-9ee5-4080-9f6d-d2cb4630f545");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "764aee56-590a-444d-8246-440a812eb61a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "78b019ce-0841-4e16-a94e-a1c55e1c9422");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "8538ce1f-30cd-4ff9-a972-2cc39b5f3c89");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "86a21389-d4b7-4618-98de-622cff27e19b");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "86f706c8-7972-4bbf-8d03-6018b96d93a9");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "8a2e9fe0-c630-4786-b6b2-74d78f9d9dfd");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "93358177-8fe5-4a78-b2e1-8568c567faab");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "94eb1ad2-8299-458d-b615-a090c8e8108e");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "95f61cf5-e106-45fb-9f7c-d11ce02170f1");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "9f6b6ce2-bd1b-4afc-8bec-a725516acfe1");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a31ccd17-759b-43a7-9970-fab978374b75");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a37483bc-35d1-4712-b652-d3744e9c222d");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a5c15520-519e-469a-a2a7-711fa48eeb15");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "ace45618-db22-44be-bac3-90b650e4bcbd");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "ad652e0e-fbed-49a4-821e-56decf32c5f6");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "b93c73d2-5dc4-46ee-8163-b31e19dbe38b");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "bb148705-4c43-400b-af61-99edb90c0ee2");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "bb1fb524-8ef5-41ea-838c-c1217f7cf933");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "bbe27580-2cca-40a6-a8fb-3e0e27b54de9");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "c01b8db0-977f-4db0-bda0-111849e773bf");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "c40cb235-d81b-43af-8dff-9e6603734d62");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "c4a6740e-3863-4fe4-baf1-415e999d9392");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "c93d05b5-01a9-4655-8e1b-a835a9522f64");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "dc6ed6b6-46fc-43d5-afd5-d56597f0cd72");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "dccd6a5d-c18c-4cb8-a1e3-998d9d047bd1");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "e58103a6-3301-4f21-8997-1540bb834d87");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "f1a593f7-3e9b-4fc4-9040-5c794582cc31");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "f298f15f-dba6-4a1e-8ba3-3eb792828af9");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "f604a9fe-c03a-44be-86b7-0a00fa7c5072");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "f8c670fe-c0b0-4ae6-a284-0da6b111e6f6");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "fa659114-f0be-4a03-9c59-17f5d3672ae9");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "fd978078-542f-408c-9a07-d6405737eee9");

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: "08c3ff1c-d6e4-430a-b81b-1e98e26c734f");

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: "426ebd3f-aab4-479c-a3a0-6dda41ba33c6");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "1a3b9099-e755-4bb1-a7d9-1a0c580e768f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "1eb02c94-5042-4313-93cd-76be9619dc44");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "2dae4027-3766-41b5-a7a8-5539271add43");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "33ac3cfb-73ad-40f9-b190-a945941aa7a9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "44f9cd80-aca5-4d2a-bb03-7e4d0e22729f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "55dcfb6f-c301-46c1-86c9-577ba97f544f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "593e92f9-f0b7-4309-bed6-a3d809e29c30");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "602594bb-c561-4261-a6ee-477818418c27");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "60721ecf-f9ca-4e37-a5c7-4be6e8091f33");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "60726fc9-b641-4a7a-aea4-26288ffaddc3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "76309a43-eace-4ce8-9597-9a9dfd954aef");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "80bf9afd-f4ca-4202-87b5-e33f5012b6b4");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "865fc585-8d8d-4732-aac9-af45a463c5fc");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9934542f-77c6-4784-a06f-a6032fb675e9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "c707d27f-eb52-4120-bc61-f06ec1adee1b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "dc36b925-0830-4ecc-91f0-3f01383d5774");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ebb5f6cc-af3d-4eec-bf18-0122427ca937");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ed828d55-9587-4ca5-98e7-8ca4070eac54");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "f027c8df-4cd0-4a65-b736-33daea3bc19c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "f6e045fc-348d-4187-a699-245dfe161576");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "f6fee8a9-4079-4279-87f0-020338d5539b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "fa4795c0-aafe-4b8b-8551-edd7bb0e096a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ff6ff11a-00d0-4c7f-aab1-8db92fd12a15");

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

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299"), "e5cd344a-e550-4e2d-9778-ea41834dc307", "Admin role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299"), new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299"), 0, "724ae484-e0d5-4b73-b264-e6345205ba52", new DateTime(2020, 8, 1, 6, 22, 36, 264, DateTimeKind.Local).AddTicks(494), "app-admin@abc.xyz", true, "Admin", "Admin", false, null, "app-admin@abc.xyz", "admin", "AQAAAAEAACcQAAAAEOfc/VrUfBOQCcIBbM94m79vZBRufQZYLdN3KTfss9pjjVwTVOUYWnDEejvHsECzHg==", "0985123745", false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AvailableQuantity", "CreatedDate", "Description", "DiscountId", "Edition", "NameAlias", "Price", "PublicationDate", "Status", "Title" },
                values: new object[,]
                {
                    { "fc9d65bd-7e00-4242-9bf8-39b83736a79f", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1425), "<p>Book 89 is simply dummy text of the printing and typesetting industry. Book 89 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 89 has been the book. </p><p>Book 89's Description here  </p>", null, 2020, "book-89", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1427), 1, "Book 89" },
                    { "a73606f5-d76a-46d8-91bb-9737dec3064c", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1348), "<p>Book 85 is simply dummy text of the printing and typesetting industry. Book 85 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 85 has been the book. </p><p>Book 85's Description here  </p>", null, 2020, "book-85", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1350), 1, "Book 85" },
                    { "7d45aa39-b7fe-408d-b606-2729cc45929b", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1278), "<p>Book 81 is simply dummy text of the printing and typesetting industry. Book 81 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 81 has been the book. </p><p>Book 81's Description here  </p>", null, 2020, "book-81", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1280), 1, "Book 81" },
                    { "a3cfcdda-639b-4342-b8af-22e9c907ff83", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1200), "<p>Book 77 is simply dummy text of the printing and typesetting industry. Book 77 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 77 has been the book. </p><p>Book 77's Description here  </p>", null, 2020, "book-77", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1201), 1, "Book 77" },
                    { "e8cff779-7531-41da-add2-635dac60d139", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1158), "<p>Book 73 is simply dummy text of the printing and typesetting industry. Book 73 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 73 has been the book. </p><p>Book 73's Description here  </p>", null, 2020, "book-73", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1159), 1, "Book 73" },
                    { "354f07d6-112a-4f7e-ba82-cd8bc0cefddf", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1085), "<p>Book 69 is simply dummy text of the printing and typesetting industry. Book 69 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 69 has been the book. </p><p>Book 69's Description here  </p>", null, 2020, "book-69", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1086), 1, "Book 69" },
                    { "139dc314-c48d-4713-86ad-b51f83daed0c", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1044), "<p>Book 65 is simply dummy text of the printing and typesetting industry. Book 65 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 65 has been the book. </p><p>Book 65's Description here  </p>", null, 2020, "book-65", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1045), 1, "Book 65" },
                    { "e2d9cf0c-baa4-464b-9071-17db23fc3557", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1001), "<p>Book 61 is simply dummy text of the printing and typesetting industry. Book 61 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 61 has been the book. </p><p>Book 61's Description here  </p>", null, 2020, "book-61", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(1002), 1, "Book 61" },
                    { "419ea699-6f65-4918-9aa6-183bf61f3ab2", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(959), "<p>Book 57 is simply dummy text of the printing and typesetting industry. Book 57 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 57 has been the book. </p><p>Book 57's Description here  </p>", null, 2020, "book-57", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(960), 1, "Book 57" },
                    { "e5db32f1-4e3a-489e-b22f-c4b2c415949f", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(885), "<p>Book 53 is simply dummy text of the printing and typesetting industry. Book 53 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 53 has been the book. </p><p>Book 53's Description here  </p>", null, 2020, "book-53", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(886), 1, "Book 53" },
                    { "376cebea-4428-4746-8376-2055cd19c285", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(846), "<p>Book 49 is simply dummy text of the printing and typesetting industry. Book 49 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 49 has been the book. </p><p>Book 49's Description here  </p>", null, 2020, "book-49", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(847), 1, "Book 49" },
                    { "8d8bea9a-7125-49ec-99e9-1596eb1058f8", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(758), "<p>Book 41 is simply dummy text of the printing and typesetting industry. Book 41 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 41 has been the book. </p><p>Book 41's Description here  </p>", null, 2020, "book-41", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(760), 1, "Book 41" },
                    { "749ca424-9791-4693-a85a-0e1c955ac5f9", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(647), "<p>Book 37 is simply dummy text of the printing and typesetting industry. Book 37 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 37 has been the book. </p><p>Book 37's Description here  </p>", null, 2020, "book-37", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(648), 1, "Book 37" },
                    { "ff2d5ebc-7a8f-467b-a983-357f33693840", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(606), "<p>Book 33 is simply dummy text of the printing and typesetting industry. Book 33 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 33 has been the book. </p><p>Book 33's Description here  </p>", null, 2020, "book-33", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(608), 1, "Book 33" },
                    { "80a14e57-b9a4-47e9-9144-627e5b1668ee", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(563), "<p>Book 29 is simply dummy text of the printing and typesetting industry. Book 29 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 29 has been the book. </p><p>Book 29's Description here  </p>", null, 2020, "book-29", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(564), 1, "Book 29" },
                    { "d6981c48-11c1-41d6-be9e-cf2a60dda2c6", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(521), "<p>Book 25 is simply dummy text of the printing and typesetting industry. Book 25 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 25 has been the book. </p><p>Book 25's Description here  </p>", null, 2020, "book-25", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(522), 1, "Book 25" },
                    { "c0750072-426c-44cd-92d7-39bd02c71cf0", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(429), "<p>Book 21 is simply dummy text of the printing and typesetting industry. Book 21 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 21 has been the book. </p><p>Book 21's Description here  </p>", null, 2020, "book-21", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(430), 1, "Book 21" },
                    { "8fc1ddfe-4880-4ff8-b265-0e6f57afc1c1", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(387), "<p>Book 17 is simply dummy text of the printing and typesetting industry. Book 17 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 17 has been the book. </p><p>Book 17's Description here  </p>", null, 2020, "book-17", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(388), 1, "Book 17" },
                    { "6fbc53ee-78f0-4f73-a7f7-ec42084e1a2c", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(340), "<p>Book 13 is simply dummy text of the printing and typesetting industry. Book 13 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 13 has been the book. </p><p>Book 13's Description here  </p>", null, 2020, "book-13", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(342), 1, "Book 13" },
                    { "60300f7c-2afd-4309-882e-0e821bfbfed0", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(291), "<p>Book 9 is simply dummy text of the printing and typesetting industry. Book 9 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 9 has been the book. </p><p>Book 9's Description here  </p>", null, 2020, "book-9", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(293), 1, "Book 9" },
                    { "446d4499-bd54-46e1-b93f-45b7e38101e1", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(15), "<p>Book 5 is simply dummy text of the printing and typesetting industry. Book 5 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 5 has been the book. </p><p>Book 5's Description here  </p>", null, 2020, "book-5", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(31), 1, "Book 5" },
                    { "9bb6c949-1bea-48a6-94a0-f2c4b1614b81", 100, new DateTime(2020, 8, 1, 6, 22, 36, 246, DateTimeKind.Local).AddTicks(1815), "<p>Book 1 is simply dummy text of the printing and typesetting industry. Book 1 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 1 has been the book. </p><p>Book 1's Description here  </p>", null, 2020, "book-1", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 247, DateTimeKind.Local).AddTicks(955), 1, "Book 1" },
                    { "a10023f7-a765-4782-bc89-4891c2bc90dd", 100, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(803), "<p>Book 45 is simply dummy text of the printing and typesetting industry. Book 45 has been the industry's printer took a galley of type and Scrambled it to make a type and typesetting industry. Book 45 has been the book. </p><p>Book 45's Description here  </p>", null, 2020, "book-45", 33000.0, new DateTime(2020, 8, 1, 6, 22, 36, 248, DateTimeKind.Local).AddTicks(804), 1, "Book 45" }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Code", "Name", "Value" },
                values: new object[,]
                {
                    { "471e6bd8-a175-449a-9626-b4bbe17d2729", null, "Default", 0 },
                    { "ab4317bb-7b09-4c5d-a655-334a59b5a821", null, "Test", 10 }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "Description", "ImgPath", "Sort" },
                values: new object[,]
                {
                    { "e09087cd-5ae5-4e27-aa71-044ad0a909c1", "9bb6c949-1bea-48a6-94a0-f2c4b1614b81", "Book 1", "/MyStaticFiles/images/book-1.jpg", 1 },
                    { "d9bd02b1-96ca-44b6-b83b-5bbc2f99a019", "376cebea-4428-4746-8376-2055cd19c285", "Book 49", "/MyStaticFiles/images/book-49.jpg", 1 },
                    { "40110ada-93ac-40c5-849a-8ec6c933478a", "376cebea-4428-4746-8376-2055cd19c285", "Book 49", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "77ca25aa-07b7-49b8-958c-d5a4adc90b0a", "376cebea-4428-4746-8376-2055cd19c285", "Book 49", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "58c74c5b-43c2-47d7-974a-5494ec8dede0", "e5db32f1-4e3a-489e-b22f-c4b2c415949f", "Book 53", "/MyStaticFiles/images/book-53.jpg", 1 },
                    { "357626b4-93a1-4824-8292-d46d9defdf26", "e5db32f1-4e3a-489e-b22f-c4b2c415949f", "Book 53", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "7dcb7a2d-acd4-4081-a703-d513d5b907ab", "e5db32f1-4e3a-489e-b22f-c4b2c415949f", "Book 53", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "1fa5d7b7-d538-4fa3-af1f-1468ab08bea9", "419ea699-6f65-4918-9aa6-183bf61f3ab2", "Book 57", "/MyStaticFiles/images/book-57.jpg", 1 },
                    { "5f53efd8-cc61-4d01-8a8d-558262dd0181", "419ea699-6f65-4918-9aa6-183bf61f3ab2", "Book 57", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "aeefc476-c30f-4a22-b226-4d95ef64a470", "419ea699-6f65-4918-9aa6-183bf61f3ab2", "Book 57", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "7142a848-6b6d-41e5-9f78-0ecd48e15d48", "e2d9cf0c-baa4-464b-9071-17db23fc3557", "Book 61", "/MyStaticFiles/images/book-61.jpg", 1 },
                    { "7b2a1227-689c-4e4a-b9bd-8ed5beadefbe", "e2d9cf0c-baa4-464b-9071-17db23fc3557", "Book 61", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "736efc68-fd67-44d2-b176-612db0fb5268", "e2d9cf0c-baa4-464b-9071-17db23fc3557", "Book 61", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "efeed228-222a-4ac2-953d-efd32eb0d85f", "139dc314-c48d-4713-86ad-b51f83daed0c", "Book 65", "/MyStaticFiles/images/book-65.jpg", 1 },
                    { "cda1a5b4-65b8-4e68-a596-79bbc5d5efd5", "139dc314-c48d-4713-86ad-b51f83daed0c", "Book 65", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "99e9708a-f4dc-40b9-87f2-6424f0b1a0dd", "139dc314-c48d-4713-86ad-b51f83daed0c", "Book 65", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "76bbd5b1-5608-4a20-b45a-845ee7cc7d01", "354f07d6-112a-4f7e-ba82-cd8bc0cefddf", "Book 69", "/MyStaticFiles/images/book-69.jpg", 1 },
                    { "233f1155-f930-455f-9a6d-bbe812e37823", "354f07d6-112a-4f7e-ba82-cd8bc0cefddf", "Book 69", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "c53c65fe-b296-475f-8bad-62a2f781c6ad", "fc9d65bd-7e00-4242-9bf8-39b83736a79f", "Book 89", "/MyStaticFiles/images/book-89.jpg", 1 },
                    { "0d8d8a32-c72e-4d57-9ae8-601223adb5f6", "a73606f5-d76a-46d8-91bb-9737dec3064c", "Book 85", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "281faead-5f5a-44d5-a294-2c75029a2c21", "a73606f5-d76a-46d8-91bb-9737dec3064c", "Book 85", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "f2d0b8d5-2a87-4ad8-ade9-788d110e7cae", "a73606f5-d76a-46d8-91bb-9737dec3064c", "Book 85", "/MyStaticFiles/images/book-85.jpg", 1 },
                    { "39737ecd-261b-44c7-bdbe-5ab7fc74bbe3", "7d45aa39-b7fe-408d-b606-2729cc45929b", "Book 81", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "1b41130a-1422-4302-8c4b-d1a38334ce92", "7d45aa39-b7fe-408d-b606-2729cc45929b", "Book 81", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "a50a0d2c-e867-4a61-8e26-b3ef796029af", "a10023f7-a765-4782-bc89-4891c2bc90dd", "Book 45", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "68f4213d-e1d5-422f-a00f-634041b1c921", "7d45aa39-b7fe-408d-b606-2729cc45929b", "Book 81", "/MyStaticFiles/images/book-81.jpg", 1 },
                    { "df4f0cb0-e1a7-4736-9f6f-2e9cd4751d5a", "a3cfcdda-639b-4342-b8af-22e9c907ff83", "Book 77", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "2be05978-1ddf-4c16-80eb-15ebe83ea6a7", "a3cfcdda-639b-4342-b8af-22e9c907ff83", "Book 77", "/MyStaticFiles/images/book-77.jpg", 1 },
                    { "e4878983-1ae7-4a71-bc99-ed5fc553656f", "e8cff779-7531-41da-add2-635dac60d139", "Book 73", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "cf76b9f2-aa42-4cd7-9073-7b8cba48ad66", "e8cff779-7531-41da-add2-635dac60d139", "Book 73", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "d39bb4c8-d420-4676-a833-742630d75f1d", "e8cff779-7531-41da-add2-635dac60d139", "Book 73", "/MyStaticFiles/images/book-73.jpg", 1 },
                    { "047845d7-96cf-47d9-bf65-61080ff49db5", "354f07d6-112a-4f7e-ba82-cd8bc0cefddf", "Book 69", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "b3d431e4-2a45-487d-9495-68c6e77d417c", "a3cfcdda-639b-4342-b8af-22e9c907ff83", "Book 77", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "db27a8ed-541c-4530-9ffc-48b6c5264d85", "fc9d65bd-7e00-4242-9bf8-39b83736a79f", "Book 89", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "6adcc4ae-4a8f-495f-aed0-3c1cd0cf1b9c", "a10023f7-a765-4782-bc89-4891c2bc90dd", "Book 45", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "35b486d1-773e-4dd0-ae10-105b0e45d016", "8d8bea9a-7125-49ec-99e9-1596eb1058f8", "Book 41", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "c930f692-da87-45a9-af78-a69264cc857a", "9bb6c949-1bea-48a6-94a0-f2c4b1614b81", "Book 1", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "a2ca6675-7902-485a-a8cc-7d864923596c", "9bb6c949-1bea-48a6-94a0-f2c4b1614b81", "Book 1", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "fbfdbb80-4a46-4700-8ba9-bd9a89329eff", "446d4499-bd54-46e1-b93f-45b7e38101e1", "Book 5", "/MyStaticFiles/images/book-5.jpg", 1 },
                    { "0222ed86-816f-4047-b204-7014f9918a38", "446d4499-bd54-46e1-b93f-45b7e38101e1", "Book 5", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "032bdcc3-920f-41eb-9077-313c4a6737f6", "446d4499-bd54-46e1-b93f-45b7e38101e1", "Book 5", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a60a3014-7783-4c27-8f54-a5af4b198cde", "60300f7c-2afd-4309-882e-0e821bfbfed0", "Book 9", "/MyStaticFiles/images/book-9.jpg", 1 },
                    { "7abd4691-627d-43c8-9eac-af302b8bc419", "60300f7c-2afd-4309-882e-0e821bfbfed0", "Book 9", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "033c668d-7ad0-433e-8fe1-c9b01e83e337", "60300f7c-2afd-4309-882e-0e821bfbfed0", "Book 9", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "1d1f2471-c903-4141-8d12-2c52edfeed4d", "6fbc53ee-78f0-4f73-a7f7-ec42084e1a2c", "Book 13", "/MyStaticFiles/images/book-13.jpg", 1 },
                    { "854129eb-9e55-4557-b3ed-299deb2e4444", "6fbc53ee-78f0-4f73-a7f7-ec42084e1a2c", "Book 13", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "b2c53df1-061b-4045-9864-9075bd00874f", "6fbc53ee-78f0-4f73-a7f7-ec42084e1a2c", "Book 13", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "a0c7678f-433b-45f7-a666-9fd6ce842b46", "8fc1ddfe-4880-4ff8-b265-0e6f57afc1c1", "Book 17", "/MyStaticFiles/images/book-17.jpg", 1 },
                    { "6da96542-660a-4f37-b0d6-d00cb1f87222", "8fc1ddfe-4880-4ff8-b265-0e6f57afc1c1", "Book 17", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "63600634-83a1-4cc3-b0c3-07b144ca6d2c", "8fc1ddfe-4880-4ff8-b265-0e6f57afc1c1", "Book 17", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "55d97c95-8a30-4892-bc5a-d699e11c71ae", "c0750072-426c-44cd-92d7-39bd02c71cf0", "Book 21", "/MyStaticFiles/images/book-21.jpg", 1 },
                    { "ec1afb29-3592-4004-b08b-8e773ef0d272", "c0750072-426c-44cd-92d7-39bd02c71cf0", "Book 21", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "c0dea46d-30ee-4eea-bf57-e873f68d54c1", "c0750072-426c-44cd-92d7-39bd02c71cf0", "Book 21", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "e6bbb354-68dd-40f5-8e64-4ed74c552ed5", "8d8bea9a-7125-49ec-99e9-1596eb1058f8", "Book 41", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "8ded87ff-5edd-42e9-b51c-80909df4ff65", "8d8bea9a-7125-49ec-99e9-1596eb1058f8", "Book 41", "/MyStaticFiles/images/book-41.jpg", 1 },
                    { "f4ac4031-3ab4-4598-9b2a-b1b3ada80b77", "749ca424-9791-4693-a85a-0e1c955ac5f9", "Book 37", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "035785df-9fa3-44e0-86c2-29f14c5f74bd", "749ca424-9791-4693-a85a-0e1c955ac5f9", "Book 37", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "f77d63d6-18ca-4775-bf92-2bb16e0703ed", "749ca424-9791-4693-a85a-0e1c955ac5f9", "Book 37", "/MyStaticFiles/images/book-37.jpg", 1 },
                    { "aed86228-93d9-4f4d-873a-07107987c56c", "ff2d5ebc-7a8f-467b-a983-357f33693840", "Book 33", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "50f68694-d058-4007-9386-8faa82453a6f", "a10023f7-a765-4782-bc89-4891c2bc90dd", "Book 45", "/MyStaticFiles/images/book-45.jpg", 1 },
                    { "57c7421b-01b2-473b-ad47-fa85021252bf", "ff2d5ebc-7a8f-467b-a983-357f33693840", "Book 33", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "5f4c60eb-fa81-4955-8276-dda97ce920d6", "80a14e57-b9a4-47e9-9144-627e5b1668ee", "Book 29", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "5cc375c6-d3d1-41de-8f00-b828033b4e5c", "80a14e57-b9a4-47e9-9144-627e5b1668ee", "Book 29", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "670cdb48-b36d-4c56-b5c2-06b318c88983", "80a14e57-b9a4-47e9-9144-627e5b1668ee", "Book 29", "/MyStaticFiles/images/book-29.jpg", 1 },
                    { "a99537c3-e60d-40bb-a607-c8d0ef78c352", "d6981c48-11c1-41d6-be9e-cf2a60dda2c6", "Book 25", "/MyStaticFiles/images/product3.jpg", 3 },
                    { "8bfec877-3583-4755-92b4-dbd75eef95bc", "d6981c48-11c1-41d6-be9e-cf2a60dda2c6", "Book 25", "/MyStaticFiles/images/product2.jpg", 2 },
                    { "89f3d676-c94d-47e7-a98b-91515821719a", "d6981c48-11c1-41d6-be9e-cf2a60dda2c6", "Book 25", "/MyStaticFiles/images/book-25.jpg", 1 },
                    { "21c826e6-74f2-4fba-a63d-f77ea5019c93", "ff2d5ebc-7a8f-467b-a983-357f33693840", "Book 33", "/MyStaticFiles/images/book-33.jpg", 1 },
                    { "6fa3dabe-cc48-4150-baf9-91085dd0821e", "fc9d65bd-7e00-4242-9bf8-39b83736a79f", "Book 89", "/MyStaticFiles/images/product3.jpg", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_BookId",
                table: "ShoppingCartItems",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299"), new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a40bcfd4-4acf-45b1-9472-ec3b56483299"));

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "0222ed86-816f-4047-b204-7014f9918a38");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "032bdcc3-920f-41eb-9077-313c4a6737f6");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "033c668d-7ad0-433e-8fe1-c9b01e83e337");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "035785df-9fa3-44e0-86c2-29f14c5f74bd");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "047845d7-96cf-47d9-bf65-61080ff49db5");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "0d8d8a32-c72e-4d57-9ae8-601223adb5f6");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "1b41130a-1422-4302-8c4b-d1a38334ce92");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "1d1f2471-c903-4141-8d12-2c52edfeed4d");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "1fa5d7b7-d538-4fa3-af1f-1468ab08bea9");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "21c826e6-74f2-4fba-a63d-f77ea5019c93");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "233f1155-f930-455f-9a6d-bbe812e37823");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "281faead-5f5a-44d5-a294-2c75029a2c21");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "2be05978-1ddf-4c16-80eb-15ebe83ea6a7");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "357626b4-93a1-4824-8292-d46d9defdf26");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "35b486d1-773e-4dd0-ae10-105b0e45d016");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "39737ecd-261b-44c7-bdbe-5ab7fc74bbe3");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "40110ada-93ac-40c5-849a-8ec6c933478a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "50f68694-d058-4007-9386-8faa82453a6f");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "55d97c95-8a30-4892-bc5a-d699e11c71ae");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "57c7421b-01b2-473b-ad47-fa85021252bf");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "58c74c5b-43c2-47d7-974a-5494ec8dede0");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "5cc375c6-d3d1-41de-8f00-b828033b4e5c");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "5f4c60eb-fa81-4955-8276-dda97ce920d6");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "5f53efd8-cc61-4d01-8a8d-558262dd0181");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "63600634-83a1-4cc3-b0c3-07b144ca6d2c");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "670cdb48-b36d-4c56-b5c2-06b318c88983");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "68f4213d-e1d5-422f-a00f-634041b1c921");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6adcc4ae-4a8f-495f-aed0-3c1cd0cf1b9c");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6da96542-660a-4f37-b0d6-d00cb1f87222");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "6fa3dabe-cc48-4150-baf9-91085dd0821e");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "7142a848-6b6d-41e5-9f78-0ecd48e15d48");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "736efc68-fd67-44d2-b176-612db0fb5268");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "76bbd5b1-5608-4a20-b45a-845ee7cc7d01");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "77ca25aa-07b7-49b8-958c-d5a4adc90b0a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "7abd4691-627d-43c8-9eac-af302b8bc419");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "7b2a1227-689c-4e4a-b9bd-8ed5beadefbe");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "7dcb7a2d-acd4-4081-a703-d513d5b907ab");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "854129eb-9e55-4557-b3ed-299deb2e4444");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "89f3d676-c94d-47e7-a98b-91515821719a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "8bfec877-3583-4755-92b4-dbd75eef95bc");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "8ded87ff-5edd-42e9-b51c-80909df4ff65");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "99e9708a-f4dc-40b9-87f2-6424f0b1a0dd");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a0c7678f-433b-45f7-a666-9fd6ce842b46");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a2ca6675-7902-485a-a8cc-7d864923596c");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a50a0d2c-e867-4a61-8e26-b3ef796029af");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a60a3014-7783-4c27-8f54-a5af4b198cde");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "a99537c3-e60d-40bb-a607-c8d0ef78c352");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "aed86228-93d9-4f4d-873a-07107987c56c");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "aeefc476-c30f-4a22-b226-4d95ef64a470");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "b2c53df1-061b-4045-9864-9075bd00874f");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "b3d431e4-2a45-487d-9495-68c6e77d417c");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "c0dea46d-30ee-4eea-bf57-e873f68d54c1");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "c53c65fe-b296-475f-8bad-62a2f781c6ad");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "c930f692-da87-45a9-af78-a69264cc857a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "cda1a5b4-65b8-4e68-a596-79bbc5d5efd5");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "cf76b9f2-aa42-4cd7-9073-7b8cba48ad66");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "d39bb4c8-d420-4676-a833-742630d75f1d");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "d9bd02b1-96ca-44b6-b83b-5bbc2f99a019");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "db27a8ed-541c-4530-9ffc-48b6c5264d85");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "df4f0cb0-e1a7-4736-9f6f-2e9cd4751d5a");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "e09087cd-5ae5-4e27-aa71-044ad0a909c1");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "e4878983-1ae7-4a71-bc99-ed5fc553656f");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "e6bbb354-68dd-40f5-8e64-4ed74c552ed5");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "ec1afb29-3592-4004-b08b-8e773ef0d272");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "efeed228-222a-4ac2-953d-efd32eb0d85f");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "f2d0b8d5-2a87-4ad8-ade9-788d110e7cae");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "f4ac4031-3ab4-4598-9b2a-b1b3ada80b77");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "f77d63d6-18ca-4775-bf92-2bb16e0703ed");

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: "fbfdbb80-4a46-4700-8ba9-bd9a89329eff");

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: "471e6bd8-a175-449a-9626-b4bbe17d2729");

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: "ab4317bb-7b09-4c5d-a655-334a59b5a821");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "139dc314-c48d-4713-86ad-b51f83daed0c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "354f07d6-112a-4f7e-ba82-cd8bc0cefddf");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "376cebea-4428-4746-8376-2055cd19c285");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "419ea699-6f65-4918-9aa6-183bf61f3ab2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "446d4499-bd54-46e1-b93f-45b7e38101e1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "60300f7c-2afd-4309-882e-0e821bfbfed0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "6fbc53ee-78f0-4f73-a7f7-ec42084e1a2c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "749ca424-9791-4693-a85a-0e1c955ac5f9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "7d45aa39-b7fe-408d-b606-2729cc45929b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "80a14e57-b9a4-47e9-9144-627e5b1668ee");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "8d8bea9a-7125-49ec-99e9-1596eb1058f8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "8fc1ddfe-4880-4ff8-b265-0e6f57afc1c1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9bb6c949-1bea-48a6-94a0-f2c4b1614b81");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "a10023f7-a765-4782-bc89-4891c2bc90dd");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "a3cfcdda-639b-4342-b8af-22e9c907ff83");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "a73606f5-d76a-46d8-91bb-9737dec3064c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "c0750072-426c-44cd-92d7-39bd02c71cf0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "d6981c48-11c1-41d6-be9e-cf2a60dda2c6");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "e2d9cf0c-baa4-464b-9071-17db23fc3557");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "e5db32f1-4e3a-489e-b22f-c4b2c415949f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "e8cff779-7531-41da-add2-635dac60d139");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "fc9d65bd-7e00-4242-9bf8-39b83736a79f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ff2d5ebc-7a8f-467b-a983-357f33693840");

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
        }
    }
}
