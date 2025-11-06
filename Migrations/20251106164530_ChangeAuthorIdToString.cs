using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtsAndCrafts.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAuthorIdToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CraftObjects_AspNetUsers_AuthorId1",
                table: "CraftObjects");

            migrationBuilder.DropIndex(
                name: "IX_CraftObjects_AuthorId1",
                table: "CraftObjects");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "CraftObjects");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "CraftObjects",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CraftObjects_AuthorId",
                table: "CraftObjects",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CraftObjects_AspNetUsers_AuthorId",
                table: "CraftObjects",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CraftObjects_AspNetUsers_AuthorId",
                table: "CraftObjects");

            migrationBuilder.DropIndex(
                name: "IX_CraftObjects_AuthorId",
                table: "CraftObjects");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "CraftObjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "CraftObjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CraftObjects_AuthorId1",
                table: "CraftObjects",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CraftObjects_AspNetUsers_AuthorId1",
                table: "CraftObjects",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
