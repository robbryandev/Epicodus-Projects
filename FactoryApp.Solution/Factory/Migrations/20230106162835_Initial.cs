using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
  public partial class Initial : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AlterDatabase()
          .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.CreateTable(
          name: "Engineers",
          columns: table => new
          {
            engineer_id = table.Column<int>(type: "int", nullable: false)
                  .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            name = table.Column<string>(type: "longtext", nullable: true)
                  .Annotation("MySql:CharSet", "utf8mb4")
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Engineers", x => x.engineer_id);
          })
          .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.CreateTable(
          name: "Machines",
          columns: table => new
          {
            machine_id = table.Column<int>(type: "int", nullable: false)
                  .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            name = table.Column<string>(type: "longtext", nullable: true)
                  .Annotation("MySql:CharSet", "utf8mb4")
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Machines", x => x.machine_id);
          })
          .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.CreateTable(
          name: "EngineerMachines",
          columns: table => new
          {
            engineer_machine_id = table.Column<int>(type: "int", nullable: false)
                  .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            engineer_id = table.Column<int>(type: "int", nullable: false),
            engineer_id1 = table.Column<int>(type: "int", nullable: true),
            machine_id = table.Column<int>(type: "int", nullable: false),
            machine_id1 = table.Column<int>(type: "int", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_EngineerMachines", x => x.engineer_machine_id);
            table.ForeignKey(
                      name: "FK_EngineerMachines_Engineers_engineer_id1",
                      column: x => x.engineer_id1,
                      principalTable: "Engineers",
                      principalColumn: "engineer_id");
            table.ForeignKey(
                      name: "FK_EngineerMachines_Machines_machine_id1",
                      column: x => x.machine_id1,
                      principalTable: "Machines",
                      principalColumn: "machine_id");
          })
          .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.CreateIndex(
          name: "IX_EngineerMachines_engineer_id1",
          table: "EngineerMachines",
          column: "engineer_id1");

      migrationBuilder.CreateIndex(
          name: "IX_EngineerMachines_machine_id1",
          table: "EngineerMachines",
          column: "machine_id1");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "EngineerMachines");

      migrationBuilder.DropTable(
          name: "Engineers");

      migrationBuilder.DropTable(
          name: "Machines");
    }
  }
}
