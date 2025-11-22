using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtsAndCrafts.Migrations
{
    /// <inheritdoc />
    public partial class AddPicturesToAllCraftObjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_CraftObjects_PatternId",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "PatternId",
                table: "Pictures",
                newName: "CraftObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_PatternId",
                table: "Pictures",
                newName: "IX_Pictures_CraftObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_CraftObjects_CraftObjectId",
                table: "Pictures",
                column: "CraftObjectId",
                principalTable: "CraftObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_CraftObjects_CraftObjectId",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "CraftObjectId",
                table: "Pictures",
                newName: "PatternId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_CraftObjectId",
                table: "Pictures",
                newName: "IX_Pictures_PatternId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_CraftObjects_PatternId",
                table: "Pictures",
                column: "PatternId",
                principalTable: "CraftObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
