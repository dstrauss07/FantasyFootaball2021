using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migrateplease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<int>(type: "int", nullable: false),
                    FiveYearContracts = table.Column<int>(type: "int", nullable: false),
                    FourYearContracts = table.Column<int>(type: "int", nullable: false),
                    ThreeYearContracts = table.Column<int>(type: "int", nullable: false),
                    TwoYearContracts = table.Column<int>(type: "int", nullable: false),
                    OneYearContracts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractYears = table.Column<int>(type: "int", nullable: false),
                    PlayerFirstName = table.Column<int>(type: "int", nullable: false),
                    PlayerLastName = table.Column<int>(type: "int", nullable: false),
                    PlayerAge = table.Column<int>(type: "int", nullable: false),
                    PlayerPosition = table.Column<int>(type: "int", nullable: false),
                    SleeperPlayerId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionApplied",
                columns: table => new
                {
                    ExtensionAppliedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearApplied = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionApplied", x => x.ExtensionAppliedId);
                    table.ForeignKey(
                        name: "FK_ExtensionApplied_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FranchiseTagApplied",
                columns: table => new
                {
                    FranchiseTagAppliedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearApplied = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FranchiseTagApplied", x => x.FranchiseTagAppliedId);
                    table.ForeignKey(
                        name: "FK_FranchiseTagApplied_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionApplied_PlayerId",
                table: "ExtensionApplied",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FranchiseTagApplied_PlayerId",
                table: "FranchiseTagApplied",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtensionApplied");

            migrationBuilder.DropTable(
                name: "FranchiseTagApplied");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
