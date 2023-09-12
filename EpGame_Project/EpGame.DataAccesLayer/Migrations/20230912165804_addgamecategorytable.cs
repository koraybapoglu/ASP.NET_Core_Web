using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpGame.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class addgamecategorytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameCategory_Categories_CategoryID",
                table: "GameCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_GameCategory_Games_GameID",
                table: "GameCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategory",
                table: "GameCategory");

            migrationBuilder.RenameTable(
                name: "GameCategory",
                newName: "GameCategories");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategory_GameID",
                table: "GameCategories",
                newName: "IX_GameCategories_GameID");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategory_CategoryID",
                table: "GameCategories",
                newName: "IX_GameCategories_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategories_Categories_CategoryID",
                table: "GameCategories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategories_Games_GameID",
                table: "GameCategories",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameCategories_Categories_CategoryID",
                table: "GameCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_GameCategories_Games_GameID",
                table: "GameCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories");

            migrationBuilder.RenameTable(
                name: "GameCategories",
                newName: "GameCategory");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategories_GameID",
                table: "GameCategory",
                newName: "IX_GameCategory_GameID");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategories_CategoryID",
                table: "GameCategory",
                newName: "IX_GameCategory_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategory",
                table: "GameCategory",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategory_Categories_CategoryID",
                table: "GameCategory",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategory_Games_GameID",
                table: "GameCategory",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
