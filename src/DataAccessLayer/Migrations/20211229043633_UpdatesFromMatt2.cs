using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class UpdatesFromMatt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtensionApplied_Player_PlayerId",
                table: "ExtensionApplied");

            migrationBuilder.DropTable(
                name: "FranchiseTagApplied");

            migrationBuilder.DropIndex(
                name: "IX_ExtensionApplied_PlayerId",
                table: "ExtensionApplied");

            migrationBuilder.DropColumn(
                name: "FiveYearContracts",
                table: "Team");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerPosition",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerLastName",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerFirstName",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Extended",
                table: "ExtensionApplied",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Franchise",
                table: "ExtensionApplied",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "ExtensionApplied",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionApplied_PlayerId_TeamId",
                table: "ExtensionApplied",
                columns: new[] { "PlayerId", "TeamId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionApplied_TeamId",
                table: "ExtensionApplied",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtensionApplied_Player_PlayerId",
                table: "ExtensionApplied",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtensionApplied_Team_TeamId",
                table: "ExtensionApplied",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtensionApplied_Player_PlayerId",
                table: "ExtensionApplied");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtensionApplied_Team_TeamId",
                table: "ExtensionApplied");

            migrationBuilder.DropIndex(
                name: "IX_ExtensionApplied_PlayerId_TeamId",
                table: "ExtensionApplied");

            migrationBuilder.DropIndex(
                name: "IX_ExtensionApplied_TeamId",
                table: "ExtensionApplied");

            migrationBuilder.DropColumn(
                name: "Extended",
                table: "ExtensionApplied");

            migrationBuilder.DropColumn(
                name: "Franchise",
                table: "ExtensionApplied");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "ExtensionApplied");

            migrationBuilder.AddColumn<int>(
                name: "FiveYearContracts",
                table: "Team",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerPosition",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerLastName",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerFirstName",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "FranchiseTagApplied",
                columns: table => new
                {
                    FranchiseTagAppliedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    YearApplied = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.AddForeignKey(
                name: "FK_ExtensionApplied_Player_PlayerId",
                table: "ExtensionApplied",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
