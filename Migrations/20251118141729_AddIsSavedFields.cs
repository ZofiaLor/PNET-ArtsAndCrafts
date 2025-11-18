using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtsAndCrafts.Migrations
{
    /// <inheritdoc />
    public partial class AddIsSavedFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isSaved",
                table: "PatternUsers",
                newName: "IsSaved");

            migrationBuilder.AddColumn<bool>(
                name: "IsSaved",
                table: "YarnUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSaved",
                table: "ToolUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSaved",
                table: "YarnUsers");

            migrationBuilder.DropColumn(
                name: "IsSaved",
                table: "ToolUsers");

            migrationBuilder.RenameColumn(
                name: "IsSaved",
                table: "PatternUsers",
                newName: "isSaved");
        }
    }
}
