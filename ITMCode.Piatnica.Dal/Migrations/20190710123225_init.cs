using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Piatnica.Dal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventsContext",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsContext", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrdersContext",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersContext", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DistancesHistoryContext",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    distance = table.Column<double>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    Eventid = table.Column<int>(nullable: true),
                    orderid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistancesHistoryContext", x => x.id);
                    table.ForeignKey(
                        name: "FK_DistancesHistoryContext_EventsContext_Eventid",
                        column: x => x.Eventid,
                        principalTable: "EventsContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DistancesHistoryContext_OrdersContext_orderid",
                        column: x => x.orderid,
                        principalTable: "OrdersContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationsHistoriesContext",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    longitude = table.Column<double>(nullable: false),
                    latitudeL = table.Column<double>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    orderid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationsHistoriesContext", x => x.id);
                    table.ForeignKey(
                        name: "FK_LocationsHistoriesContext_OrdersContext_orderid",
                        column: x => x.orderid,
                        principalTable: "OrdersContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersEntriesContext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    orderType = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    fromTime = table.Column<DateTime>(nullable: false),
                    toTime = table.Column<DateTime>(nullable: false),
                    cargo = table.Column<string>(nullable: true),
                    comments = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    orderid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersEntriesContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersEntriesContext_OrdersContext_orderid",
                        column: x => x.orderid,
                        principalTable: "OrdersContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersStatesContext",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    state = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    orderid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatesContext", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrdersStatesContext_OrdersContext_orderid",
                        column: x => x.orderid,
                        principalTable: "OrdersContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DelaysContext",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    delayOrder = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    OrderEntryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelaysContext", x => x.id);
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
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    date = table.Column<DateTime>(nullable: false),
                    Eventid = table.Column<int>(nullable: true),
                    OrderEntryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsHistoriesContext", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventsHistoriesContext_EventsContext_Eventid",
                        column: x => x.Eventid,
                        principalTable: "EventsContext",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_DistancesHistoryContext_Eventid",
                table: "DistancesHistoryContext",
                column: "Eventid");

            migrationBuilder.CreateIndex(
                name: "IX_DistancesHistoryContext_orderid",
                table: "DistancesHistoryContext",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_EventsHistoriesContext_Eventid",
                table: "EventsHistoriesContext",
                column: "Eventid");

            migrationBuilder.CreateIndex(
                name: "IX_EventsHistoriesContext_OrderEntryId",
                table: "EventsHistoriesContext",
                column: "OrderEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationsHistoriesContext_orderid",
                table: "LocationsHistoriesContext",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersEntriesContext_orderid",
                table: "OrdersEntriesContext",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersStatesContext_orderid",
                table: "OrdersStatesContext",
                column: "orderid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DelaysContext");

            migrationBuilder.DropTable(
                name: "DistancesHistoryContext");

            migrationBuilder.DropTable(
                name: "EventsHistoriesContext");

            migrationBuilder.DropTable(
                name: "LocationsHistoriesContext");

            migrationBuilder.DropTable(
                name: "OrdersStatesContext");

            migrationBuilder.DropTable(
                name: "EventsContext");

            migrationBuilder.DropTable(
                name: "OrdersEntriesContext");

            migrationBuilder.DropTable(
                name: "OrdersContext");
        }
    }
}
