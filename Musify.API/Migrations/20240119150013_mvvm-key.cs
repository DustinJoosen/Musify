using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musify.API.Migrations
{
    /// <inheritdoc />
    public partial class mvvmkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApiKeys",
                columns: new[] { "Key", "CreatedAt", "ExpirationDate", "Permissions", "UserId" },
                values: new object[] { "c9e6b2a15e2d4f8a9b1c76b8a3d5f2e07f1a8d6e9b3c4a2f8e", new DateTime(2024, 1, 19, 15, 0, 11, 622, DateTimeKind.Utc).AddTicks(4637), null, 2, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApiKeys",
                keyColumn: "Key",
                keyValue: "c9e6b2a15e2d4f8a9b1c76b8a3d5f2e07f1a8d6e9b3c4a2f8e");
        }
    }
}
