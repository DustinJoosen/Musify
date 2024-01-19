using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musify.API.Migrations
{
    /// <inheritdoc />
    public partial class removeApiKeyDtoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ApiKeys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys",
                column: "Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ApiKeys",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys",
                column: "Id");
        }
    }
}
