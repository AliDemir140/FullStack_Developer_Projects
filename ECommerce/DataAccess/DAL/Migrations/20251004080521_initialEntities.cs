using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initialEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipperName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipperId = table.Column<int>(type: "int", nullable: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Shippers_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shippers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "ComputerName", "CreatedDate", "Description", "IpAddress", "MasterId", "ModifiedComputerName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Automotive", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 494, DateTimeKind.Local).AddTicks(8623), "architecto", "10.3.29.230", new Guid("e6c250fb-b882-4289-aec1-8ab267d4db1d"), null, null, 1 },
                    { 2, "Grocery", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 495, DateTimeKind.Local).AddTicks(4362), "officia", "10.3.29.230", new Guid("130619b7-0c32-4d7b-ba9d-022367328205"), null, null, 1 },
                    { 3, "Music", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 495, DateTimeKind.Local).AddTicks(8385), "omnis", "10.3.29.230", new Guid("21fc3310-d30c-4e42-9817-6e6f3945d2de"), null, null, 1 },
                    { 4, "Toys", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 496, DateTimeKind.Local).AddTicks(2125), "qui", "10.3.29.230", new Guid("d59fae83-2da4-49fa-9787-94613a96c015"), null, null, 1 },
                    { 5, "Kids", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 496, DateTimeKind.Local).AddTicks(5901), "quis", "10.3.29.230", new Guid("f0e1b770-280e-4e5a-b988-b77f5510b763"), null, null, 1 },
                    { 6, "Baby", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 496, DateTimeKind.Local).AddTicks(9716), "quis", "10.3.29.230", new Guid("2eec7361-716a-4087-8c6a-1aca96af4384"), null, null, 1 },
                    { 7, "Movies", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 497, DateTimeKind.Local).AddTicks(3489), "earum", "10.3.29.230", new Guid("fe1eb9cf-6aa4-43d8-8bba-3299897ff635"), null, null, 1 },
                    { 8, "Computers", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 497, DateTimeKind.Local).AddTicks(7190), "excepturi", "10.3.29.230", new Guid("9e5f25a7-085f-4dec-a221-a853ad4777d1"), null, null, 1 },
                    { 9, "Movies", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 498, DateTimeKind.Local).AddTicks(774), "possimus", "10.3.29.230", new Guid("71e76223-4692-4d74-8fda-70b80a9d5e00"), null, null, 1 },
                    { 10, "Shoes", "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 498, DateTimeKind.Local).AddTicks(4337), "nemo", "10.3.29.230", new Guid("2a7d4f3e-937b-48c5-9099-9d0b87cc916e"), null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "ID", "ComputerName", "ContactInfo", "CreatedDate", "IpAddress", "IsActive", "MasterId", "ModifiedComputerName", "ModifiedDate", "ShipperName", "Status" },
                values: new object[,]
                {
                    { 1, "DESKTOP-J4PTH70", "0850 222 0 606", new DateTime(2025, 10, 4, 11, 5, 21, 542, DateTimeKind.Local).AddTicks(8582), "10.3.29.230", true, new Guid("0495d6bd-635f-4d1e-b4ae-b9149b1c5f4a"), null, null, "MNG Kargo", 1 },
                    { 2, "DESKTOP-J4PTH70", "444 99 99", new DateTime(2025, 10, 4, 11, 5, 21, 543, DateTimeKind.Local).AddTicks(2573), "10.3.29.230", true, new Guid("d0a0396d-8b14-44e8-adcb-cfd7fa65b4dc"), null, null, "Yurtiçi Kargo", 1 },
                    { 3, "DESKTOP-J4PTH70", "444 25 52", new DateTime(2025, 10, 4, 11, 5, 21, 543, DateTimeKind.Local).AddTicks(6409), "10.3.29.230", true, new Guid("d99901fe-9c03-4b2c-8440-477e433f4422"), null, null, "Aras Kargo", 1 },
                    { 4, "DESKTOP-J4PTH70", "444 1 788", new DateTime(2025, 10, 4, 11, 5, 21, 544, DateTimeKind.Local).AddTicks(25), "10.3.29.230", true, new Guid("c2f5d629-01d1-4544-869d-46982288bff8"), null, null, "PTT Kargo", 1 },
                    { 5, "DESKTOP-J4PTH70", "444 0 078", new DateTime(2025, 10, 4, 11, 5, 21, 544, DateTimeKind.Local).AddTicks(3755), "10.3.29.230", true, new Guid("89e4da50-12c4-48f9-bbad-d91b6dccc7ab"), null, null, "Sürat Kargo", 1 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "City", "CompanyName", "ComputerName", "ContactName", "ContactTitle", "Country", "CreatedDate", "IpAddress", "IsActive", "MasterId", "ModifiedComputerName", "ModifiedDate", "Phone", "Status" },
                values: new object[,]
                {
                    { 1, "14272 Botsford Mission", "Nonachester", "Fay and Sons", "DESKTOP-J4PTH70", "Noah Fisher", "Dynamic Paradigm Manager", "Yemen", new DateTime(2025, 10, 4, 11, 5, 21, 547, DateTimeKind.Local).AddTicks(6348), "10.3.29.230", true, new Guid("8636facb-890f-4996-a6d7-c72ce3c240e3"), null, null, "452.537.8310", 1 },
                    { 2, "519 Ramiro Mews", "Dionland", "Donnelly Group", "DESKTOP-J4PTH70", "Isabell Ullrich", "Regional Interactions Analyst", "Taiwan", new DateTime(2025, 10, 4, 11, 5, 21, 548, DateTimeKind.Local).AddTicks(1053), "10.3.29.230", true, new Guid("5cf677bc-8b6e-4360-9eec-dfe5dd1c4a19"), null, null, "834.870.7605 x95773", 1 },
                    { 3, "09660 Witting Junctions", "O'Keefestad", "Lesch, Yundt and Hane", "DESKTOP-J4PTH70", "Lydia O'Kon", "Global Accounts Coordinator", "Armenia", new DateTime(2025, 10, 4, 11, 5, 21, 548, DateTimeKind.Local).AddTicks(5799), "10.3.29.230", true, new Guid("266ccf02-699b-4c49-8b83-59ff328ee0e9"), null, null, "1-348-768-4842", 1 },
                    { 4, "482 Norbert Loaf", "Bogisichport", "Auer - Goldner", "DESKTOP-J4PTH70", "Margret Bradtke", "Global Web Consultant", "Malaysia", new DateTime(2025, 10, 4, 11, 5, 21, 549, DateTimeKind.Local).AddTicks(447), "10.3.29.230", true, new Guid("b6980c83-a4c5-4f3b-968e-36f005652ace"), null, null, "1-740-554-3725", 1 },
                    { 5, "1886 Langosh Rapid", "West Robertoside", "Gorczany, Goldner and Stamm", "DESKTOP-J4PTH70", "Alisha Ullrich", "Corporate Identity Designer", "Angola", new DateTime(2025, 10, 4, 11, 5, 21, 549, DateTimeKind.Local).AddTicks(5102), "10.3.29.230", true, new Guid("08a18317-2743-4959-994e-fc581d77d213"), null, null, "1-789-548-5575", 1 },
                    { 6, "42283 Krystina Plaza", "Barrowsmouth", "Barton - Lueilwitz", "DESKTOP-J4PTH70", "David Mann", "District Research Developer", "Panama", new DateTime(2025, 10, 4, 11, 5, 21, 549, DateTimeKind.Local).AddTicks(9797), "10.3.29.230", true, new Guid("0021716f-cf85-495e-b5bf-3f66aed21503"), null, null, "1-285-695-8486 x93238", 1 },
                    { 7, "624 O'Kon Stravenue", "Marcelofurt", "Wolff - Walsh", "DESKTOP-J4PTH70", "Ewell Reynolds", "Global Functionality Analyst", "Denmark", new DateTime(2025, 10, 4, 11, 5, 21, 550, DateTimeKind.Local).AddTicks(4825), "10.3.29.230", true, new Guid("e024d6d3-ef53-452c-aae3-3b933e8b17fa"), null, null, "(933) 511-0539", 1 },
                    { 8, "21949 Mitchell Plains", "South Clemens", "White - Kohler", "DESKTOP-J4PTH70", "Reva Strosin", "Customer Infrastructure Director", "Liechtenstein", new DateTime(2025, 10, 4, 11, 5, 21, 550, DateTimeKind.Local).AddTicks(9532), "10.3.29.230", true, new Guid("34710f2e-5f51-4791-8b67-e75f1229194f"), null, null, "787.948.1530", 1 },
                    { 9, "8522 Larson Heights", "Macejkovicberg", "Nikolaus Group", "DESKTOP-J4PTH70", "Alyson Cassin", "Legacy Quality Agent", "Lithuania", new DateTime(2025, 10, 4, 11, 5, 21, 551, DateTimeKind.Local).AddTicks(4329), "10.3.29.230", true, new Guid("963a5478-d4f5-4eb5-aac5-e9273b784ee9"), null, null, "313-624-8834 x890", 1 },
                    { 10, "6624 Jazmyne Creek", "Abelardofort", "Considine - Rempel", "DESKTOP-J4PTH70", "Kenya Huels", "Lead Operations Analyst", "Belarus", new DateTime(2025, 10, 4, 11, 5, 21, 551, DateTimeKind.Local).AddTicks(9163), "10.3.29.230", true, new Guid("ef6f7741-a01a-4b34-98d2-eb98ccd45676"), null, null, "571-623-1513 x11619", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "ComputerName", "CreatedDate", "Description", "IpAddress", "MasterId", "ModifiedComputerName", "ModifiedDate", "Price", "ProductName", "Status", "Stock", "SupplierId" },
                values: new object[,]
                {
                    { 1, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 501, DateTimeKind.Local).AddTicks(6542), "İusto beatae dolores nemo aut.", "10.3.29.230", new Guid("bdf3081a-e3f5-41d9-99ee-3760f6e05dbc"), null, null, 219.07m, "Unbranded Wooden Pizza", 1, 73, 1 },
                    { 2, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 502, DateTimeKind.Local).AddTicks(720), "Laborum est voluptatem omnis sint.", "10.3.29.230", new Guid("385083d5-70d1-411c-8917-e0ab6bba49ab"), null, null, 514.85m, "Handcrafted Concrete Gloves", 1, 37, 1 },
                    { 3, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 502, DateTimeKind.Local).AddTicks(4690), "İpsum quas aut dolorum beatae.", "10.3.29.230", new Guid("68399674-d500-49d3-b147-a02185dc98f5"), null, null, 730.89m, "Practical Plastic Chicken", 1, 35, 1 },
                    { 4, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 502, DateTimeKind.Local).AddTicks(8501), "Unde sed tempora commodi soluta.", "10.3.29.230", new Guid("c5bcb42e-834d-4836-b390-e7b5822d6bac"), null, null, 423.02m, "Sleek Metal Gloves", 1, 24, 1 },
                    { 5, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 503, DateTimeKind.Local).AddTicks(2505), "Corrupti aperiam numquam culpa alias.", "10.3.29.230", new Guid("ea92470e-e86f-49fc-b90a-44a580a6fba0"), null, null, 16.60m, "Refined Granite Cheese", 1, 1, 1 },
                    { 6, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 503, DateTimeKind.Local).AddTicks(6495), "Dolores exercitationem provident sunt velit.", "10.3.29.230", new Guid("a54eadeb-9198-4f62-8026-24df33da8601"), null, null, 71.75m, "Unbranded Frozen Ball", 1, 72, 1 },
                    { 7, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 504, DateTimeKind.Local).AddTicks(423), "Facilis non velit expedita id.", "10.3.29.230", new Guid("5e08bf5e-501b-407e-a5bc-209acb2f08de"), null, null, 640.08m, "Fantastic Metal Chips", 1, 15, 1 },
                    { 8, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 504, DateTimeKind.Local).AddTicks(4241), "Deserunt laborum molestias voluptates architecto.", "10.3.29.230", new Guid("64e3ded3-ca38-4df2-b7e7-897c2359551f"), null, null, 720.02m, "Rustic Concrete Chips", 1, 31, 1 },
                    { 9, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 504, DateTimeKind.Local).AddTicks(8041), "Vel facere ut nemo totam.", "10.3.29.230", new Guid("9a971ec4-da43-4779-b476-f3caf6889c3e"), null, null, 487.03m, "Small Granite Tuna", 1, 86, 1 },
                    { 10, 1, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 505, DateTimeKind.Local).AddTicks(1766), "Quia dolores doloremque quia non.", "10.3.29.230", new Guid("035bf77c-77d8-4c33-bf3c-8c9410f9b385"), null, null, 660.67m, "Handmade Concrete Keyboard", 1, 3, 1 },
                    { 11, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 505, DateTimeKind.Local).AddTicks(5886), "Consectetur doloremque in dolores et.", "10.3.29.230", new Guid("91359bb3-8d8b-4e36-addf-2d3e0c2fc446"), null, null, 103.50m, "Tasty Metal Pants", 1, 78, 2 },
                    { 12, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 505, DateTimeKind.Local).AddTicks(9661), "Officiis voluptas nihil sapiente maxime.", "10.3.29.230", new Guid("f9b1668e-d5d1-49fa-bbc0-8e00a49eafcc"), null, null, 889.16m, "Tasty Metal Soap", 1, 11, 2 },
                    { 13, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 506, DateTimeKind.Local).AddTicks(3399), "İste suscipit excepturi quis sint.", "10.3.29.230", new Guid("45310819-1736-4346-ba52-61e74c168fa1"), null, null, 486.81m, "Rustic Wooden Gloves", 1, 50, 2 },
                    { 14, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 506, DateTimeKind.Local).AddTicks(7221), "İusto ratione perspiciatis magni accusantium.", "10.3.29.230", new Guid("09f6106c-a0b3-4ee5-a7ce-4fd8b7638a60"), null, null, 232.00m, "Refined Soft Chicken", 1, 40, 2 },
                    { 15, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 507, DateTimeKind.Local).AddTicks(936), "Minima dolores vel animi voluptatem.", "10.3.29.230", new Guid("4c1e0972-1385-49d1-9891-939ee305dfce"), null, null, 831.44m, "Handcrafted Plastic Car", 1, 10, 2 },
                    { 16, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 507, DateTimeKind.Local).AddTicks(4930), "Possimus ut id omnis quibusdam.", "10.3.29.230", new Guid("3a227249-0648-4661-802b-b6a6201ddf3b"), null, null, 870.13m, "Fantastic Plastic Pizza", 1, 60, 2 },
                    { 17, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 507, DateTimeKind.Local).AddTicks(8777), "Sed voluptatibus voluptas nihil itaque.", "10.3.29.230", new Guid("47ab5413-2938-452f-b016-a46bc0c88013"), null, null, 827.60m, "Small Plastic Shirt", 1, 47, 2 },
                    { 18, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 508, DateTimeKind.Local).AddTicks(2551), "İpsum aut dicta autem rerum.", "10.3.29.230", new Guid("8681517e-33da-4714-803a-3b06f1dbebbe"), null, null, 644.79m, "Generic Granite Chair", 1, 1, 2 },
                    { 19, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 508, DateTimeKind.Local).AddTicks(6468), "Autem pariatur ullam harum incidunt.", "10.3.29.230", new Guid("7c6e77da-41fa-4614-8bfb-6e91bc75c02e"), null, null, 660.80m, "Ergonomic Metal Hat", 1, 11, 2 },
                    { 20, 2, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 509, DateTimeKind.Local).AddTicks(246), "İn error dolores dolorem dolor.", "10.3.29.230", new Guid("cf6a758d-a636-4a5a-b18b-2f47454b078b"), null, null, 906.70m, "Refined Cotton Fish", 1, 79, 2 },
                    { 21, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 509, DateTimeKind.Local).AddTicks(4344), "Eos inventore omnis dolorem quaerat.", "10.3.29.230", new Guid("1707a701-0f51-4b9a-9070-ccc854ccc134"), null, null, 970.68m, "Generic Metal Bacon", 1, 42, 3 },
                    { 22, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 509, DateTimeKind.Local).AddTicks(8188), "Reprehenderit ipsam repudiandae illo esse.", "10.3.29.230", new Guid("975d9d32-a62a-4d5e-8171-29083b105be2"), null, null, 469.67m, "Awesome Plastic Cheese", 1, 81, 3 },
                    { 23, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 510, DateTimeKind.Local).AddTicks(2113), "Eos architecto est voluptatibus voluptatibus.", "10.3.29.230", new Guid("cb3afa4d-6b99-4148-818e-19e48f50ad75"), null, null, 174.23m, "Fantastic Fresh Bike", 1, 5, 3 },
                    { 24, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 510, DateTimeKind.Local).AddTicks(5861), "Sed pariatur ut minima commodi.", "10.3.29.230", new Guid("0422d110-cabf-43a3-afc7-ed685f8f025a"), null, null, 98.27m, "Small Fresh Shoes", 1, 27, 3 },
                    { 25, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 510, DateTimeKind.Local).AddTicks(9589), "Veritatis atque beatae sed ea.", "10.3.29.230", new Guid("fb6b5a17-5c70-45e0-9dd9-c64947c71547"), null, null, 930.92m, "Practical Steel Hat", 1, 44, 3 },
                    { 26, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 511, DateTimeKind.Local).AddTicks(3850), "İncidunt molestiae quibusdam et laboriosam.", "10.3.29.230", new Guid("6d55aa6b-3a7a-4588-9c7b-0f59c0ca10ea"), null, null, 459.22m, "Awesome Granite Soap", 1, 64, 3 },
                    { 27, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 511, DateTimeKind.Local).AddTicks(7731), "Eum numquam rem ut explicabo.", "10.3.29.230", new Guid("134df165-4d59-4017-bbc4-e13478a9f745"), null, null, 756.99m, "Licensed Frozen Tuna", 1, 6, 3 },
                    { 28, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 512, DateTimeKind.Local).AddTicks(1520), "Quia qui expedita accusamus repellat.", "10.3.29.230", new Guid("a68f2b03-e411-4d11-8871-1ef7c83137cc"), null, null, 709.35m, "Intelligent Fresh Chicken", 1, 81, 3 },
                    { 29, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 512, DateTimeKind.Local).AddTicks(5453), "İste autem totam minus adipisci.", "10.3.29.230", new Guid("19253d88-eb8e-47db-bfd3-8cfebc56c71e"), null, null, 968.46m, "Refined Frozen Chicken", 1, 46, 3 },
                    { 30, 3, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 512, DateTimeKind.Local).AddTicks(9303), "Magni sed excepturi animi sit.", "10.3.29.230", new Guid("611e6c1f-cf17-42cb-aedc-2ba4c818a8d4"), null, null, 951.14m, "Tasty Metal Gloves", 1, 7, 3 },
                    { 31, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 513, DateTimeKind.Local).AddTicks(3324), "Fugiat sunt eveniet aut dolorum.", "10.3.29.230", new Guid("72c81ee0-1298-43bf-b404-1de5063699ba"), null, null, 113.38m, "Generic Soft Chips", 1, 59, 4 },
                    { 32, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 513, DateTimeKind.Local).AddTicks(7118), "Cum nihil assumenda eum omnis.", "10.3.29.230", new Guid("d1c1d020-1ced-4831-ae42-cdef689e773e"), null, null, 996.18m, "Practical Wooden Gloves", 1, 91, 4 },
                    { 33, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 514, DateTimeKind.Local).AddTicks(928), "Et reprehenderit quia ut qui.", "10.3.29.230", new Guid("09b41c4f-58a7-49e3-9389-1acf46ccdc65"), null, null, 328.94m, "Incredible Rubber Ball", 1, 12, 4 },
                    { 34, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 514, DateTimeKind.Local).AddTicks(4674), "Adipisci illo et sed voluptas.", "10.3.29.230", new Guid("15cf1c6d-4278-49f2-b08c-2de40871ad24"), null, null, 717.06m, "Tasty Metal Gloves", 1, 43, 4 },
                    { 35, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 514, DateTimeKind.Local).AddTicks(8388), "Tempore aut illo numquam quia.", "10.3.29.230", new Guid("eb1e99d1-3f19-43f0-8192-345da005add2"), null, null, 297.38m, "Gorgeous Steel Cheese", 1, 99, 4 },
                    { 36, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 515, DateTimeKind.Local).AddTicks(2264), "Omnis est omnis in pariatur.", "10.3.29.230", new Guid("e1bd0574-81f0-4a77-b7cb-66a1432f3f4c"), null, null, 117.80m, "Licensed Cotton Chicken", 1, 12, 4 },
                    { 37, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 515, DateTimeKind.Local).AddTicks(6191), "Ut nihil illum dolor tempore.", "10.3.29.230", new Guid("f53783a3-c9d1-4fb1-8621-9f66fcc3519a"), null, null, 102.73m, "Sleek Metal Chicken", 1, 2, 4 },
                    { 38, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 515, DateTimeKind.Local).AddTicks(9901), "Recusandae quod assumenda eos beatae.", "10.3.29.230", new Guid("62f7dbcc-91d9-4aa9-850a-615e77f8955e"), null, null, 839.54m, "Generic Wooden Cheese", 1, 84, 4 },
                    { 39, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 516, DateTimeKind.Local).AddTicks(3777), "Ab vitae eveniet quaerat sed.", "10.3.29.230", new Guid("0e55fe5e-5a41-45f8-a235-1df18672019a"), null, null, 930.21m, "Ergonomic Fresh Chicken", 1, 71, 4 },
                    { 40, 4, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 516, DateTimeKind.Local).AddTicks(7510), "Quis in iure quasi illo.", "10.3.29.230", new Guid("9b41d38f-5f28-4034-99d2-695708d28cfe"), null, null, 818.40m, "Sleek Metal Bacon", 1, 4, 4 },
                    { 41, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 517, DateTimeKind.Local).AddTicks(1345), "Est placeat et eius ipsa.", "10.3.29.230", new Guid("f8c046aa-e5f0-4a57-8710-ee4db54ab83e"), null, null, 377.80m, "Rustic Granite Gloves", 1, 63, 5 },
                    { 42, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 517, DateTimeKind.Local).AddTicks(5293), "Accusamus quibusdam dolore a illum.", "10.3.29.230", new Guid("cc18cdfd-77e4-4f0f-a695-f389747e6f5c"), null, null, 574.45m, "Handcrafted Wooden Ball", 1, 41, 5 },
                    { 43, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 517, DateTimeKind.Local).AddTicks(9014), "Repellendus et at molestiae ab.", "10.3.29.230", new Guid("d4d096a8-36b6-445c-b660-b21cffa17bc7"), null, null, 195.57m, "Incredible Granite Cheese", 1, 60, 5 },
                    { 44, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 518, DateTimeKind.Local).AddTicks(2793), "Dolor nam iusto inventore sed.", "10.3.29.230", new Guid("cbefd60d-5361-4055-bb55-7a75ef9173a3"), null, null, 396.29m, "Handcrafted Rubber Mouse", 1, 36, 5 },
                    { 45, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 518, DateTimeKind.Local).AddTicks(6533), "Quis consequatur nostrum aperiam corrupti.", "10.3.29.230", new Guid("c6341343-c383-4115-8e2e-0bbdffcd4c03"), null, null, 889.76m, "Tasty Cotton Pants", 1, 92, 5 },
                    { 46, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 519, DateTimeKind.Local).AddTicks(262), "Officia ut est dolor est.", "10.3.29.230", new Guid("dc7580f7-2749-4643-b0f9-995d7611cbad"), null, null, 350.17m, "Licensed Soft Chips", 1, 33, 5 },
                    { 47, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 519, DateTimeKind.Local).AddTicks(4324), "Corrupti ipsum voluptatem vero et.", "10.3.29.230", new Guid("fd1bd6e8-120c-4461-ab04-5d88508cd2ac"), null, null, 692.79m, "Sleek Frozen Car", 1, 1, 5 },
                    { 48, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 519, DateTimeKind.Local).AddTicks(8027), "İpsum hic molestiae aut in.", "10.3.29.230", new Guid("80cf8b43-a99a-4321-b722-c135247b3893"), null, null, 43.63m, "Awesome Cotton Hat", 1, 81, 5 },
                    { 49, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 520, DateTimeKind.Local).AddTicks(1714), "Voluptates molestiae tenetur ea repellat.", "10.3.29.230", new Guid("080b181b-c29c-4ac9-b2d3-1d287a1eb592"), null, null, 513.27m, "Handcrafted Wooden Cheese", 1, 13, 5 },
                    { 50, 5, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 520, DateTimeKind.Local).AddTicks(5539), "İd neque necessitatibus et eum.", "10.3.29.230", new Guid("7cb2314c-51ee-46c8-b45c-244fe7f7dace"), null, null, 196.21m, "Awesome Soft Salad", 1, 82, 5 },
                    { 51, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 520, DateTimeKind.Local).AddTicks(9240), "Architecto placeat numquam repellendus ut.", "10.3.29.230", new Guid("0ec6479d-8c81-43f6-a764-159d844d62e8"), null, null, 270.02m, "Refined Rubber Sausages", 1, 68, 6 },
                    { 52, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 521, DateTimeKind.Local).AddTicks(3340), "Perferendis sapiente reprehenderit animi nobis.", "10.3.29.230", new Guid("cc65960e-d248-4b68-9538-4375ce574d34"), null, null, 390.36m, "Unbranded Wooden Pants", 1, 5, 6 },
                    { 53, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 521, DateTimeKind.Local).AddTicks(7198), "İn maxime quos sapiente beatae.", "10.3.29.230", new Guid("a5e2e9d3-2693-4ca1-a39a-df71d1882a7c"), null, null, 523.32m, "Awesome Granite Ball", 1, 58, 6 },
                    { 54, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 522, DateTimeKind.Local).AddTicks(983), "Qui delectus nostrum sunt blanditiis.", "10.3.29.230", new Guid("463ea829-82bc-4590-8746-d326e7148d1a"), null, null, 631.40m, "Unbranded Fresh Sausages", 1, 71, 6 },
                    { 55, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 522, DateTimeKind.Local).AddTicks(4763), "Perferendis molestias quidem sequi quia.", "10.3.29.230", new Guid("7b7d3304-1930-42a0-9009-442463f666d1"), null, null, 242.33m, "Handcrafted Steel Ball", 1, 72, 6 },
                    { 56, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 522, DateTimeKind.Local).AddTicks(8621), "Et natus quo veniam aut.", "10.3.29.230", new Guid("ba3322db-5a26-4853-a982-46094907a897"), null, null, 607.18m, "Gorgeous Cotton Chair", 1, 95, 6 },
                    { 57, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 523, DateTimeKind.Local).AddTicks(2639), "Totam dolorem repellat rem qui.", "10.3.29.230", new Guid("e8f160bb-d3a3-4383-bd10-fa863128de8e"), null, null, 732.16m, "Sleek Steel Bike", 1, 55, 6 },
                    { 58, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 523, DateTimeKind.Local).AddTicks(6472), "İpsum rerum quod perspiciatis tempora.", "10.3.29.230", new Guid("f5d8bdff-0110-445d-8176-2cb26d306a3b"), null, null, 467.80m, "Handmade Frozen Salad", 1, 33, 6 },
                    { 59, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 524, DateTimeKind.Local).AddTicks(1488), "Ut quae quo commodi dolor.", "10.3.29.230", new Guid("da49973d-de26-4d88-a7ac-e01faa12f1f5"), null, null, 377.75m, "Fantastic Fresh Ball", 1, 100, 6 },
                    { 60, 6, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 524, DateTimeKind.Local).AddTicks(6017), "Reiciendis enim aliquid atque et.", "10.3.29.230", new Guid("7d0a125f-8c70-467c-8f23-b7916b150a4b"), null, null, 265.34m, "Refined Concrete Chips", 1, 45, 6 },
                    { 61, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 524, DateTimeKind.Local).AddTicks(9953), "Esse deserunt qui architecto magnam.", "10.3.29.230", new Guid("002dad70-d02c-4b9d-bb7a-ca4fea468cee"), null, null, 327.37m, "Practical Cotton Soap", 1, 38, 7 },
                    { 62, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 525, DateTimeKind.Local).AddTicks(4273), "Quam tenetur qui praesentium explicabo.", "10.3.29.230", new Guid("019e5bfb-9129-4abc-84e1-f88823aa3745"), null, null, 638.17m, "Awesome Soft Tuna", 1, 100, 7 },
                    { 63, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 525, DateTimeKind.Local).AddTicks(8466), "Voluptas laboriosam et rerum et.", "10.3.29.230", new Guid("7651be6f-92e6-41c5-8f9a-606f06c1f54d"), null, null, 938.48m, "Tasty Soft Fish", 1, 76, 7 },
                    { 64, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 526, DateTimeKind.Local).AddTicks(3770), "Laudantium reiciendis facere ratione esse.", "10.3.29.230", new Guid("42848e9c-2cc6-40e2-896a-03b34fee694a"), null, null, 600.97m, "Gorgeous Plastic Sausages", 1, 22, 7 },
                    { 65, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 526, DateTimeKind.Local).AddTicks(8148), "Amet asperiores autem in ex.", "10.3.29.230", new Guid("287b9cc5-0ac2-4da3-9c6c-33f2759401a8"), null, null, 232.18m, "Unbranded Rubber Bacon", 1, 71, 7 },
                    { 66, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 527, DateTimeKind.Local).AddTicks(4276), "Quis dolorum unde aliquam vel.", "10.3.29.230", new Guid("ffc7ac39-4486-46cb-add3-91c1de17adca"), null, null, 984.38m, "Unbranded Cotton Shoes", 1, 58, 7 },
                    { 67, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 527, DateTimeKind.Local).AddTicks(9725), "Vero id eaque iure qui.", "10.3.29.230", new Guid("e6bd1a2e-078b-4449-9701-39085c07016e"), null, null, 405.44m, "Handcrafted Steel Computer", 1, 67, 7 },
                    { 68, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 528, DateTimeKind.Local).AddTicks(3770), "Temporibus et sint iste possimus.", "10.3.29.230", new Guid("04370926-0d3a-4a33-8667-43af00cedbaf"), null, null, 437.60m, "Awesome Rubber Bike", 1, 23, 7 },
                    { 69, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 528, DateTimeKind.Local).AddTicks(7744), "Sed at est sed velit.", "10.3.29.230", new Guid("6fc5a728-91f5-4def-9fa1-e567940e7d60"), null, null, 356.64m, "Generic Cotton Pants", 1, 12, 7 },
                    { 70, 7, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 529, DateTimeKind.Local).AddTicks(1619), "Voluptate nesciunt natus porro iure.", "10.3.29.230", new Guid("497b0e91-f666-45d7-8d58-b163009a9196"), null, null, 27.53m, "Refined Soft Salad", 1, 59, 7 },
                    { 71, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 529, DateTimeKind.Local).AddTicks(5388), "Quidem sequi quae beatae id.", "10.3.29.230", new Guid("2ae972b4-769a-4448-83e9-41afc5158ca9"), null, null, 22.83m, "Gorgeous Plastic Bacon", 1, 51, 8 },
                    { 72, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 529, DateTimeKind.Local).AddTicks(9406), "Et in aut dignissimos quo.", "10.3.29.230", new Guid("19b5c8fb-ddd4-4bde-af91-4f1d582088f2"), null, null, 77.05m, "Refined Soft Car", 1, 9, 8 },
                    { 73, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 530, DateTimeKind.Local).AddTicks(3190), "Et magni rerum dolore et.", "10.3.29.230", new Guid("d2a9620f-13f6-4982-b66a-9a224491672d"), null, null, 102.84m, "Incredible Cotton Sausages", 1, 49, 8 },
                    { 74, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 530, DateTimeKind.Local).AddTicks(6967), "Reiciendis assumenda voluptate ipsam minima.", "10.3.29.230", new Guid("9ae6e61f-6f35-4748-826e-d795fcafb84a"), null, null, 160.69m, "Handmade Rubber Pants", 1, 43, 8 },
                    { 75, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 531, DateTimeKind.Local).AddTicks(848), "Dolor hic iusto nostrum accusantium.", "10.3.29.230", new Guid("ef94853a-feb9-4308-97c0-d74f60fe55d7"), null, null, 685.79m, "Intelligent Rubber Bacon", 1, 28, 8 },
                    { 76, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 531, DateTimeKind.Local).AddTicks(4924), "Sint consequatur tempore eum fuga.", "10.3.29.230", new Guid("79eaa152-72c6-4af3-8a45-6565f8c628c2"), null, null, 220.42m, "Sleek Wooden Salad", 1, 16, 8 },
                    { 77, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 531, DateTimeKind.Local).AddTicks(8824), "Culpa iste sequi qui numquam.", "10.3.29.230", new Guid("1d6b10c9-f8c9-49b1-8751-dcf76c811633"), null, null, 830.33m, "Tasty Fresh Salad", 1, 61, 8 },
                    { 78, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 532, DateTimeKind.Local).AddTicks(2562), "Et adipisci quas esse minima.", "10.3.29.230", new Guid("a4371ad4-1fa1-4eae-830d-a109241c0443"), null, null, 43.74m, "Awesome Rubber Pants", 1, 96, 8 },
                    { 79, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 532, DateTimeKind.Local).AddTicks(6526), "Cumque eaque excepturi tenetur quia.", "10.3.29.230", new Guid("e486a212-4357-47c9-9af9-2e1185c3a4ea"), null, null, 864.53m, "Generic Plastic Soap", 1, 77, 8 },
                    { 80, 8, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 533, DateTimeKind.Local).AddTicks(280), "Officia repellendus est hic velit.", "10.3.29.230", new Guid("481ef8b0-11f6-4a91-b145-63a2c962cdef"), null, null, 782.64m, "Ergonomic Rubber Computer", 1, 48, 8 },
                    { 81, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 533, DateTimeKind.Local).AddTicks(4221), "Optio at velit quia aut.", "10.3.29.230", new Guid("016e0cc5-cbf9-4d8f-b9e4-4a3c2aa31031"), null, null, 935.77m, "Practical Cotton Chicken", 1, 88, 9 },
                    { 82, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 533, DateTimeKind.Local).AddTicks(8170), "Aperiam possimus ut ut accusantium.", "10.3.29.230", new Guid("db9146bc-7833-4384-8815-a288469ff9e5"), null, null, 703.12m, "Fantastic Steel Cheese", 1, 57, 9 },
                    { 83, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 534, DateTimeKind.Local).AddTicks(1944), "Est voluptatem autem at accusamus.", "10.3.29.230", new Guid("c7482eec-e936-4577-b816-6c6093e3cd3a"), null, null, 724.05m, "Awesome Cotton Mouse", 1, 21, 9 },
                    { 84, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 534, DateTimeKind.Local).AddTicks(5821), "Rem ut quia sint nulla.", "10.3.29.230", new Guid("52cfd152-f0b3-475d-8398-08366087071e"), null, null, 212.11m, "Sleek Rubber Towels", 1, 68, 9 },
                    { 85, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 534, DateTimeKind.Local).AddTicks(9538), "Tenetur eos deserunt cumque ratione.", "10.3.29.230", new Guid("c54aab7d-b62b-4bb7-8236-8e790b14fee2"), null, null, 693.35m, "Unbranded Metal Chair", 1, 36, 9 },
                    { 86, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 535, DateTimeKind.Local).AddTicks(3346), "Quasi possimus ut suscipit perspiciatis.", "10.3.29.230", new Guid("95115140-3367-496c-9e4e-f8ed13b3b4c7"), null, null, 420.08m, "Practical Soft Computer", 1, 66, 9 },
                    { 87, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 535, DateTimeKind.Local).AddTicks(7126), "Quia aut rerum illo ipsum.", "10.3.29.230", new Guid("6e1afeb4-2882-409a-85d7-fa0bce448695"), null, null, 285.89m, "Incredible Cotton Shoes", 1, 60, 9 },
                    { 88, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 536, DateTimeKind.Local).AddTicks(1033), "Aspernatur omnis mollitia culpa sed.", "10.3.29.230", new Guid("0494f3c7-52d4-4729-80c0-3fd381855d0c"), null, null, 430.39m, "Ergonomic Fresh Bike", 1, 68, 9 },
                    { 89, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 536, DateTimeKind.Local).AddTicks(4854), "Et delectus optio officia ea.", "10.3.29.230", new Guid("4d62a3b6-e6ca-4f0f-a2dc-6e33941f032a"), null, null, 84.17m, "Rustic Cotton Car", 1, 61, 9 },
                    { 90, 9, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 536, DateTimeKind.Local).AddTicks(8728), "Mollitia saepe fugiat rerum aut.", "10.3.29.230", new Guid("6dcaf1e4-0409-4d61-94da-d771e0970503"), null, null, 408.78m, "Refined Wooden Pants", 1, 97, 9 },
                    { 91, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 537, DateTimeKind.Local).AddTicks(2455), "Eum laudantium deleniti et est.", "10.3.29.230", new Guid("d49e414a-725c-4fa4-a604-122ccc776f29"), null, null, 977.55m, "Fantastic Concrete Keyboard", 1, 24, 10 },
                    { 92, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 537, DateTimeKind.Local).AddTicks(6365), "Quaerat ea eligendi aspernatur molestiae.", "10.3.29.230", new Guid("1aa72cc6-c20b-40f1-bb3a-1fe269dc7851"), null, null, 496.02m, "Handcrafted Concrete Tuna", 1, 3, 10 },
                    { 93, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 538, DateTimeKind.Local).AddTicks(275), "At nisi porro non beatae.", "10.3.29.230", new Guid("88bfe07d-9d1a-4703-8f9a-0bd31ec1b0b9"), null, null, 895.41m, "Handmade Fresh Mouse", 1, 83, 10 },
                    { 94, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 538, DateTimeKind.Local).AddTicks(4103), "Ut quae eos nihil nam.", "10.3.29.230", new Guid("0dedcf7e-df71-43a2-b15d-b28e7fafc433"), null, null, 50.94m, "Licensed Wooden Keyboard", 1, 36, 10 },
                    { 95, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 538, DateTimeKind.Local).AddTicks(7812), "Reprehenderit dolores earum quidem corrupti.", "10.3.29.230", new Guid("dfc53a95-eb0f-4a7f-a39c-666defe711f7"), null, null, 41.00m, "Generic Metal Cheese", 1, 46, 10 },
                    { 96, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 539, DateTimeKind.Local).AddTicks(1516), "Quas autem eligendi reprehenderit ut.", "10.3.29.230", new Guid("12dbd5c7-5ef3-4712-af32-b5f7c831da94"), null, null, 577.37m, "Small Plastic Chair", 1, 72, 10 },
                    { 97, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 540, DateTimeKind.Local).AddTicks(2263), "Perferendis vel explicabo nobis qui.", "10.3.29.230", new Guid("1b4f7557-193b-41ef-810e-2b74b20b080d"), null, null, 103.65m, "Small Plastic Mouse", 1, 63, 10 },
                    { 98, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 540, DateTimeKind.Local).AddTicks(6510), "Eveniet atque libero neque voluptatem.", "10.3.29.230", new Guid("02856b3c-f7b8-4595-baff-bd9496c41047"), null, null, 633.24m, "Handcrafted Fresh Shoes", 1, 57, 10 },
                    { 99, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 541, DateTimeKind.Local).AddTicks(324), "Animi similique eligendi perspiciatis asperiores.", "10.3.29.230", new Guid("d890ee89-f971-4e1c-a494-aa2166b0a0c2"), null, null, 185.47m, "Small Fresh Shirt", 1, 9, 10 },
                    { 100, 10, "DESKTOP-J4PTH70", new DateTime(2025, 10, 4, 11, 5, 21, 541, DateTimeKind.Local).AddTicks(4327), "Ut non voluptatem et et.", "10.3.29.230", new Guid("94e74ca7-cfd9-4dad-afac-71ec68db6f66"), null, null, 339.27m, "Sleek Steel Table", 1, 44, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperId",
                table: "Orders",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        /// <inheritdoc />
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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
