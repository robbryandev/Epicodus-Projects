using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksLookupApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    park_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    state_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.park_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    state_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    park_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.state_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "park_id", "name", "state_id" },
                values: new object[,]
                {
                    { 1, "Acadia", 19 },
                    { 2, "American Samoa", 15 },
                    { 3, "Arches", 3 },
                    { 4, "Badlands", 10 },
                    { 5, "Big Bend", 11 },
                    { 6, "Biscayne", 6 },
                    { 7, "Black Canyon of the Gunnison", 4 },
                    { 8, "Bryce Canyon", 3 },
                    { 9, "Canyonlands", 3 },
                    { 10, "Capitol Reef", 3 },
                    { 11, "Carlsbad Caverns", 9 },
                    { 12, "Channel Islands", 1 },
                    { 13, "Congaree", 26 },
                    { 14, "Crater Lake", 25 },
                    { 15, "Cuyahoga Valley", 24 },
                    { 16, "Death Valley", 1 },
                    { 17, "Denali", 2 },
                    { 18, "Dry Tortugas", 6 },
                    { 19, "Everglades", 6 },
                    { 20, "Gates of the Arctic", 2 },
                    { 21, "Gateway Arch", 22 },
                    { 22, "Glacier", 12 },
                    { 23, "Glacier Bay", 2 },
                    { 24, "Grand Canyon", 5 },
                    { 25, "Grand Teton", 14 },
                    { 26, "Great Basin", 13 },
                    { 27, "Great Sand Dunes", 4 },
                    { 28, "Great Smoky Mountains", 31 },
                    { 29, "Guadalupe Mountains", 11 },
                    { 30, "Haleakalā", 8 },
                    { 31, "Hawai'i Volcanoes", 8 },
                    { 32, "Hot Springs", 16 },
                    { 33, "Indiana Dunes", 17 },
                    { 34, "Isle Royale", 20 },
                    { 35, "Joshua Tree", 1 },
                    { 36, "Katmai", 2 },
                    { 37, "Kenai Fjords", 2 },
                    { 38, "Kings Canyon", 1 },
                    { 39, "Kobuk Valley", 2 },
                    { 40, "Lake Clark", 2 },
                    { 41, "Lassen Volcanic", 1 },
                    { 42, "Mammoth Cave", 18 },
                    { 43, "Mesa Verde", 4 },
                    { 44, "Mount Rainier", 7 },
                    { 45, "New River Gorge", 28 },
                    { 46, "North Cascades", 7 },
                    { 47, "Olympic", 7 },
                    { 48, "Petrified Forest", 5 },
                    { 49, "Pinnacles", 1 },
                    { 50, "Redwood", 1 },
                    { 51, "Rocky Mountain", 4 },
                    { 52, "Saguaro", 5 },
                    { 53, "Sequoia", 1 },
                    { 54, "Shenandoah", 28 },
                    { 55, "Theodore Roosevelt", 23 },
                    { 56, "Virgin Islands", 27 },
                    { 57, "Voyageurs", 21 },
                    { 58, "White Sands", 9 },
                    { 59, "Wind Cave", 10 },
                    { 60, "Wrangell-St.Elias", 2 },
                    { 61, "Yellowstone", 12 },
                    { 62, "Yosemite", 1 },
                    { 63, "Zion", 3 }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "state_id", "name", "park_count" },
                values: new object[,]
                {
                    { 1, "California", 9 },
                    { 2, "Alaska", 8 },
                    { 3, "Utah", 5 },
                    { 4, "Colorado", 4 },
                    { 5, "Arizona", 3 },
                    { 6, "Florida", 3 },
                    { 7, "Washington", 3 },
                    { 8, "Hawaii", 2 },
                    { 9, "New Mexico", 2 },
                    { 10, "South Dakota", 2 },
                    { 11, "Texas", 2 },
                    { 12, "Montana", 2 },
                    { 13, "Nevada", 2 },
                    { 14, "Wyoming", 2 },
                    { 15, "American Samoa", 1 },
                    { 16, "Arkansas", 1 },
                    { 17, "Indiana", 1 },
                    { 18, "Kentucky", 1 },
                    { 19, "Maine", 1 },
                    { 20, "Michigan", 1 },
                    { 21, "Minnesota", 1 },
                    { 22, "Missouri", 1 },
                    { 23, "North Dakota", 1 },
                    { 24, "Ohio", 1 },
                    { 25, "Oregon", 1 },
                    { 26, "South Carolina", 1 },
                    { 27, "U.S. Virgin Islands", 1 },
                    { 28, "Virginia", 1 },
                    { 29, "West Virginia", 1 },
                    { 30, "Idaho", 1 },
                    { 31, "North Carolina", 1 },
                    { 32, "Tennessee", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
