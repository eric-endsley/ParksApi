using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class ResetMigrationNewProjectName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NatlParks",
                columns: table => new
                {
                    NatlParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatlParks", x => x.NatlParkId);
                });

            migrationBuilder.CreateTable(
                name: "StateParks",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateParks", x => x.StateParkId);
                });

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
            migrationBuilder.DropTable(
                name: "NatlParks");

            migrationBuilder.DropTable(
                name: "StateParks");
        }
    }
}
