using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpGame.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddGameTableProducerNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProducerName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProducerName",
                table: "Games");
        }
    }
}
