using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tamrin.Migrations
{
    /// <inheritdoc />
    public partial class Changesomecode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RepeatPassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RepeatPassword",
                table: "Users");
        }
    }
}
