using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NatlParks",
                columns: new[] { "NatlParkId", "Name", "State" },
                values: new object[] { 1, "Crater Lake National Park", "Oregon" });

            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Silver Falls State Park", "Oregon" },
                    { 2, "Fort Stevens State Park", "Oregon" },
                    { 3, "Cape Lookout State Park", "Oregon" },
                    { 4, "Smith Rock State Park", "Oregon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 4);
        }
    }
}
