using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtsAndCrafts.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatternTool_CraftObjects_PatternsId",
                table: "PatternTool");

            migrationBuilder.DropForeignKey(
                name: "FK_PatternTool_CraftObjects_ToolsId",
                table: "PatternTool");

            migrationBuilder.DropForeignKey(
                name: "FK_PatternYarn_CraftObjects_YarnsId",
                table: "PatternYarn");

            migrationBuilder.DropIndex(
                name: "IX_PatternTool_ToolsId",
                table: "PatternTool");

            migrationBuilder.RenameColumn(
                name: "YarnsId",
                table: "PatternYarn",
                newName: "ToolsId");

            migrationBuilder.RenameIndex(
                name: "IX_PatternYarn_YarnsId",
                table: "PatternYarn",
                newName: "IX_PatternYarn_ToolsId");

            migrationBuilder.AddColumn<int>(
                name: "PatternsId1",
                table: "PatternTool",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YarnsId",
                table: "PatternTool",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatternTool_PatternsId1",
                table: "PatternTool",
                column: "PatternsId1");

            migrationBuilder.CreateIndex(
                name: "IX_PatternTool_YarnsId",
                table: "PatternTool",
                column: "YarnsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatternTool_CraftObjects_PatternsId1",
                table: "PatternTool",
                column: "PatternsId1",
                principalTable: "CraftObjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatternTool_CraftObjects_YarnsId",
                table: "PatternTool",
                column: "YarnsId",
                principalTable: "CraftObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatternYarn_CraftObjects_ToolsId",
                table: "PatternYarn",
                column: "ToolsId",
                principalTable: "CraftObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatternTool_CraftObjects_PatternsId1",
                table: "PatternTool");

            migrationBuilder.DropForeignKey(
                name: "FK_PatternTool_CraftObjects_YarnsId",
                table: "PatternTool");

            migrationBuilder.DropForeignKey(
                name: "FK_PatternYarn_CraftObjects_ToolsId",
                table: "PatternYarn");

            migrationBuilder.DropIndex(
                name: "IX_PatternTool_PatternsId1",
                table: "PatternTool");

            migrationBuilder.DropIndex(
                name: "IX_PatternTool_YarnsId",
                table: "PatternTool");

            migrationBuilder.DropColumn(
                name: "PatternsId1",
                table: "PatternTool");

            migrationBuilder.DropColumn(
                name: "YarnsId",
                table: "PatternTool");

            migrationBuilder.RenameColumn(
                name: "ToolsId",
                table: "PatternYarn",
                newName: "YarnsId");

            migrationBuilder.RenameIndex(
                name: "IX_PatternYarn_ToolsId",
                table: "PatternYarn",
                newName: "IX_PatternYarn_YarnsId");

            migrationBuilder.CreateIndex(
                name: "IX_PatternTool_ToolsId",
                table: "PatternTool",
                column: "ToolsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatternTool_CraftObjects_PatternsId",
                table: "PatternTool",
                column: "PatternsId",
                principalTable: "CraftObjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatternTool_CraftObjects_ToolsId",
                table: "PatternTool",
                column: "ToolsId",
                principalTable: "CraftObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatternYarn_CraftObjects_YarnsId",
                table: "PatternYarn",
                column: "YarnsId",
                principalTable: "CraftObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
