﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TerritoryWeb.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
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
                name: "Congregations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Congregations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "PublisherTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TerritoryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerritoryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "URLMinimizeStore",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shortURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    used = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URLMinimizeStore", x => x.id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "DoorCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongregationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoorCodes_Congregations_CongregationID",
                        column: x => x.CongregationID,
                        principalTable: "Congregations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongregationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_Congregations_CongregationID",
                        column: x => x.CongregationID,
                        principalTable: "Congregations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerritoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongregationID = table.Column<int>(type: "int", nullable: false),
                    AssignedPublisherID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckedIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastCheckedInBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerritoryTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Territories_Congregations_CongregationID",
                        column: x => x.CongregationID,
                        principalTable: "Congregations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Territories_TerritoryTypes_TerritoryTypeId",
                        column: x => x.TerritoryTypeId,
                        principalTable: "TerritoryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerritoryID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageID = table.Column<int>(type: "int", nullable: true),
                    CodeID = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeoLat = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    GeoLong = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoorCodeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doors_DoorCodes_DoorCodeId",
                        column: x => x.DoorCodeId,
                        principalTable: "DoorCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doors_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doors_Territories_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "Territories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TerritoryAccess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerritoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    IsWrite = table.Column<bool>(type: "bit", nullable: false),
                    TempAccess = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerritoryAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TerritoryAccess_Territories_TerritoryId",
                        column: x => x.TerritoryId,
                        principalTable: "Territories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TerritoryBounds",
                columns: table => new
                {
                    BoundaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerritoryID = table.Column<int>(type: "int", nullable: false),
                    GeoLat = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    GeoLong = table.Column<decimal>(type: "decimal(9,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerritoryBounds", x => x.BoundaryID);
                    table.ForeignKey(
                        name: "FK_TerritoryBounds_Territories_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "Territories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Congregations",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Cedar Crest Spanish" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CongregationID", "Description" },
                values: new object[,]
                {
                    { 1, null, "English" },
                    { 2, null, "Español" }
                });

            migrationBuilder.InsertData(
                table: "PublisherTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Publisher" },
                    { 2, "Pioneer" },
                    { 3, "Elder" }
                });

            migrationBuilder.InsertData(
                table: "TerritoryTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Door to Door" },
                    { 2, "Telephone" }
                });

            migrationBuilder.InsertData(
                table: "Territories",
                columns: new[] { "Id", "Added", "AddedBy", "AssignedPublisherID", "CheckedIn", "CheckedOut", "City", "CongregationID", "LastCheckedInBy", "Modified", "ModifiedBy", "Notes", "TerritoryName", "TerritoryTypeId", "Type" },
                values: new object[] { 1, new DateTime(2020, 12, 2, 10, 24, 55, 768, DateTimeKind.Local).AddTicks(5110), "cyberyaga@hotmail.com", null, null, null, null, 1, null, new DateTime(2020, 12, 2, 10, 24, 55, 771, DateTimeKind.Local).AddTicks(8033), "cyberyaga@hotmail.com", null, "Allentown - 01", null, 1 });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "Added", "AddedBy", "Address", "Apartment", "CodeID", "Comments", "DoorCodeId", "GeoLat", "GeoLong", "LanguageID", "Modified", "ModifiedBy", "Name", "PostalCode", "Street", "Telephone", "TerritoryID" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 12, 2, 10, 24, 55, 772, DateTimeKind.Local).AddTicks(1826), "cyberyaga@hotmail.com", "1526", null, null, "Test comment", null, 40.578639m, -75.481580m, null, new DateTime(2020, 12, 2, 10, 24, 55, 772, DateTimeKind.Local).AddTicks(2306), "cyberyaga@hotmail.com", "Cesar Rodriguez", null, "Catalina Ave.", "212-555-1212", 1 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "TerritoryBounds",
                columns: new[] { "BoundaryID", "GeoLat", "GeoLong", "TerritoryID" },
                values: new object[,]
                {
                    { 2550, 40.588590m, -75.484890m, 1 },
                    { 2551, 40.588470m, -75.486060m, 1 },
                    { 2552, 40.588410m, -75.486710m, 1 },
                    { 2553, 40.588420m, -75.486980m, 1 },
                    { 2554, 40.588460m, -75.487240m, 1 },
                    { 2555, 40.588600m, -75.487560m, 1 },
                    { 2556, 40.588830m, -75.487770m, 1 },
                    { 2557, 40.589100m, -75.487880m, 1 },
                    { 2558, 40.589370m, -75.488030m, 1 },
                    { 2559, 40.589680m, -75.488160m, 1 },
                    { 2560, 40.590000m, -75.488330m, 1 },
                    { 2561, 40.589930m, -75.488530m, 1 },
                    { 2562, 40.589850m, -75.488720m, 1 },
                    { 2563, 40.589700m, -75.489040m, 1 },
                    { 2564, 40.589550m, -75.489350m, 1 },
                    { 2565, 40.589390m, -75.489680m, 1 },
                    { 2566, 40.589320m, -75.489840m, 1 },
                    { 2567, 40.589250m, -75.490010m, 1 },
                    { 2568, 40.589180m, -75.490250m, 1 },
                    { 2549, 40.588580m, -75.484400m, 1 },
                    { 2548, 40.588490m, -75.483990m, 1 },
                    { 2547, 40.588410m, -75.483720m, 1 },
                    { 2546, 40.588380m, -75.483660m, 1 },
                    { 2526, 40.585490m, -75.479060m, 1 },
                    { 2527, 40.585480m, -75.479190m, 1 },
                    { 2528, 40.585510m, -75.479260m, 1 },
                    { 2529, 40.585530m, -75.479300m, 1 },
                    { 2530, 40.585550m, -75.479350m, 1 },
                    { 2531, 40.585730m, -75.479610m, 1 },
                    { 2532, 40.585930m, -75.479910m, 1 },
                    { 2533, 40.586170m, -75.480270m, 1 },
                    { 2534, 40.586390m, -75.480600m, 1 },
                    { 2569, 40.589130m, -75.490480m, 1 },
                    { 2535, 40.586560m, -75.480860m, 1 },
                    { 2537, 40.586890m, -75.481380m, 1 },
                    { 2538, 40.587090m, -75.481670m, 1 },
                    { 2539, 40.587340m, -75.482060m, 1 },
                    { 2540, 40.587650m, -75.482540m, 1 },
                    { 2541, 40.587900m, -75.482910m, 1 },
                    { 2542, 40.588140m, -75.483270m, 1 }
                });

            migrationBuilder.InsertData(
                table: "TerritoryBounds",
                columns: new[] { "BoundaryID", "GeoLat", "GeoLong", "TerritoryID" },
                values: new object[,]
                {
                    { 2543, 40.588230m, -75.483380m, 1 },
                    { 2544, 40.588300m, -75.483500m, 1 },
                    { 2545, 40.588360m, -75.483600m, 1 },
                    { 2536, 40.586660m, -75.481010m, 1 },
                    { 2570, 40.589070m, -75.491090m, 1 },
                    { 2571, 40.589030m, -75.491450m, 1 },
                    { 2572, 40.588980m, -75.491910m, 1 },
                    { 2597, 40.586280m, -75.498650m, 1 },
                    { 2598, 40.586190m, -75.498890m, 1 },
                    { 2599, 40.586060m, -75.499170m, 1 },
                    { 2600, 40.585920m, -75.499430m, 1 },
                    { 2601, 40.585780m, -75.499610m, 1 },
                    { 2602, 40.585650m, -75.499780m, 1 },
                    { 2603, 40.585370m, -75.500110m, 1 },
                    { 2604, 40.585110m, -75.500400m, 1 },
                    { 2605, 40.584870m, -75.500660m, 1 },
                    { 2596, 40.586410m, -75.498210m, 1 },
                    { 2606, 40.584750m, -75.500820m, 1 },
                    { 2608, 40.584580m, -75.501080m, 1 },
                    { 2609, 40.584530m, -75.501210m, 1 },
                    { 2610, 40.584480m, -75.501330m, 1 },
                    { 2611, 40.584430m, -75.501470m, 1 },
                    { 2612, 40.584400m, -75.501590m, 1 },
                    { 2613, 40.584370m, -75.501700m, 1 },
                    { 2614, 40.584340m, -75.501820m, 1 },
                    { 2615, 40.584320m, -75.501950m, 1 },
                    { 2616, 40.584300m, -75.502240m, 1 },
                    { 2607, 40.584660m, -75.500970m, 1 },
                    { 2525, 40.585520m, -75.478940m, 1 },
                    { 2595, 40.586510m, -75.497890m, 1 },
                    { 2593, 40.586790m, -75.497000m, 1 },
                    { 2573, 40.588950m, -75.492100m, 1 },
                    { 2574, 40.588920m, -75.492300m, 1 },
                    { 2575, 40.588890m, -75.492490m, 1 },
                    { 2576, 40.588840m, -75.492680m, 1 },
                    { 2577, 40.588780m, -75.492890m, 1 },
                    { 2578, 40.588730m, -75.493030m, 1 },
                    { 2579, 40.588640m, -75.493260m, 1 },
                    { 2580, 40.588400m, -75.493770m, 1 },
                    { 2581, 40.588230m, -75.494110m, 1 },
                    { 2594, 40.586610m, -75.497600m, 1 },
                    { 2582, 40.588050m, -75.494480m, 1 }
                });

            migrationBuilder.InsertData(
                table: "TerritoryBounds",
                columns: new[] { "BoundaryID", "GeoLat", "GeoLong", "TerritoryID" },
                values: new object[,]
                {
                    { 2584, 40.587730m, -75.495120m, 1 },
                    { 2585, 40.587570m, -75.495400m, 1 },
                    { 2586, 40.587410m, -75.495660m, 1 },
                    { 2587, 40.587260m, -75.495870m, 1 },
                    { 2588, 40.587180m, -75.495990m, 1 },
                    { 2589, 40.587110m, -75.496110m, 1 },
                    { 2590, 40.587020m, -75.496310m, 1 },
                    { 2591, 40.586940m, -75.496510m, 1 },
                    { 2592, 40.586860m, -75.496770m, 1 },
                    { 2583, 40.587890m, -75.494800m, 1 },
                    { 2524, 40.585300m, -75.478910m, 1 },
                    { 2523, 40.585090m, -75.478880m, 1 },
                    { 2522, 40.584720m, -75.478830m, 1 },
                    { 2454, 40.570320m, -75.499470m, 1 },
                    { 2455, 40.570070m, -75.499470m, 1 },
                    { 2456, 40.569860m, -75.499460m, 1 },
                    { 2457, 40.569500m, -75.499390m, 1 },
                    { 2458, 40.569210m, -75.499300m, 1 },
                    { 2459, 40.568420m, -75.498920m, 1 },
                    { 2460, 40.567320m, -75.498280m, 1 },
                    { 2461, 40.566620m, -75.497890m, 1 },
                    { 2462, 40.565930m, -75.497500m, 1 },
                    { 2453, 40.570610m, -75.499450m, 1 },
                    { 2463, 40.564660m, -75.484860m, 1 },
                    { 2465, 40.571880m, -75.481070m, 1 },
                    { 2466, 40.572390m, -75.480890m, 1 },
                    { 2467, 40.572760m, -75.480830m, 1 },
                    { 2468, 40.574330m, -75.480820m, 1 },
                    { 2469, 40.575870m, -75.480840m, 1 },
                    { 2470, 40.577110m, -75.480830m, 1 },
                    { 2471, 40.577620m, -75.480820m, 1 },
                    { 2472, 40.578170m, -75.480810m, 1 },
                    { 2473, 40.578670m, -75.480700m, 1 },
                    { 2464, 40.571450m, -75.481290m, 1 },
                    { 2474, 40.578800m, -75.480670m, 1 },
                    { 2452, 40.571050m, -75.499350m, 1 },
                    { 2450, 40.572370m, -75.499000m, 1 },
                    { 2430, 40.584240m, -75.503010m, 1 },
                    { 2431, 40.579930m, -75.502500m, 1 },
                    { 2432, 40.578870m, -75.502400m, 1 },
                    { 2433, 40.577780m, -75.502280m, 1 },
                    { 2434, 40.577100m, -75.502200m, 1 }
                });

            migrationBuilder.InsertData(
                table: "TerritoryBounds",
                columns: new[] { "BoundaryID", "GeoLat", "GeoLong", "TerritoryID" },
                values: new object[,]
                {
                    { 2435, 40.576790m, -75.502170m, 1 },
                    { 2436, 40.576520m, -75.502080m, 1 },
                    { 2437, 40.576260m, -75.501960m, 1 },
                    { 2438, 40.575890m, -75.501690m, 1 },
                    { 2451, 40.571590m, -75.499210m, 1 },
                    { 2439, 40.575550m, -75.501410m, 1 },
                    { 2441, 40.574470m, -75.500530m, 1 },
                    { 2442, 40.574220m, -75.500240m, 1 },
                    { 2443, 40.574080m, -75.500020m, 1 },
                    { 2444, 40.573890m, -75.499710m, 1 },
                    { 2445, 40.573600m, -75.499350m, 1 },
                    { 2446, 40.573350m, -75.499170m, 1 },
                    { 2447, 40.573070m, -75.499030m, 1 },
                    { 2448, 40.572670m, -75.498960m, 1 },
                    { 2449, 40.572510m, -75.498980m, 1 },
                    { 2440, 40.575070m, -75.501010m, 1 },
                    { 2617, 40.584280m, -75.502550m, 1 },
                    { 2475, 40.578910m, -75.480610m, 1 },
                    { 2477, 40.579340m, -75.480420m, 1 },
                    { 2502, 40.582290m, -75.477520m, 1 },
                    { 2503, 40.582340m, -75.477610m, 1 },
                    { 2504, 40.582380m, -75.477680m, 1 },
                    { 2505, 40.582480m, -75.477840m, 1 },
                    { 2506, 40.582610m, -75.478030m, 1 },
                    { 2507, 40.582670m, -75.478110m, 1 },
                    { 2508, 40.582740m, -75.478200m, 1 },
                    { 2509, 40.582890m, -75.478340m, 1 },
                    { 2510, 40.583040m, -75.478470m, 1 },
                    { 2501, 40.582180m, -75.477650m, 1 },
                    { 2511, 40.583150m, -75.478550m, 1 },
                    { 2513, 40.583280m, -75.478650m, 1 },
                    { 2514, 40.583330m, -75.478740m, 1 },
                    { 2515, 40.583390m, -75.478820m, 1 },
                    { 2516, 40.583530m, -75.478800m, 1 },
                    { 2517, 40.583680m, -75.478780m, 1 },
                    { 2518, 40.583950m, -75.478740m, 1 },
                    { 2519, 40.584100m, -75.478740m, 1 },
                    { 2520, 40.584280m, -75.478750m, 1 },
                    { 2521, 40.584490m, -75.478780m, 1 },
                    { 2512, 40.583260m, -75.478630m, 1 },
                    { 2476, 40.579130m, -75.480510m, 1 },
                    { 2500, 40.582070m, -75.477770m, 1 }
                });

            migrationBuilder.InsertData(
                table: "TerritoryBounds",
                columns: new[] { "BoundaryID", "GeoLat", "GeoLong", "TerritoryID" },
                values: new object[,]
                {
                    { 2498, 40.581950m, -75.477900m, 1 },
                    { 2478, 40.579570m, -75.480310m, 1 },
                    { 2479, 40.579910m, -75.480080m, 1 },
                    { 2480, 40.580170m, -75.479850m, 1 },
                    { 2481, 40.580360m, -75.479640m, 1 },
                    { 2482, 40.580410m, -75.479590m, 1 },
                    { 2483, 40.580550m, -75.479430m, 1 },
                    { 2484, 40.580630m, -75.479350m, 1 },
                    { 2485, 40.580700m, -75.479260m, 1 },
                    { 2486, 40.580860m, -75.479100m, 1 },
                    { 2499, 40.581990m, -75.477850m, 1 },
                    { 2487, 40.581040m, -75.478900m, 1 },
                    { 2489, 40.581270m, -75.478650m, 1 },
                    { 2490, 40.581410m, -75.478490m, 1 },
                    { 2491, 40.581550m, -75.478340m, 1 },
                    { 2492, 40.581600m, -75.478290m, 1 },
                    { 2493, 40.581750m, -75.478120m, 1 },
                    { 2494, 40.581790m, -75.478070m, 1 },
                    { 2495, 40.581830m, -75.478030m, 1 },
                    { 2496, 40.581870m, -75.477980m, 1 },
                    { 2497, 40.581920m, -75.477940m, 1 },
                    { 2488, 40.581130m, -75.478800m, 1 },
                    { 2618, 40.584240m, -75.503010m, 1 }
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
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_DoorCodes_CongregationID",
                table: "DoorCodes",
                column: "CongregationID");

            migrationBuilder.CreateIndex(
                name: "IX_Doors_DoorCodeId",
                table: "Doors",
                column: "DoorCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Doors_LanguageID",
                table: "Doors",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Doors_TerritoryID",
                table: "Doors",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CongregationID",
                table: "Languages",
                column: "CongregationID");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Territories_CongregationID",
                table: "Territories",
                column: "CongregationID");

            migrationBuilder.CreateIndex(
                name: "IX_Territories_TerritoryTypeId",
                table: "Territories",
                column: "TerritoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TerritoryAccess_TerritoryId",
                table: "TerritoryAccess",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TerritoryBounds_TerritoryID",
                table: "TerritoryBounds",
                column: "TerritoryID");
        }

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
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "PublisherTypes");

            migrationBuilder.DropTable(
                name: "TerritoryAccess");

            migrationBuilder.DropTable(
                name: "TerritoryBounds");

            migrationBuilder.DropTable(
                name: "URLMinimizeStore");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DoorCodes");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Territories");

            migrationBuilder.DropTable(
                name: "Congregations");

            migrationBuilder.DropTable(
                name: "TerritoryTypes");
        }
    }
}
