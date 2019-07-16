using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCode.Piatnica.Api.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersContext", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationsHistoriesContext",
                columns: table => new
                {
                    Longitude = table.Column<double>(nullable: false),
                    LatitudeL = table.Column<double>(nullable: false),
                    Date = table.Column<TimeSpan>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationsHistoriesContext", x => x.Longitude);
                    table.ForeignKey(
                        name: "FK_LocationsHistoriesContext_OrdersContext_Id",
                        column: x => x.Id,
                        principalTable: "OrdersContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersEntriesContext",
                columns: table => new
                {
                    OrderType = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Date = table.Column<TimeSpan>(nullable: false),
                    FromTime = table.Column<TimeSpan>(nullable: false),
                    ToTime = table.Column<TimeSpan>(nullable: false),
                    Cargo = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersEntriesContext", x => x.OrderType);
                    table.ForeignKey(
                        name: "FK_OrdersEntriesContext_OrdersContext_Id",
                        column: x => x.Id,
                        principalTable: "OrdersContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersStatesContext",
                columns: table => new
                {
                    State = table.Column<string>(nullable: false),
                    Date = table.Column<TimeSpan>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatesContext", x => x.State);
                    table.ForeignKey(
                        name: "FK_OrdersStatesContext_OrdersContext_Id",
                        column: x => x.Id,
                        principalTable: "OrdersContext",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DelaysContext",
                columns: table => new
                {
                    DelayOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<TimeSpan>(nullable: false),
                    OrderEntryOrderType = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelaysContext", x => x.DelayOrder);
                    table.ForeignKey(
                        name: "FK_DelaysContext_OrdersEntriesContext_OrderEntryOrderType",
                        column: x => x.OrderEntryOrderType,
                        principalTable: "OrdersEntriesContext",
                        principalColumn: "OrderType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventsHistoriesContext",
                columns: table => new
                {
                    Date = table.Column<TimeSpan>(nullable: false),
                    Distance = table.Column<float>(nullable: false),
                    OrderEntryOrderType = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsHistoriesContext", x => x.Date);
                    table.ForeignKey(
                        name: "FK_EventsHistoriesContext_OrdersEntriesContext_OrderEntryOrderType",
                        column: x => x.OrderEntryOrderType,
                        principalTable: "OrdersEntriesContext",
                        principalColumn: "OrderType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DelaysContext_OrderEntryOrderType",
                table: "DelaysContext",
                column: "OrderEntryOrderType");

            migrationBuilder.CreateIndex(
                name: "IX_EventsHistoriesContext_OrderEntryOrderType",
                table: "EventsHistoriesContext",
                column: "OrderEntryOrderType");

            migrationBuilder.CreateIndex(
                name: "IX_LocationsHistoriesContext_Id",
                table: "LocationsHistoriesContext",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersEntriesContext_Id",
                table: "OrdersEntriesContext",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersStatesContext_Id",
                table: "OrdersStatesContext",
                column: "Id");
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
        }
    }
}
