using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakersBnB.Migrations
{
    /// <inheritdoc />
    public partial class Rules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bedroom",
                table: "Spaces",
                newName: "Bedrooms");

            migrationBuilder.AddColumn<string>(
                name: "Rules",
                table: "Spaces",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rules",
                table: "Spaces");

            migrationBuilder.RenameColumn(
                name: "Bedrooms",
                table: "Spaces",
                newName: "Bedroom");
        }
    }
}
