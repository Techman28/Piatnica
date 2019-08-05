using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCode.Piatnica.Api.Migrations
{
    public partial class cars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DriversContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    DriverLicense = table.Column<string>(nullable: true),
                    HiringDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversContext", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VechiclesContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    Registration = table.Column<string>(nullable: true),
                    Mileage = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VechiclesContext", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdersContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    VechicleId = table.Column<int>(nullable: true),
                    DriverId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersContext_DriversContext_DriverId",
                        column: x => x.DriverId,
                        principalTable: "DriversContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdersContext_VechiclesContext_VechicleId",
                        column: x => x.VechicleId,
                        principalTable: "VechiclesContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationsHistoriesContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Longitude = table.Column<double>(nullable: false),
                    LatitudeL = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationsHistoriesContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationsHistoriesContext_OrdersContext_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrdersContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersEntriesContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderType = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    FromTime = table.Column<DateTime>(nullable: false),
                    ToTime = table.Column<DateTime>(nullable: false),
                    Cargo = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersEntriesContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersEntriesContext_OrdersContext_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrdersContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersStatesContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    State = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatesContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersStatesContext_OrdersContext_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrdersContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DelaysContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DelayOrder = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    OrderEntryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelaysContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DelaysContext_OrdersEntriesContext_OrderEntryId",
                        column: x => x.OrderEntryId,
                        principalTable: "OrdersEntriesContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventsHistoriesContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderEntryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsHistoriesContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventsHistoriesContext_OrdersEntriesContext_OrderEntryId",
                        column: x => x.OrderEntryId,
                        principalTable: "OrdersEntriesContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DelaysContext_OrderEntryId",
                table: "DelaysContext",
                column: "OrderEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_EventsHistoriesContext_OrderEntryId",
                table: "EventsHistoriesContext",
                column: "OrderEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationsHistoriesContext_OrderId",
                table: "LocationsHistoriesContext",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersContext_DriverId",
                table: "OrdersContext",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersContext_VechicleId",
                table: "OrdersContext",
                column: "VechicleId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersEntriesContext_OrderId",
                table: "OrdersEntriesContext",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersStatesContext_OrderId",
                table: "OrdersStatesContext",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DelaysContext");

            migrationBuilder.DropTable(
                name: "EventsHistoriesContext");

            migrationBuilder.DropTable(
                name: "LocationsHistoriesContext");

            migrationBuilder.DropTable(
                name: "OrdersStatesContext");

            migrationBuilder.DropTable(
                name: "OrdersEntriesContext");

            migrationBuilder.DropTable(
                name: "OrdersContext");

            migrationBuilder.DropTable(
                name: "DriversContext");

            migrationBuilder.DropTable(
                name: "VechiclesContext");
        }
    }
}
