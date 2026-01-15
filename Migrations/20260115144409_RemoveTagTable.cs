using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtsAndCrafts.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTagTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatternTag");

            migrationBuilder.DropTable(
                name: "Tags");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatternTag",
                columns: table => new
                {
                    PatternsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternTag", x => new { x.PatternsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PatternTag_CraftObjects_PatternsId",
                        column: x => x.PatternsId,
                        principalTable: "CraftObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatternTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatternTag_TagsId",
                table: "PatternTag",
                column: "TagsId");
        }
    }
}
