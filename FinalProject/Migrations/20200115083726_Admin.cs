using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Text = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Advantage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advantage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Occupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 200, nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Surname = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Country = table.Column<int>(nullable: false),
                    StreetAdress = table.Column<string>(maxLength: 200, nullable: false),
                    Postalcode = table.Column<string>(maxLength: 200, nullable: false),
                    Age = table.Column<byte>(nullable: false),
                    HappyClient = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(maxLength: 200, nullable: false),
                    Answer = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 200, nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurVisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurVisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 200, nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 200, nullable: true),
                    SubTitle = table.Column<string>(maxLength: 200, nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    Text = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookLink = table.Column<string>(nullable: true),
                    TwitterLink = table.Column<string>(nullable: true),
                    InstagramLink = table.Column<string>(nullable: true),
                    GoogleLink = table.Column<string>(nullable: true),
                    LinkedInLink = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 200, nullable: false),
                    SupPhone = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SaleEmail = table.Column<string>(nullable: true),
                    MainAdress = table.Column<string>(maxLength: 200, nullable: false),
                    Adress = table.Column<string>(maxLength: 200, nullable: false),
                    Logo = table.Column<string>(maxLength: 200, nullable: false),
                    FooterLogo = table.Column<string>(maxLength: 200, nullable: false),
                    FooterText = table.Column<string>(maxLength: 200, nullable: false),
                    Payment = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 200, nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Position = table.Column<string>(maxLength: 200, nullable: false),
                    FacebookLink = table.Column<string>(maxLength: 200, nullable: true),
                    TwitterLink = table.Column<string>(maxLength: 200, nullable: true),
                    InstagramLink = table.Column<string>(maxLength: 200, nullable: true),
                    LinkedInLink = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(maxLength: 200, nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Position = table.Column<string>(maxLength: 200, nullable: false),
                    Company = table.Column<string>(maxLength: 200, nullable: false),
                    Photo = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    TopText = table.Column<string>(type: "ntext", nullable: false),
                    Text = table.Column<string>(type: "ntext", nullable: false),
                    InfoText = table.Column<string>(type: "ntext", nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    PhotoSm = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(maxLength: 200, nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Visited = table.Column<int>(nullable: false),
                    BlogCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Blogs_BlogCategories_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalTable: "BlogCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    CarBrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "CarBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    PickupDate = table.Column<DateTime>(type: "Date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "Date", nullable: false),
                    PickupLocation = table.Column<string>(maxLength: 200, nullable: false),
                    DropLocation = table.Column<string>(maxLength: 200, nullable: false),
                    OrderNote = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GalleryItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryId = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(maxLength: 200, nullable: true),
                    PhotoSm = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryItems_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModelId = table.Column<int>(nullable: false),
                    Transmission = table.Column<int>(nullable: false),
                    Fuel = table.Column<int>(nullable: false),
                    Passsenger = table.Column<byte>(nullable: false),
                    Luggage = table.Column<byte>(nullable: false),
                    Door = table.Column<byte>(nullable: false),
                    Title = table.Column<string>(maxLength: 70, nullable: false),
                    DailyPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Discount = table.Column<byte>(nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    CartPhoto = table.Column<string>(nullable: true),
                    DetailPhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false),
                    QualityStars = table.Column<byte>(nullable: false),
                    PriceStars = table.Column<byte>(nullable: false),
                    ComfortStars = table.Column<byte>(nullable: false),
                    DrivingStars = table.Column<byte>(nullable: false),
                    PositiveReview = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerReviews_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CustomerReviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarExtraServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "Money", nullable: false),
                    OrderItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarExtraServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarExtraServices_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Advantage",
                columns: new[] { "Id", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Best Price Guarantee" },
                    { 2, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "No Cancellation Fees" },
                    { 3, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Best Quality Cars" },
                    { 4, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Reservation Anytime" },
                    { 5, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Personal Driver" },
                    { 6, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Unlimited Miles" },
                    { 7, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "City to City" },
                    { 8, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "24/7 Customer Support" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Name", "Password", "Photo" },
                values: new object[,]
                {
                    { 3, "johndoe2@mail.com", "John Doe2", "john123", "author-1.jpg" },
                    { 1, "johndoe@mail.com", "John Doe", "john123", "author-1.jpg" },
                    { 2, "johndoe1@mail.com", "John Doe1", "john123", "author-1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BlogCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Branding" },
                    { 1, "Lifestyle" },
                    { 2, "Travel" },
                    { 3, "Fashion" },
                    { 4, "Music" }
                });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Tesla" },
                    { 2, "Toyota" },
                    { 1, "Mercedes" }
                });

            migrationBuilder.InsertData(
                table: "CarExtraServices",
                columns: new[] { "Id", "Name", "OrderItemId", "Price" },
                values: new object[,]
                {
                    { 1, "Driver", null, 100m },
                    { 2, "Snacks", null, 10m }
                });

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 5, "car-type-statio-wagon", "Station Wagon" },
                    { 4, "car-type-minivan", "Minivan" },
                    { 6, "car-type-limousine", "Limousine" },
                    { 2, "car-type-roadster", "Roadster" },
                    { 1, "car-type-sedan", "Sedan" },
                    { 3, "car-type-coupe", "Coupe" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Coupon1", true },
                    { 2, "Coupon2", true },
                    { 3, "Coupon3", true },
                    { 4, "Coupon4", true },
                    { 5, "Coupon5", true }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Country", "Email", "HappyClient", "Name", "Password", "Postalcode", "StreetAdress", "Surname", "Token" },
                values: new object[] { 1, (byte)21, 0, "fuadjt@code.edu.az", false, "Fuad", "Fuad123", "AZ1021", "Nizami Street", "Taghiyev", null });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "Question" },
                values: new object[,]
                {
                    { 5, " cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 6, " cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 4, " cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 1, " cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 2, " cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 3, " cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" }
                });

            migrationBuilder.InsertData(
                table: "Galleries",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Icon", "Text", "Title" },
                values: new object[,]
                {
                    { 5, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 4, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 3, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 2, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 1, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 7, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 6, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" }
                });

            migrationBuilder.InsertData(
                table: "OurVisions",
                columns: new[] { "Id", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Best Price Guarantee" },
                    { 2, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Best Price Guarantee" },
                    { 3, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Best Price Guarantee" },
                    { 4, "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat.", "Best Price Guarantee" }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Text" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies erat non augue pretium mollis. Nunc ut mauris volutpat, imperdiet nunc et, mattis erat. Sed id pretium est. Suspendisse magna diam, ultrices ac arcu ut, aliquam tincidunt est. In nisl nulla, dapibus id ante eget, interdum ultricies magna. Maecenas lectus urna, pulvinar consequat lobortis sed, sodales a libero. Pellentesque ac magna tellus. Phasellus nisl lorem, convallis vel cursus porttitor, ullamcorper nec dui.Aenean at nibh massa. Mauris magna sapien, sollicitudin eget finibus eu, aliquet at lectus. Cras cursus eget libero id blandit. Fusce quis ligula id tellus euismod posuere. Nunc nunc ex, ultrices ac pellentesque eu, ultricies nec justo. Aenean dolor neque, tristique in lectus at, ornare bibendum ligula. Curabitur scelerisque, ligula sit amet aliquet finibus, diam erat pharetra dolor, ac vulputate nunc ex vel ante. Etiam nec efficitur sem. Suspendisse nisl velit, rutrum nec magna at, cursus egestas nunc. Maecenas laoreet quam sit amet erat pretium, vel lobortis nunc fermentum. Cras ullamcorper mi nec vehicula sagittis. Mauris ut neque orci. Nunc non ornare neque, vel vestibulum libero.Duis gravida ante sed mi mattis hendrerit. Nullam efficitur ligula eget feugiat vehicula. Aliquam quis dui scelerisque, tempus velit posuere, sodales justo. Cras in faucibus ante. Suspendisse eget viverra nunc. Nam luctus risus diam, efficitur bibendum mauris feugiat a. Sed efficitur sit amet sapien quis porta. Cras nec nisl erat. Integer rutrum augue non pharetra placerat. Duis quis condimentum velit. Morbi placerat nec ipsum eget aliquam.Curabitur hendrerit gravida risus, consectetur sollicitudin mauris. Praesent fringilla consequat velit, at eleifend lectus tempor at. Donec auctor pretium tempus. Donec sit amet est nec nulla sagittis malesuada. Aenean ac felis urna. Aliquam ipsum ligula, rutrum id consectetur eu, dapibus sit amet quam. Donec varius malesuada turpis. Phasellus volutpat non dolor vel lacinia. Pellentesque ultrices ut libero vel pellentesque. Curabitur in quam porta, elementum lorem nec, euismod arcu. Mauris laoreet ipsum eros, id ornare nibh varius et. Duis bibendum a purus a euismod. Sed a pretium sem, nec sollicitudin urna.Nulla lacinia turpis non justo congue, eu tincidunt dolor pulvinar. Duis laoreet sed sem quis eleifend. Phasellus sed cursus tortor. Morbi rhoncus mi non vulputate imperdiet. Aenean sem mi, rhoncus vel rhoncus ut, sollicitudin convallis enim. Nunc malesuada pretium felis vel scelerisque. Sed vulputate, augue dictum venenatis sagittis, urna leo condimentum orci, id pellentesque ipsum tortor at dolor. Integer lobortis nulla ullamcorper commodo ullamcorper. Aliquam erat volutpat. Mauris vehicula nibh vel mauris efficitur, eu sollicitudin felis ornare. Sed nec laoreet est. Vivamus fringilla quam ex, id ultricies risus tincidunt et. In tincidunt felis tortor, et sodales magna accumsan et. Proin sit amet erat ut magna tempor posuere. Nunc eleifend dictum nisl, non condimentum purus pellentesque quis. Praesent pharetra volutpat leo, eget accumsan nisl porttitor eu." });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "Id", "Name", "Photo" },
                values: new object[,]
                {
                    { 2, "RentNow", "partner-2.png" },
                    { 3, "RentNow", "partner-3.png" },
                    { 4, "RentNow", "partner-4.png" },
                    { 1, "RentNow", "partner-1.png" }
                });

            migrationBuilder.InsertData(
                table: "Passions",
                columns: new[] { "Id", "Photo", "SubTitle", "Text", "Title" },
                values: new object[] { 1, "about-img.jpg", "Make Beauty Things", "Proin euismod mollis mi in finibus. Duis vitae elementum ligula. Cras suscipit feugiat arcu, eu venenatis odio. Vivamus non venenatis urna. Curabitur quis elit ut lorem condimentum dignissim. Nunc ornare massa vel fringilla efficitur. Cras elementum ligula et metus tempor, sit amet convallis neque venenatis. Morbi nisi eros, finibus sit amet ipsum ac, venenatis dignissim leo.", "With Passion" });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Adress", "Email", "FacebookLink", "FooterLogo", "FooterText", "GoogleLink", "InstagramLink", "LinkedInLink", "Logo", "MainAdress", "Payment", "Phone", "SaleEmail", "SupPhone", "TwitterLink" },
                values: new object[] { 1, "Florida – 33169, USA", "support@example.com", "https://www.facebook.com", "logo.svg", "Sed sit amet ligula ac nulla finibus euismod nec nec diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent semper, risus eget ornare maximus, ipsum ante semper.", "https://www.google.com", "https://www.instagram.com", "https://www.linkedin.com", "logo.svg", "1425 Pointe Lane, Miami", "payments.png", "(954) - 944 - 1250", "sale@example.com", "(954) - 944 - 1250", "https://www.twitter.com" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Photo", "Text", "Title" },
                values: new object[,]
                {
                    { 2, "slide2.jpg", "Maecenas viverra porta eros,id tincidunt lorem rhoncus eget.Aliquam erat volutpat.Sed ultricies elementum egestas.", "24/7 Customer Support Guarantee" },
                    { 3, "slide3.jpg", "Maecenas viverra porta eros, id tincidunt lorem rhoncus eget. Aliquam erat volutpat. Sed ultricies elementum egestas.", "Quality Cars with Unlimited Miles" },
                    { 1, "slide1.jpg", "Maecenas viverra porta eros,id tincidunt lorem rhoncus eget.Aliquam erat volutpat.Sed ultricies elementum egestas.", "#1 Car Rent Service In Your City" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "FacebookLink", "InstagramLink", "LinkedInLink", "Name", "Photo", "Position", "TwitterLink" },
                values: new object[,]
                {
                    { 2, "https://www.facebook.com/", "https://www.instagram.com", "https://www.linkedin.com", "Crystal Spencer", "team-member-2.jpg", "Co-Founder & CEO", "https://www.twitter.com" },
                    { 1, "https://www.facebook.com/", "https://www.instagram.com", "https://www.linkedin.com", "Crystal Spencer", "team-member-1.jpg", "Co-Founder & CEO", "https://www.twitter.com" },
                    { 3, "https://www.facebook.com", "https://www.instagram.com", "https://www.linkedin.com", "Crystal Spencer", "team-member-3.jpg", "Co-Founder & CEO", "https://www.twitter.com" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Company", "Name", "Photo", "Position", "Text" },
                values: new object[,]
                {
                    { 3, "Example Inc.", "Catherine Beck", "author-3.jpg", "CEO", "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel." },
                    { 4, "Example Inc.", "Catherine Beck", "author-3.jpg", "CEO", "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel." },
                    { 1, "Example Inc.", "Catherine Beck", "author-3.jpg", "CEO", "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel." },
                    { 2, "Example Inc.", "Catherine Beck", "author-3.jpg", "CEO", "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel." }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "BlogCategoryId", "CreatedAt", "InfoText", "Likes", "Name", "Photo", "PhotoSm", "Slug", "Text", "Title", "TopText", "Visited" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 1, 15, 12, 37, 25, 641, DateTimeKind.Local).AddTicks(1940), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 },
                    { 2, 2, 2, new DateTime(2020, 1, 15, 12, 37, 25, 642, DateTimeKind.Local).AddTicks(9757), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach", "post-item-2.jpg", "blog-item-sm-2.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 },
                    { 3, 3, 4, new DateTime(2020, 1, 15, 12, 37, 25, 642, DateTimeKind.Local).AddTicks(9837), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 },
                    { 4, 3, 4, new DateTime(2020, 1, 15, 12, 37, 25, 642, DateTimeKind.Local).AddTicks(9935), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach4", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image4", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 },
                    { 5, 3, 4, new DateTime(2020, 1, 15, 12, 37, 25, 642, DateTimeKind.Local).AddTicks(9938), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach5", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image5", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 },
                    { 6, 3, 4, new DateTime(2020, 1, 15, 12, 37, 25, 642, DateTimeKind.Local).AddTicks(9940), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach6", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image6", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarBrandId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "EQC" },
                    { 2, 2, "Camry" },
                    { 3, 3, "Model S" }
                });

            migrationBuilder.InsertData(
                table: "GalleryItems",
                columns: new[] { "Id", "GalleryId", "Photo", "PhotoSm" },
                values: new object[,]
                {
                    { 7, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 6, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 5, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 4, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 9, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 2, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 1, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 8, 1, "gallery-1.jpg", "gallery-sm-1.jpg" },
                    { 3, 1, "gallery-1.jpg", "gallery-sm-1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DropDate", "DropLocation", "OrderNote", "PaymentMethod", "PickupDate", "PickupLocation" },
                values: new object[] { 1, 1, new DateTime(2020, 1, 20, 12, 37, 25, 647, DateTimeKind.Local).AddTicks(4509), "Baku, H.A Airport", null, 0, new DateTime(2020, 1, 15, 12, 37, 25, 647, DateTimeKind.Local).AddTicks(3812), "Baku, H.A Airport" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "CartPhoto", "DailyPrice", "Description", "DetailPhoto", "Discount", "Door", "Fuel", "Luggage", "Passsenger", "Photo", "Status", "Title", "Transmission" },
                values: new object[,]
                {
                    { 2, 1, "cart-item-1.jpg", 300m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 3, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis", 0 },
                    { 7, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis6", 0 },
                    { 6, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis5", 0 },
                    { 5, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis", 0 },
                    { 4, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis", 0 },
                    { 3, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis", 0 },
                    { 1, 2, "cart-item-1.jpg", 150m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis", 0 },
                    { 8, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis7", 0 },
                    { 9, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis8", 0 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "BlogId", "CreatedAt", "Text" },
                values: new object[,]
                {
                    { 12, 2, 2, new DateTime(2020, 1, 15, 12, 37, 25, 643, DateTimeKind.Local).AddTicks(3544), "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus." },
                    { 3, 3, 3, new DateTime(2020, 1, 15, 12, 37, 25, 643, DateTimeKind.Local).AddTicks(3563), "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus." },
                    { 1, 1, 1, new DateTime(2020, 1, 15, 12, 37, 25, 643, DateTimeKind.Local).AddTicks(2224), "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus." }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "BlogId", "Name" },
                values: new object[,]
                {
                    { 4, 2, "Images" },
                    { 3, 2, "Car" },
                    { 5, 1, "Cars" },
                    { 2, 1, "Image" },
                    { 1, 1, "Video" }
                });

            migrationBuilder.InsertData(
                table: "CustomerReviews",
                columns: new[] { "Id", "CarId", "ComfortStars", "CreatedAt", "CustomerId", "DrivingStars", "PositiveReview", "PriceStars", "QualityStars", "Text" },
                values: new object[] { 1, 1, (byte)4, new DateTime(2020, 1, 15, 12, 37, 25, 647, DateTimeKind.Local).AddTicks(800), 1, (byte)4, false, (byte)3, (byte)2, "Mauris quis sollicitudin ipsum. Morbi venenatis sem eros, quis pulvinar lacus pharetra nec. Vestibulum odio ante, venenatis ut volutpat nec, scelerisque vel purus. Nunc tempor eros a interdum blandit." });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CarId", "OrderId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CarId", "OrderId" },
                values: new object[] { 1, 1, 1 });

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
                name: "IX_Blogs_AuthorId",
                table: "Blogs",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CarExtraServices_OrderItemId",
                table: "CarExtraServices",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarBrandId",
                table: "CarModels",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelId",
                table: "Cars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReviews_CarId",
                table: "CustomerReviews",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReviews_CustomerId",
                table: "CustomerReviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItems_GalleryId",
                table: "GalleryItems",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CarId",
                table: "OrderItems",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogId",
                table: "Tags",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "Advantage");

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
                name: "CarExtraServices");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "CustomerReviews");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "GalleryItems");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "OurVisions");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Passions");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CarBrands");
        }
    }
}
