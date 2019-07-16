using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCode.Piatnica.Api.Migrations
{
    public partial class eventName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EventsHistoriesContext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "EventsHistoriesContext");
        }
    }
}
