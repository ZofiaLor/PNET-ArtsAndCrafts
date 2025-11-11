using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtsAndCrafts.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyPattern : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CraftObjects_CraftObjects_PatternId",
                table: "CraftObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_CraftObjects_CraftObjects_Yarn_PatternId",
                table: "CraftObjects");

            migrationBuilder.DropIndex(
                name: "IX_CraftObjects_PatternId",
                table: "CraftObjects");

            migrationBuilder.DropIndex(
                name: "IX_CraftObjects_Yarn_PatternId",
                table: "CraftObjects");

            migrationBuilder.DropColumn(
                name: "PatternId",
                table: "CraftObjects");

            migrationBuilder.DropColumn(
                name: "Yarn_PatternId",
                table: "CraftObjects");

            migrationBuilder.CreateTable(
                name: "PatternTool",
                columns: table => new
                {
                    PatternsId = table.Column<int>(type: "int", nullable: false),
                    ToolsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternTool", x => new { x.PatternsId, x.ToolsId });
                    table.ForeignKey(
                        name: "FK_PatternTool_CraftObjects_PatternsId",
                        column: x => x.PatternsId,
                        principalTable: "CraftObjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatternTool_CraftObjects_ToolsId",
                        column: x => x.ToolsId,
                        principalTable: "CraftObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatternYarn",
                columns: table => new
                {
                    PatternsId = table.Column<int>(type: "int", nullable: false),
                    YarnsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternYarn", x => new { x.PatternsId, x.YarnsId });
                    table.ForeignKey(
                        name: "FK_PatternYarn_CraftObjects_PatternsId",
                        column: x => x.PatternsId,
                        principalTable: "CraftObjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatternYarn_CraftObjects_YarnsId",
                        column: x => x.YarnsId,
                        principalTable: "CraftObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatternTool_ToolsId",
                table: "PatternTool",
                column: "ToolsId");

            migrationBuilder.CreateIndex(
                name: "IX_PatternYarn_YarnsId",
                table: "PatternYarn",
                column: "YarnsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatternTool");

            migrationBuilder.DropTable(
                name: "PatternYarn");

            migrationBuilder.AddColumn<int>(
                name: "PatternId",
                table: "CraftObjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Yarn_PatternId",
                table: "CraftObjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CraftObjects_PatternId",
                table: "CraftObjects",
                column: "PatternId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftObjects_Yarn_PatternId",
                table: "CraftObjects",
                column: "Yarn_PatternId");

            migrationBuilder.AddForeignKey(
                name: "FK_CraftObjects_CraftObjects_PatternId",
                table: "CraftObjects",
                column: "PatternId",
                principalTable: "CraftObjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CraftObjects_CraftObjects_Yarn_PatternId",
                table: "CraftObjects",
                column: "Yarn_PatternId",
                principalTable: "CraftObjects",
                principalColumn: "Id");
        }
    }
}
