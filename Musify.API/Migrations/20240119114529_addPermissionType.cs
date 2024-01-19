using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musify.API.Migrations
{
    /// <inheritdoc />
    public partial class addPermissionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Permissions",
                table: "ApiKeys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permissions",
                table: "ApiKeys");
        }
    }
}
