using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musify.MVC.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistQueueQueueId",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaylistQueueQueueId",
                table: "Playlists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaylistQueueQueueId",
                table: "Album",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlaylistQueue",
                columns: table => new
                {
                    QueueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongId = table.Column<int>(type: "int", nullable: true),
                    AlbumId = table.Column<int>(type: "int", nullable: true),
                    PlaylistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistQueue", x => x.QueueId);
                });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 2,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 3,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 4,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 5,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 7,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 8,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 9,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 10,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 11,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 12,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 13,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 14,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 15,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 16,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 17,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 18,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 19,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 20,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 21,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 22,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 23,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 24,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 25,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 26,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 27,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 28,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 29,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 30,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 31,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 32,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 33,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 34,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 35,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 36,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 37,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 38,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 39,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 40,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 2,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 3,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 4,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 5,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 7,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 8,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 9,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 10,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 11,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 12,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 13,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 14,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 15,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 16,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 17,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 18,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 19,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 20,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 21,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 22,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 23,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 24,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 25,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Hurt" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Folsom Prison Blues" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "A Boy Names Sue" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Dirt Off Your Shoulder" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Run This Town" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 34,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 35,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 36,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 37,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 38,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 39,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Delicate" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Purple Rain" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "When Doves Cry" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Kiss" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Little Red Corvette" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Raspberry Beret" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Smells Like Teen Spirit" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Come as You Are" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Heart-Shaped Box" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Lithium" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "In Bloom" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Umbrella" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Diamonds" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Only Girl" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Work" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "We Found Love" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Billie Jean" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Thriller" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Beat It" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Man in the Mirror" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Smooth Criminal" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Creep" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Karma Police" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Paranoid Android" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "No Suprises" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Fake Platic Threes" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Three Little Birds" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "No Woman, No Cry" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Redemption Song" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "One Love" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Buffalo Soldier" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Stairway to Heaven." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Whole Lotta Love" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Immigrant Song" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Black Dog" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Rock and Roll" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Your Song" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Rocket Man" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Tiny Dancer" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Goodbye Yellow Brick Road" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Bnnie and the Jets" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Treasure" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Angie" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Satisfaction" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "PlaylistQueueQueueId", "Title" },
                values: new object[] { null, "Sympathy for the Devil" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 100,
                column: "PlaylistQueueQueueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1976, 8, 16, 12, 49, 40, 375, DateTimeKind.Local).AddTicks(4493), "Faith Mayer", "$2a$10$YSrML7.0nNkxCTkSakmZQO9kM/s8wsqjOR0f26D3Teo1d1UspU2XO", "Sonya51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2003, 6, 28, 11, 30, 36, 413, DateTimeKind.Local).AddTicks(8963), "Kelli Kub", "$2a$10$zCcU0USKyoLublTk4hypTuYrmgVzqJ0O28F3O1pLhHkpVa5ps/UeS", "Aric_Lebsack98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1959, 3, 15, 1, 40, 46, 388, DateTimeKind.Local).AddTicks(5658), "Jane Bins", "$2a$10$EQri953EYOLQ1RPQddk7.OFdyO.w9/jY875nBxus7udSK5MEZsJzi", "Ara.Berge0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1955, 5, 25, 15, 29, 4, 201, DateTimeKind.Local).AddTicks(1074), "Luz Friesen", "$2a$10$CSqbVw03/ndcquguRfK.0uMYhIlu45LR7.PAayhHLIc1OhOsQiJEa", "Fabian.VonRueden29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1977, 12, 7, 3, 20, 19, 170, DateTimeKind.Local).AddTicks(4723), "Kelvin Turcotte", "$2a$10$6qP92pm3I8i7zEmlLtheWOiQazVq98r67UaWlPGY/w1ZhOUI91oZ2", "Murphy_Nitzsche" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2000, 1, 17, 22, 15, 1, 840, DateTimeKind.Local).AddTicks(767), "Dewey Tremblay", "$2a$10$apI3NGqjfUCwYOXoIo31ZuayN8Q4CxgdOOXIX6aiDFAo19yMeo4FG", "Lester_Nienow" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1979, 12, 18, 2, 56, 41, 249, DateTimeKind.Local).AddTicks(6095), "Kendra Crist", "$2a$10$.8VCGCkdOOPM0GTRBrxvUuMZD1hAhwxDNMBauqF5TKGf2noLtQO4S", "Drake66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2003, 1, 3, 21, 53, 16, 854, DateTimeKind.Local).AddTicks(2577), "Santiago Leuschke", "$2a$10$XCr8vZS1sWrULndP1p0UAO2M2DFSJYbCNDsGFwdjqt7KgBiDH57X6", "Emmanuel64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1993, 4, 10, 6, 12, 2, 185, DateTimeKind.Local).AddTicks(1948), "Christie Koch", "$2a$10$Lov3uKFqDWWg/iFmwqYgE.cdErtvB1Oq2E3/YAYbGCENg9QAhhW9a", "Joesph.Heidenreich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 1, 9, 21, 27, 49, 153, DateTimeKind.Local).AddTicks(6612), "Carole Hills", "$2a$10$9jwEuQIGa0.GC.X7mfgMvemNP1W5WzKcJNKcQ/44nLkOjp5o/SJfa", "Justyn_Gaylord24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1962, 9, 2, 2, 18, 14, 138, DateTimeKind.Local).AddTicks(3874), "Helen Kshlerin", "$2a$10$41NIGApaO8AJXpnTfHnOIeZdPJgbs16V1gr3Ai9gEZSeBu5P9efNe", "Halie.McGlynn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2000, 12, 27, 3, 19, 45, 164, DateTimeKind.Local).AddTicks(4662), "Inez Hodkiewicz", "$2a$10$sFkeU0kqQatETjXeEGHH8eCCRNLmVGDT2CfYc/1NQOn.Y04s.NsGC", "Woodrow_Nolan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1975, 10, 28, 6, 10, 49, 124, DateTimeKind.Local).AddTicks(1483), "Benjamin Rowe", "$2a$10$rswEMGmBxQhjjXPjXpcvi.s7cB13MsY2VCTLOzZebNCh4HKMj1kDS", "Felix34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1954, 3, 1, 14, 56, 16, 770, DateTimeKind.Local).AddTicks(7057), "Dwight Davis", "$2a$10$58DWCs/GTzPWS26q09YIgOeGTvME1R0ajyOmT0HzZvZ5MLmcxGCru", "Sonya60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1964, 11, 28, 20, 2, 45, 905, DateTimeKind.Local).AddTicks(6527), "Diana Legros", "$2a$10$UzMEUEEnaPAwdT4VILjM7OIP6DYoacaUUHAKrZ057h/Mgk6mxpUzK", "Estella.Crona" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 6, 3, 7, 36, 49, 548, DateTimeKind.Local).AddTicks(7125), "Shelley Fay", "$2a$10$VIN2E2rghU8HvT.oKytwSueKzW1ILie2dzX.wH7ZrkNik6KFAjx0e", "Roxane_Kulas94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1995, 10, 5, 22, 41, 33, 753, DateTimeKind.Local).AddTicks(4879), "Grady Rath", "$2a$10$KRZMfH2tQVhmeJRLW8doKO3dadFmF3W7/MbVGcmuP28GJoX2GUME.", "Cassandra83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1997, 3, 30, 20, 53, 56, 643, DateTimeKind.Local).AddTicks(7110), "Rex Braun", "$2a$10$5CEtAzKM6jOtSq2f.2P3CeNqmtH8LHJZeuq3BrPwDw1sCsNhPSH8m", "Loren_DAmore" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1967, 3, 27, 21, 59, 48, 96, DateTimeKind.Local).AddTicks(8174), "Violet Ledner", "$2a$10$nKOLhLBZCwhe/cS44nkLV.gojiW2Zt8zmUnRSZm61dyb4pZ8yiMPS", "Florian_Morar96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1958, 8, 9, 12, 10, 19, 118, DateTimeKind.Local).AddTicks(629), "Eileen Bergstrom", "$2a$10$p82tl1PQ.kXIyb2hkjw72uYHS5liJEl1tAK.k1RE2aGtSV7R2tsKe", "Roman69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1987, 2, 14, 16, 27, 7, 667, DateTimeKind.Local).AddTicks(9451), "Edith Kshlerin", "$2a$10$wZY1oB2SQCAujTHaI6jfc.k9zhGLKfLRpDMu/KTLbbs61nBPPg4Xe", "Ivory_Schuster" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1983, 2, 5, 22, 19, 2, 12, DateTimeKind.Local).AddTicks(3820), "Edmond Schumm", "$2a$10$ebdt7dK6T9RrU1XIvb3jj.urUfFnfDx5sCy5E44mgd5q5LBQFY5yi", "Desiree.Boyer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2000, 11, 10, 17, 15, 30, 754, DateTimeKind.Local).AddTicks(7582), "Brooke Block", "$2a$10$kZqDr0bfRu1m2noRL4Nk8uQuTRXXwmpjXkxcIkImWkwf0rwfmj.ia", "Cheyenne57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1988, 9, 29, 4, 56, 49, 470, DateTimeKind.Local).AddTicks(5077), "Willie Hegmann", "$2a$10$VU86K/pWzJn353zqM61d/uzbN0usp/nONZCXIoBTA4PIr3LE6GN9W", "Nathen_Leannon" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1979, 1, 21, 11, 36, 34, 911, DateTimeKind.Local).AddTicks(8417), "Beth Feil", "$2a$10$eDMLPxusTa6WVsvrmFD5oucTn9W3Wnb5U4DLWyPKTIsyZZMOqS8OG", "Una.Donnelly83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1975, 11, 7, 6, 21, 42, 890, DateTimeKind.Local).AddTicks(9200), "Vivian Stroman", "$2a$10$U75zXwXInH5rgz6IgURVQuK8TNw9NDTakLVfTkwPQmT.nZTbtvNQG", "Jodie_Conn77" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1963, 1, 20, 18, 52, 31, 665, DateTimeKind.Local).AddTicks(840), "Stanley Heidenreich", "$2a$10$tdrm9e97bXN3rjMjvvOyMOnTtUhXIrOfxuoLDFbZ2cJvuS/DjtfTK", "Gus_Muller80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1982, 10, 31, 13, 43, 43, 355, DateTimeKind.Local).AddTicks(978), "Phillip Lind", "$2a$10$1xNU3tKnVK65D0P8lX1QHeS58aOhhqNpYlBraDfYMyCD2C7FSANYW", "Vidal_Collins" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 9, 12, 8, 31, 30, 870, DateTimeKind.Local).AddTicks(150), "Terri Olson", "$2a$10$PkqDXDZz0aQxO75pAToVg.E7NtvZj8h6fH85bffVOELIbVy2c4puO", "Heather_Rippin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1994, 4, 15, 15, 50, 24, 537, DateTimeKind.Local).AddTicks(9783), "Christie Bauch", "$2a$10$44mon5B8K1hn7X0qbX/gqeVQDVKPM29erS23F26fARncwWwpJoE5u", "Destany70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1966, 12, 4, 4, 49, 26, 703, DateTimeKind.Local).AddTicks(2425), "Freddie Stark", "$2a$10$1dhysFqm.pXqvp7Pq3Ukvuop.Fcr2ns69ikBZU3HApvOQjOQN50gq", "Cordia.Johnston" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1987, 2, 1, 3, 24, 19, 238, DateTimeKind.Local).AddTicks(258), "Jermaine Leannon", "$2a$10$v76FLRb6GF8pf4wovyZS9eYZfEghkk63lF/6Kkldd3icVt496makm", "Corine80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1985, 8, 4, 21, 43, 48, 138, DateTimeKind.Local).AddTicks(2799), "Jon Quigley", "$2a$10$pBiWLByLjwAqIvUQP.bEVOmtGOKTrV0VrcOeowjAFSWZKY6xXsFNe", "Elda.Gerhold" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1992, 8, 5, 14, 20, 20, 502, DateTimeKind.Local).AddTicks(1957), "Forrest Kohler", "$2a$10$4ZvgeLgp2f0wHhcz8W0G/OovbNek5/Cv0jtsMVm4.Er1on9.amvCG", "Jace.Hagenes" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2000, 5, 25, 16, 23, 13, 248, DateTimeKind.Local).AddTicks(8566), "Carol Von", "$2a$10$w1NaEdgKeBv52Z22v3lhWepfzTz0KjrGFfQ8sThxBwCerEllh8L9O", "Duane67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1961, 10, 18, 21, 15, 30, 561, DateTimeKind.Local).AddTicks(9828), "Angelina Dare", "$2a$10$BVLmUuTJVRxdOjM36Cufuet2LSHEaxtZP8aS4HJgmM0HSj/LZW3lW", "Wilhelm37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 2, 22, 17, 52, 59, 475, DateTimeKind.Local).AddTicks(3407), "Brandon Glover", "$2a$10$aaLcnZt4JgpqVNl4slWxIO6UhIE3R92mzPmFGgcq9/.2dMP7oasaa", "Caleb_OHara53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1977, 3, 29, 20, 47, 20, 160, DateTimeKind.Local).AddTicks(465), "Tommy McClure", "$2a$10$7fFrRzWHC/1CzpR.XW6fSOlUT9IhTT2QEqTrqwyrOMU2jBgSRbv3m", "Hipolito.Ferry83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1979, 3, 30, 10, 52, 35, 11, DateTimeKind.Local).AddTicks(8356), "Yvette Bode", "$2a$10$TM2t.cb4jqSH5NDKDTveSOu9oUJ4Jnh52WUc9bBe4KmK2XwnxxtLi", "Rollin97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 8, 17, 2, 14, 26, 81, DateTimeKind.Local).AddTicks(4909), "Bryant Watsica", "$2a$10$Y84FUwjL4pgBBzZhv.Mw6u4vcWmYZEMpmVKsUQshhAgEF1Y.Vwbwu", "Darian_Daugherty27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1991, 5, 3, 7, 8, 23, 520, DateTimeKind.Local).AddTicks(6287), "Colin Fisher", "$2a$10$zmQxeBCxCF16zSeTNfv8rOOH9zyJKR3JUOGTstgg4OhsOPOeUY2aK", "Ana.Beer10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1996, 4, 28, 6, 47, 23, 626, DateTimeKind.Local).AddTicks(9544), "Glenn Frami", "$2a$10$SgG6BGud6TQmmoNyJtFosuMU3HJYamjRF6EjaeWPgnX2.toIh4odW", "Darrel.Reichel68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1966, 11, 9, 23, 55, 9, 947, DateTimeKind.Local).AddTicks(4503), "Woodrow Gleason", "$2a$10$KUsxchThppYgDTpMBawY9OZu.a0p2MiEvX0aa6cpaOS3gqBzcCrI.", "Cordie33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1985, 1, 16, 0, 44, 16, 731, DateTimeKind.Local).AddTicks(203), "Bert Ruecker", "$2a$10$E1J9jQHPavtMqWJW1oDjre1hyImGsSl9a2Wpg50B79ayHxaK4uI26", "Philip.Tillman15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2002, 10, 11, 3, 37, 19, 277, DateTimeKind.Local).AddTicks(2155), "Wilfred Wilderman", "$2a$10$OZuUMHNJ0YPDKx3hd7sCeebSZCC57EM2KOTYe0OxEoyxMhJjMra2O", "Wilton_Prosacco" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1977, 2, 26, 14, 31, 48, 858, DateTimeKind.Local).AddTicks(6587), "Bethany Ferry", "$2a$10$3aopTMObGghbCAc621ygU.CCMoJWoWeKJ/nkhnj5.TMiMbh1jlR9K", "Deshaun77" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1991, 9, 9, 1, 1, 6, 247, DateTimeKind.Local).AddTicks(3749), "Robin Wolff", "$2a$10$vqOEpe8qHOVfD9tEDRJoAeKbeRV7sPbfkMena5CaMRqotwMoNab7a", "Lenore.Bayer77" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1963, 4, 2, 14, 59, 19, 781, DateTimeKind.Local).AddTicks(1139), "Casey Lesch", "$2a$10$TfaqUdO4AqMWeAkwu9IQ8uqBrg/lUjf54nfiTmDCS.gXXZNacIWlK", "Hannah.Bogisich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1995, 11, 7, 20, 40, 19, 877, DateTimeKind.Local).AddTicks(7426), "Melba Hegmann", "$2a$10$sr5FV1I2AQDXnZsOudbPteKGoTk4vPEusuyuWNfemCiNdhdPlBnKa", "Cecile20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1964, 11, 25, 21, 46, 26, 833, DateTimeKind.Local).AddTicks(1398), "Hector Wiza", "$2a$10$3pmhbqsTpRU2drNDyQCozunrzOG1oZs1rhT8Sgk7KDPs77VpakTYy", "Rosalinda18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1982, 12, 6, 14, 21, 52, 564, DateTimeKind.Local).AddTicks(6312), "Brenda Hegmann", "$2a$10$rgG/AW438TZ.klRL9GJPIu9weXyG0npY.TNLatrGqlF7/beVMhow2", "Rex.Barton78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1999, 12, 25, 6, 9, 12, 239, DateTimeKind.Local).AddTicks(1656), "Yolanda Predovic", "$2a$10$hGBpG14fnDnu/XlPN9pQcedx0JXHA7lNPeM6qDyYrdLMnW59lJrkC", "Joyce_Herman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1989, 5, 27, 11, 57, 30, 687, DateTimeKind.Local).AddTicks(6005), "Kristen Jakubowski", "$2a$10$e60DzPFm2OvFD1FmDqUM4.TP5j8awzLrW.Jf/wqHQa3U8erTUU2mK", "Janis.Mante" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1976, 11, 6, 5, 30, 18, 917, DateTimeKind.Local).AddTicks(1544), "Javier Casper", "$2a$10$0hfkVqRSRbN7mBdDsVBT/O6ADN0lT5aSTwLLfTppI2BpT6xAbwSuS", "Furman.Bailey60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1969, 10, 13, 3, 17, 46, 231, DateTimeKind.Local).AddTicks(1757), "Geoffrey Weimann", "$2a$10$KLSfS2A4WdNSLiVTlfAXIeDuLhB00YLcI0psLj2Z4xZvHlI0Z2.Au", "Lucio.Steuber" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 7, 22, 21, 37, 59, 751, DateTimeKind.Local).AddTicks(7620), "Jack Terry", "$2a$10$02KAsuPnsnkwLXbVFBwA2eFC4Fd6bf87DWLJjQd.vD/rJZ9ud7OXy", "Soledad_Balistreri34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1989, 3, 19, 14, 43, 21, 701, DateTimeKind.Local).AddTicks(9556), "Lillie Cartwright", "$2a$10$Yct00AL6ksmgM.v1SlITOurX9prNlx.KPexR0CFb9.VmWGLsBCBym", "Claude.Beatty" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1968, 11, 4, 1, 49, 28, 26, DateTimeKind.Local).AddTicks(7754), "Becky Mante", "$2a$10$TQiTAUoONURHJpUNPSSn1eza4WefnIi5w53q5g0g2QxF0DFFiwovS", "Jaylin_Schinner65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1994, 12, 6, 19, 9, 37, 31, DateTimeKind.Local).AddTicks(8000), "Cecelia Hills", "$2a$10$OLj2Ge96e2nSf8Rb7UJRO.D1Sgvg.aHHeJFODBA/vAO6Eg3t0v5Nq", "Minerva_Prosacco34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1998, 12, 20, 6, 45, 38, 193, DateTimeKind.Local).AddTicks(9058), "Lula Mohr", "$2a$10$PSrfSf/9oreKPZMj8WI74uaHNbtTssvt7Pi9OmfGWfbhVxFCVAsCW", "Agustin_Rodriguez" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2001, 1, 1, 20, 33, 31, 85, DateTimeKind.Local).AddTicks(7331), "Charlie Anderson", "$2a$10$.93YARqcIQOn0qh8hehxdOe6RHm47pyZ8QJV1PDLT8Vv3by3WhKlu", "Lelah_Welch70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1972, 6, 23, 3, 34, 20, 675, DateTimeKind.Local).AddTicks(696), "Alvin Heller", "$2a$10$p2gUnwsXIxrIXdWVLEGLbu/midoB1v0NrIbPVVJTK6RmJHYyeXRLa", "Ernie_Daniel21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1954, 8, 23, 0, 17, 10, 411, DateTimeKind.Local).AddTicks(2796), "Beatrice Metz", "$2a$10$z29bKTioW7KoqyPE0QbqhO0ImvgRxo/FT8JaMNK3/2j3kkgcNm2Rm", "Franco.Smith" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1985, 7, 28, 9, 26, 50, 435, DateTimeKind.Local).AddTicks(7827), "Freddie Koepp", "$2a$10$A4CzTsSCLFWUHZ0rSX/1WOb7gZEYQDaV4jUwE/ej6mPJITWZI6tqW", "Rickey_Casper" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1982, 7, 13, 20, 47, 59, 88, DateTimeKind.Local).AddTicks(9075), "Amy O'Hara", "$2a$10$yUpSrj1bOkoo5VUO11cpIugg26hJFFW4M91j44x3PvYuetJAeEEci", "Adaline6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1973, 1, 26, 6, 33, 9, 461, DateTimeKind.Local).AddTicks(1272), "Brittany Pfannerstill", "$2a$10$2y1tJk4f8.RTdU2GGNHys.0spYQ6QHGUHu.8LNYcQoonYnTV0.PIa", "Anna52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1983, 10, 10, 9, 39, 28, 752, DateTimeKind.Local).AddTicks(2737), "Rosemary Dare", "$2a$10$jCjFNsRjZuaSOgfGU6hny.c.vP/8/oRe52XquBvapMV8ip4V8LXFC", "Sammy_Bruen" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1985, 3, 13, 22, 57, 33, 192, DateTimeKind.Local).AddTicks(893), "Vanessa McGlynn", "$2a$10$LF9v2l2.pQKHIFceNTWkh./rNNm/AKIRWw2jF1tHIQ4IdJahqldtu", "Eva.Conroy84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1968, 2, 25, 10, 22, 40, 741, DateTimeKind.Local).AddTicks(1197), "Irene Hilpert", "$2a$10$ozSE.ay1KFRrIIzntUIMa.CClYXg0gRMpxPSq1uPGfqHA3lVFPjbm", "Zoe.Morissette" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1999, 8, 29, 3, 52, 35, 102, DateTimeKind.Local).AddTicks(4858), "Madeline Schaefer", "$2a$10$aXx9BYZSGoIuxKMXgberJ.yEzYKPL2p6t5fDpPrJpmWmciGfOTubK", "Myrtie46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1993, 9, 11, 19, 41, 47, 187, DateTimeKind.Local).AddTicks(8200), "Cornelius Farrell", "$2a$10$4QNt6RncaQm4EAtpGP/R6ei7fzaKzdIwVNfrEWY.yTGq0feJ8Xd9u", "Jackeline29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1998, 4, 17, 3, 54, 47, 408, DateTimeKind.Local).AddTicks(8783), "Holly Lindgren", "$2a$10$o5hmOKDXKRBKMuL25DLL5elVYPievme0w/rxA4anSZKP9E9IdI2.C", "Darryl67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1982, 1, 23, 14, 42, 20, 291, DateTimeKind.Local).AddTicks(3547), "Charlotte Schaefer", "$2a$10$8mdWyt4wzkR7rINKn3qocuG1lf9XlWyQXZz7tUzbu9CZO80gZvgdm", "Alberta.Willms74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1996, 7, 4, 15, 21, 36, 640, DateTimeKind.Local).AddTicks(965), "Wilma Greenfelder", "$2a$10$GPkrYBzfMXPB6Rl5bJqmp.Jjj1Zbz5e9CaI7nmEGCoWnwtOMd5TSm", "Arch_Gottlieb7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1963, 5, 13, 20, 10, 49, 994, DateTimeKind.Local).AddTicks(256), "Rosa Gleason", "$2a$10$ZwDs76coKnZ9ZlJQx6T7A.r72yiLZ66SRtFN13F.0WOr4Eh6P37Ua", "Fredrick_Baumbach45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1982, 7, 17, 5, 11, 31, 361, DateTimeKind.Local).AddTicks(7368), "Thomas Okuneva", "$2a$10$qMggfhaj61x27xPZij5KsuaLN2mgjObjFaeOGFZ83MgAL35D3h5zG", "Citlalli_Hamill" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1991, 1, 25, 11, 27, 31, 286, DateTimeKind.Local).AddTicks(8093), "Janie Boehm", "$2a$10$N0ZakDfUnxyu9Pu8dUS05O08U6cUnyzA5RtRSwDa5H1eDWpDRbD7K", "Amir35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1972, 5, 7, 13, 24, 33, 88, DateTimeKind.Local).AddTicks(1622), "Maryann O'Reilly", "$2a$10$zAEU8zBybhHo/WhGVZYo6e9mQUTLT1izJ4lj//j2cRgwTJbCBHcxu", "Gordon.Beatty15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1961, 10, 13, 1, 8, 58, 581, DateTimeKind.Local).AddTicks(2132), "Katrina Maggio", "$2a$10$.aCP0skNAHbgrdfutOKL.eDDwJrGkNeJrohTwwYEyffSOuwg9x/pe", "Matt91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1988, 12, 15, 8, 17, 43, 133, DateTimeKind.Local).AddTicks(998), "Rachael Ebert", "$2a$10$edTvzZhnVziXJAIyhCOQZOACCO0KED5/49JAuZLXbv2NFBG1DV7/u", "Kaley44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1994, 10, 4, 5, 53, 27, 717, DateTimeKind.Local).AddTicks(2951), "Velma Ullrich", "$2a$10$A/C3q6jEk7mJNsyo2M2h3.JyIu14DpfzLAEbafeEIMg.cVkqi7HI2", "Leland_Koch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2002, 9, 13, 14, 55, 21, 298, DateTimeKind.Local).AddTicks(6668), "Clint Schowalter", "$2a$10$.ZdOKohY8CXD819bvBsyXO6P/LmFXGQ8SKW94FsJFvHncJ8cXrDRC", "Ayden_Lueilwitz36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 3, 15, 8, 8, 44, 395, DateTimeKind.Local).AddTicks(9704), "Don Yost", "$2a$10$Q8MZ97JGq6q/STuL/Iu7dOFTFrIl5jO7uH1yTABYBr75B.CC32mXe", "Carlo34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1976, 10, 31, 14, 38, 24, 477, DateTimeKind.Local).AddTicks(1398), "Rolando Marquardt", "$2a$10$AlIvHfBY9M5UajdMXBaT2.JCr.wIAafcUi87Y3ljQSs3NXRBHEyU2", "Arnaldo_Hegmann81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1975, 2, 17, 3, 43, 34, 543, DateTimeKind.Local).AddTicks(96), "Dexter McDermott", "$2a$10$AOcnE3jLWbq7CcntprL2BOm8hQ99Q0ESl/fKcN477gfs.vJmvQGh6", "Sylvia.Swaniawski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1973, 4, 30, 16, 7, 2, 349, DateTimeKind.Local).AddTicks(1574), "Emanuel Hamill", "$2a$10$/O/GQFVToM0eouCDkkpBQunm1F8ZY5juGUT1/j/2IfaTTW0LisEvi", "Bernard_Adams17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1992, 6, 28, 9, 39, 57, 117, DateTimeKind.Local).AddTicks(4605), "Jacquelyn Swift", "$2a$10$CzwftXFouL.po1Zs/ihOw.MWOI.DonP0g7pUzX99yBeuSwAo98wYC", "Bud.Bahringer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 11, 13, 15, 22, 0, 963, DateTimeKind.Local).AddTicks(1661), "Lindsey Ziemann", "$2a$10$QJJJ7EKQoPUwXOmMaHJR1OIO.6lPupoGPS/2I7HciYeaVhRXAEYUS", "Maya.Kessler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1989, 1, 7, 10, 23, 28, 837, DateTimeKind.Local).AddTicks(7920), "Pam Goldner", "$2a$10$A8/B0cOvz/ZaQBmEvCLmPO0G0CcoQIc8FzSmFjOid.H32y66yLhlS", "Rahsaan57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1978, 8, 23, 4, 18, 21, 110, DateTimeKind.Local).AddTicks(2123), "Noah Predovic", "$2a$10$MldOO25n3m0qBPXCrxYwfu444cmPsp5FfVQYUdK3YCTa5VVi9Dt5O", "Elody47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1974, 7, 21, 17, 36, 33, 131, DateTimeKind.Local).AddTicks(2850), "Christy Osinski", "$2a$10$FKguqPSNXFu7V5tUfDeRSeqj1bC3Xs3jwheBiTewmfNgRN0J9YQlu", "Nico.Leuschke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1954, 8, 22, 3, 40, 22, 347, DateTimeKind.Local).AddTicks(3653), "Darla Carter", "$2a$10$2OMqhSsd5o3EHpWcHISh/.n4gziIZXsyjcCoOsOaepqDFfmsPLmqy", "Elton.Cartwright85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1976, 8, 18, 16, 38, 18, 587, DateTimeKind.Local).AddTicks(5788), "Lisa Stokes", "$2a$10$aD/zBYt3EkIrmEbFPk/HbuXptMTkaVEDxlBO7o4lDd26zU1qbAkDi", "Imelda_Quigley" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1999, 6, 14, 5, 1, 0, 521, DateTimeKind.Local).AddTicks(1368), "Ismael Raynor", "$2a$10$cafOviM7BarlXp10ikQ.meOm5HHoFzHB1fzdo8Zx6DKBVJplboY/q", "Makayla_Ebert23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1966, 1, 24, 5, 36, 59, 992, DateTimeKind.Local).AddTicks(9345), "Patti Fritsch", "$2a$10$k4jm3cKSUgum3ajPuq8XN.vT4p1TkOANxNcYDY.Whsc.oqdY2N4KS", "Albert_Crist" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1997, 2, 6, 17, 44, 59, 323, DateTimeKind.Local).AddTicks(6269), "Martha Bins", "$2a$10$fszw53HEjplcVsL4HesoM.R7MJvfgXB0rf6lAzfjdgCsd.qrdHL7S", "Edwardo63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1975, 11, 23, 19, 38, 32, 931, DateTimeKind.Local).AddTicks(5038), "Teri Kohler", "$2a$10$LgnOndl/h4UpUDRNU2ffu.FvewL/dT5XxP4qo33wfzwHDl94Y9fWe", "Blair43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1958, 8, 2, 2, 59, 22, 112, DateTimeKind.Local).AddTicks(9518), "Cathy Rau", "$2a$10$pjhENBOBBVaLdCx7WE2cmu18RdJRqwh1FJYAg31G9By/npBkXmTFC", "Irving.Hermann42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1966, 1, 24, 0, 24, 32, 32, DateTimeKind.Local).AddTicks(8039), "Joe Walker", "$2a$10$0oyyG3TxxQCSQvBPT4UJBOdESFfRVEs8RY6EITSZaWwelm9slhswK", "Izabella_Howell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1982, 11, 5, 9, 22, 47, 307, DateTimeKind.Local).AddTicks(1601), "Gerald Kessler", "$2a$10$yEAcyQjHj5tx7siN.XEK.es8Nzy22OLNLXssOjBBrJTr8ExW30oyO", "Ona_Wisozk94" });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PlaylistQueueQueueId",
                table: "Songs",
                column: "PlaylistQueueQueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_PlaylistQueueQueueId",
                table: "Playlists",
                column: "PlaylistQueueQueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_PlaylistQueueQueueId",
                table: "Album",
                column: "PlaylistQueueQueueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_PlaylistQueue_PlaylistQueueQueueId",
                table: "Album",
                column: "PlaylistQueueQueueId",
                principalTable: "PlaylistQueue",
                principalColumn: "QueueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_PlaylistQueue_PlaylistQueueQueueId",
                table: "Playlists",
                column: "PlaylistQueueQueueId",
                principalTable: "PlaylistQueue",
                principalColumn: "QueueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_PlaylistQueue_PlaylistQueueQueueId",
                table: "Songs",
                column: "PlaylistQueueQueueId",
                principalTable: "PlaylistQueue",
                principalColumn: "QueueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_PlaylistQueue_PlaylistQueueQueueId",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_PlaylistQueue_PlaylistQueueQueueId",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_PlaylistQueue_PlaylistQueueQueueId",
                table: "Songs");

            migrationBuilder.DropTable(
                name: "PlaylistQueue");

            migrationBuilder.DropIndex(
                name: "IX_Songs_PlaylistQueueQueueId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_PlaylistQueueQueueId",
                table: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Album_PlaylistQueueQueueId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "PlaylistQueueQueueId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "PlaylistQueueQueueId",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "PlaylistQueueQueueId",
                table: "Album");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Folsom Prison Blues");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Hurt");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Man in Black");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "Holy Grail");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Title",
                value: "Big Pimpin'");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40,
                column: "Title",
                value: "Bad Blood");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41,
                column: "Title",
                value: "Uptown Funk");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42,
                column: "Title",
                value: "Just the Way You Are");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43,
                column: "Title",
                value: "Grenade");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44,
                column: "Title",
                value: "24K Magic");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45,
                column: "Title",
                value: "Locked Out of Heaven");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46,
                column: "Title",
                value: "Go Your Own Way");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47,
                column: "Title",
                value: "Dreams");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48,
                column: "Title",
                value: "The Chain");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49,
                column: "Title",
                value: "Landslide");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50,
                column: "Title",
                value: "Rhiannon");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51,
                column: "Title",
                value: "Paint It Black");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52,
                column: "Title",
                value: "Sympathy for the Devil");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53,
                column: "Title",
                value: "Gimme Shelter");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54,
                column: "Title",
                value: "Angie");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55,
                column: "Title",
                value: "Start Me Up");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56,
                column: "Title",
                value: "Bohemian Rhapsody");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57,
                column: "Title",
                value: "Another One Bites the Dust");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58,
                column: "Title",
                value: "We Will Rock You");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59,
                column: "Title",
                value: "Somebody to Love");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60,
                column: "Title",
                value: "Don't Stop Me Now");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61,
                column: "Title",
                value: "Highway to Hell");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62,
                column: "Title",
                value: "Back in Black");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63,
                column: "Title",
                value: "Thunderstruck");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64,
                column: "Title",
                value: "You Shook Me All Night Long");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65,
                column: "Title",
                value: "T.N.T.");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66,
                column: "Title",
                value: "Space Oddity");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67,
                column: "Title",
                value: "Heroes");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68,
                column: "Title",
                value: "Let's Dance");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69,
                column: "Title",
                value: "Starman");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70,
                column: "Title",
                value: "Life on Mars?");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71,
                column: "Title",
                value: "HUMBLE.");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72,
                column: "Title",
                value: "Alright");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73,
                column: "Title",
                value: "DNA.");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74,
                column: "Title",
                value: "Swimming Pools (Drank)");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75,
                column: "Title",
                value: "King Kunta");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76,
                column: "Title",
                value: "Shake It Off");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77,
                column: "Title",
                value: "Blank Space");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78,
                column: "Title",
                value: "Love Story");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79,
                column: "Title",
                value: "You Belong with Me");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80,
                column: "Title",
                value: "Bad Blood");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83,
                column: "Title",
                value: "Grenade");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92,
                column: "Title",
                value: "Sympathy for the Devil");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93,
                column: "Title",
                value: "Gimme Shelter");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94,
                column: "Title",
                value: "Angie");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1969, 10, 28, 4, 16, 20, 859, DateTimeKind.Local).AddTicks(1554), "Dianna Purdy", "$2a$10$J6aZSS3jEn3RDclkIX0z4OhaE4fd5pNKQzK3h6aKkLJTLCoP3D/T6", "Marguerite79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1961, 7, 6, 0, 17, 30, 787, DateTimeKind.Local).AddTicks(9100), "Abel Steuber", "$2a$10$eGkyBalW4SLW5lls4WGbxuYPg0Uicl3x.Xq7ZddByXvhnl9.mdoEi", "Travis.Hettinger" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1987, 1, 20, 14, 50, 56, 415, DateTimeKind.Local).AddTicks(6921), "Ross Koepp", "$2a$10$nCMLb.o3SxwedjXsfBx6Zu74aac/oBKrFtWvc6lj9QkHmjwRK4YQ2", "Thalia_Littel68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1975, 7, 16, 10, 11, 1, 675, DateTimeKind.Local).AddTicks(3856), "Ryan Russel", "$2a$10$emLrdNg3xI.9cmeWhDwyROCC2F8ArK38AW9p4MeoL0ilEL3tJGzsS", "Tommie94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1989, 5, 25, 3, 17, 15, 296, DateTimeKind.Local).AddTicks(9772), "Benjamin Wilderman", "$2a$10$SzIg817c8dDp7uYvC/skFuVVbwAFgPFuPrBMtBIojVyVIYCLpqMtO", "Vincent.Simonis" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2002, 12, 23, 22, 54, 27, 831, DateTimeKind.Local).AddTicks(9853), "Jennifer Doyle", "$2a$10$9tDZzhGIR9uWpTwovHxG/.1A5u6d307xJSJdNCTzVkdzL9vdrDfo.", "Kavon.Crona" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1983, 5, 8, 14, 35, 57, 720, DateTimeKind.Local).AddTicks(147), "Sean Kutch", "$2a$10$ajaijSRfDOAfFuguGo5LW.HLiwGqvPTeFcMU4KrgvZ7oj94TRVmj6", "Dena_Padberg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1999, 8, 25, 4, 32, 50, 631, DateTimeKind.Local).AddTicks(65), "Irene Harber", "$2a$10$TPzOWBImWq3oMQ19o6XsqOPFom6ZiWwLtQUYQISnsmiJuujonIoPO", "Brendan_Dooley" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1962, 5, 26, 0, 6, 30, 853, DateTimeKind.Local).AddTicks(1178), "Moses Schiller", "$2a$10$.gosPA.2EHrpyG8oprbfAuB/8sOgVHfvd1mTjzaB7Q4DJDTkCxOwy", "Faustino.Crona51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1956, 2, 20, 9, 30, 49, 213, DateTimeKind.Local).AddTicks(2679), "Leon Jacobi", "$2a$10$3Vp9drsnQ6bkMNKNxYdTK.nlGywFaiGduxgVZdAgzdlNw6YdOdEZe", "Maxime_Durgan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1988, 8, 20, 20, 55, 42, 956, DateTimeKind.Local).AddTicks(8429), "Alicia Wunsch", "$2a$10$LYFqyQyosrDS.zyCylaJCuTGcMGSzH9Q2qE8Oi2WvqCtQ3JrDEzGS", "Benny.Kshlerin74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1963, 1, 3, 20, 51, 39, 405, DateTimeKind.Local).AddTicks(7824), "Tomas Jones", "$2a$10$9yMjcHI8UDK4YGB6YdFwoOBnJeiegMDPVlJkU6./UbnKpgveQdTmm", "Diana_Hilpert55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1997, 6, 12, 21, 27, 30, 92, DateTimeKind.Local).AddTicks(5082), "Terence Orn", "$2a$10$yermrxBIQY5nhOl.FAh.ZOHigV5IU4jKUPG8OFxybNJcxMZCxROf.", "Wellington.Mayert" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 8, 31, 23, 37, 37, 509, DateTimeKind.Local).AddTicks(4938), "Jeff Langosh", "$2a$10$V.BFvHwKayJE9ageb1gOauTgCrD2YpPUuhNu/Zpn9oFo.Uid6CLHe", "Petra_Treutel22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1974, 6, 7, 12, 50, 44, 395, DateTimeKind.Local).AddTicks(8852), "Alma Moen", "$2a$10$rf6vAboo08vIlAAq9YUf6e6B7qPYnYzgdgSztpuFTbOF2WOE4koSS", "Sabrina_Rutherford" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1956, 7, 17, 9, 32, 46, 159, DateTimeKind.Local).AddTicks(1076), "Ronnie Ratke", "$2a$10$gNiXtJYcjqPE8vKs71A/9Oea/Eo0SJFhmN29KfCltMLrGL.pOaoFW", "Lisandro_Bednar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1989, 8, 24, 11, 55, 22, 486, DateTimeKind.Local).AddTicks(1049), "Lester Cronin", "$2a$10$4NZlcHZJqncDV5Ypg8s91uMurkx1XXrk8B2NOWG10e75zm0AD9Im.", "Berneice6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1974, 9, 25, 5, 10, 38, 290, DateTimeKind.Local).AddTicks(9658), "Mona Weissnat", "$2a$10$5T4ZHAlEKWuFZeSo2VlxiOQ7l.jqekvYA.BnJwMvjWP0tzEHuB9aO", "Adriel_Ernser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1992, 7, 17, 15, 54, 21, 795, DateTimeKind.Local).AddTicks(5132), "Jared Hermiston", "$2a$10$cvA/btgAfjbxfz3.yeGCXOqAfT2y0fUFwqGtkAOXe32wTy.3kITXu", "Delpha.Waelchi43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 10, 31, 14, 15, 31, 691, DateTimeKind.Local).AddTicks(546), "Martha Runte", "$2a$10$OdxrXhdwo7aQgH.VVLYWn.7icmdql5IDGUGFbXZHCZH.F/ypPEpFW", "Carleton94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1992, 3, 9, 16, 20, 42, 918, DateTimeKind.Local).AddTicks(1393), "Wilson Lynch", "$2a$10$5O3tg7QUPHCVJCkSPYV5EOhhdEe6C1XIUIRdSNnoSDaO2OnqJI09a", "Rogers49" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1959, 5, 20, 4, 4, 17, 756, DateTimeKind.Local).AddTicks(3176), "Linda Pfeffer", "$2a$10$xYEUiTUUhYYWQ7h6r1jLmOwI4PV7rJ7pxYQGm8UFdVUTcQBBKZWZe", "Ruby_Greenholt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2000, 9, 14, 9, 29, 17, 589, DateTimeKind.Local).AddTicks(8810), "Dawn Harvey", "$2a$10$pZmtWXGHdwLt3Z2QUg60Qe/9vDxlrQ4Yq2LoeIJ6xl0hALyJ5pWZ6", "Lester.Gutmann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1998, 6, 2, 18, 8, 50, 688, DateTimeKind.Local).AddTicks(9159), "Matt Douglas", "$2a$10$M/J8QSqGdjHniqWK1.QjX.oAh4veZ6.HjX.W.ZmNiVfYwlkJAOZtG", "Orlo62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1998, 6, 9, 17, 32, 42, 251, DateTimeKind.Local).AddTicks(3227), "Jessie Wiza", "$2a$10$HqIEBh4P4zFd9A8YCituuud/vctljnmUa2AUlEq7waHq3kKKbQ5n.", "Darby_Langworth10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1976, 10, 26, 19, 59, 15, 963, DateTimeKind.Local).AddTicks(5769), "Penny Stoltenberg", "$2a$10$HotWexcw.Vzr9s3OO6UrtON7vF1MI11rGL4Wwr8G0RY0ZLGkh8tPy", "Chaim.Armstrong" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1996, 8, 24, 19, 1, 27, 958, DateTimeKind.Local).AddTicks(2462), "Opal Bradtke", "$2a$10$3Wd8xb3HeDEm6wW3paK1V.Sv9MNrezO1C4HBmQ6BR5iaa6JXc8YIm", "Joesph_Rohan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1980, 4, 1, 23, 13, 28, 592, DateTimeKind.Local).AddTicks(5761), "Douglas Howe", "$2a$10$cUjD2/ICTN1uIGDFaG7RL.tfQKMWo8siOQK/udwmLSFUVlwzGeEde", "Ludie.Funk61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1998, 6, 29, 10, 16, 49, 683, DateTimeKind.Local).AddTicks(9164), "Jessie Bogisich", "$2a$10$DZJoammEiR8WvSvC8N8iUOIdckHC8Hn5Eiuzp1XAkrbs/lCAxpeb.", "Tressa_Kreiger" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1988, 2, 19, 14, 24, 40, 581, DateTimeKind.Local).AddTicks(9821), "Darla Carroll", "$2a$10$PHQpnfJBvCr.umocyJ/KQe.dXh5rREbUWgPGR4ZXwYifAgaD9by0y", "Felicity.Flatley" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2002, 10, 6, 22, 34, 55, 123, DateTimeKind.Local).AddTicks(5002), "Roderick Altenwerth", "$2a$10$6cjMA93BgYzD0vtFHPXpJOW/x6lNC2f0FmsFWkuj7Mh69Qj3sjFai", "Freddy97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1972, 11, 30, 15, 35, 58, 114, DateTimeKind.Local).AddTicks(9425), "Martha Pouros", "$2a$10$3LsSUSN/HbZZxXLOVn0qPOubcI4pkW0x.FBfajUMcVt58xLARghO.", "Adan.Klein" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1964, 1, 23, 20, 29, 14, 820, DateTimeKind.Local).AddTicks(9099), "Joanne Rodriguez", "$2a$10$LAd/a.y3q/HcjfH7MYs64ONVyA6GSSniDIEMLw09qYIIX8HL7OYvS", "Charley85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1978, 10, 12, 22, 49, 0, 181, DateTimeKind.Local).AddTicks(9479), "Casey Tremblay", "$2a$10$dRe8o19IS/sfjdT9kkgWEOOoiOapIg3dW.20R1PIHSjhHWBzojVRO", "Eli_Sanford" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1963, 6, 26, 9, 30, 30, 37, DateTimeKind.Local).AddTicks(550), "Jody Fahey", "$2a$10$T9t5fCPa97sKUSTOnshipeHZnOHvTEund9dlpYoZWjMQyzGcXrc4C", "Hettie_Mohr80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2002, 12, 17, 9, 12, 5, 474, DateTimeKind.Local).AddTicks(4004), "Marlene Greenfelder", "$2a$10$AdbUR6uDKoPMqF0rUNyaDez9.30QwkmDtv/mFCOBxI.2ofpiJr6xG", "Carmine.Fritsch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1989, 8, 26, 5, 43, 10, 876, DateTimeKind.Local).AddTicks(1284), "Arthur Lubowitz", "$2a$10$HwwmLxxhIWleSnd4Si0HiOqL.R/ZBYYuTv/foq1RQC1YfBUm9Gktq", "Bennie35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1964, 8, 8, 19, 58, 47, 937, DateTimeKind.Local).AddTicks(5743), "Ashley Pfannerstill", "$2a$10$7KR9F1FwvdssOZagJrjg3OvLq2CBLIOXSTjyNUA2OhYK2kLms7cti", "Mateo98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1958, 8, 15, 14, 30, 59, 150, DateTimeKind.Local).AddTicks(6430), "Terri Willms", "$2a$10$xb3kcwiZdOkdcWe6WHgdIu.xUP2KbLQfbCbVXEmXcS7CpHTBZD5ra", "Jeffry_Bahringer95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1998, 1, 6, 10, 43, 23, 196, DateTimeKind.Local).AddTicks(9902), "Josephine Bode", "$2a$10$TWDoJKdo9lRZaZ0wxhp/Zu9lL/.cRHbXAdo7j2h3y20HfRUl5QhKK", "Tyra.Klein98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1959, 10, 24, 18, 53, 0, 589, DateTimeKind.Local).AddTicks(6479), "Janet Zieme", "$2a$10$ZtE1e3v3OyTWkbIVXUZawOv3wNmxMaQCFIhHB4QVQdNlPX/paV1i2", "Enrico82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1969, 10, 19, 8, 34, 49, 949, DateTimeKind.Local).AddTicks(1540), "Otis Kassulke", "$2a$10$olsooymxreeTo1LT3jh9tOqn8byNa682NqzriS1tIOygYeKkH/y82", "Josue_Sporer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1973, 1, 22, 21, 46, 34, 805, DateTimeKind.Local).AddTicks(4038), "Saul Murazik", "$2a$10$DaKFWe6hDU/fzT9WALFhMuekk.2hxqi/c9PRg9XaQfBf7yu0zaf1K", "Murl54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1974, 7, 21, 10, 23, 11, 773, DateTimeKind.Local).AddTicks(2066), "Jean Bauch", "$2a$10$r2xPLAOwSo1ess90T/c.h.MpYzboLrms.sbd5ofUD0pDIJXKHqTFS", "Una_DAmore52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1991, 6, 16, 2, 17, 18, 967, DateTimeKind.Local).AddTicks(7131), "Sally Ratke", "$2a$10$7MycGxVW9LeY6h6WjvjR4e7AgoEUVOSixr2xNJpp/6aMFAKe3iQia", "Bernice.Wilderman56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1976, 11, 27, 1, 25, 43, 703, DateTimeKind.Local).AddTicks(3294), "Gail McDermott", "$2a$10$mMMi4zNkp1V4PrpjeSmTNuP8SVNnXbLKVxDEH3EDB0B1hcci8beZa", "Malinda.Bosco" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1990, 7, 12, 12, 1, 39, 893, DateTimeKind.Local).AddTicks(5808), "Alan Gutkowski", "$2a$10$0VYX9zstcQP9O13CAfGHbO/1blsvejXKK5BT1TYnC6xW4fs1L48me", "Shane13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 7, 27, 6, 1, 52, 300, DateTimeKind.Local).AddTicks(3189), "Morris Grady", "$2a$10$rT1uUntXUxpXM6K43cEDfeGtLO6Yzh2CBFA0NJZQaLSwx9THtMQoW", "Martin27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1954, 11, 28, 20, 52, 31, 174, DateTimeKind.Local).AddTicks(4766), "Olga White", "$2a$10$e2CfnWpMTH.PGS.GROwdyeBTd5oLnqgyeXyN2.In6zf.xN0UCx7iq", "Maxine98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1999, 5, 24, 3, 46, 0, 530, DateTimeKind.Local).AddTicks(6971), "Winston Dare", "$2a$10$8OZr2x5VQVK.RCEpDOar2eI8lslgnqUqAQ3XxgctzPiJUc95H58IC", "Jude_Smitham" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1997, 2, 4, 1, 41, 4, 486, DateTimeKind.Local).AddTicks(7829), "Lewis Abshire", "$2a$10$pEpxB6iTx2Fg6.6MRjYpC.M2PLWoA81Wq8dzsp9UFguW3SotfuV12", "Kendrick_Torphy19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1991, 12, 10, 4, 55, 55, 743, DateTimeKind.Local).AddTicks(4952), "Shelly Reynolds", "$2a$10$CgIKre7FGiqeKiF17zn3Bu0ZAEUOlO7njDEY4zyS2GpHbwbO2Be0e", "Shakira.Fisher" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1992, 1, 14, 1, 29, 18, 42, DateTimeKind.Local).AddTicks(3163), "Malcolm Zboncak", "$2a$10$BvNLMPFylPEoxuCiUr5xJOjqq7tvdwPlNYJPxIumQqsPdQqwdtNOe", "Wyman37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1997, 3, 7, 10, 16, 6, 598, DateTimeKind.Local).AddTicks(2435), "Eric Nader", "$2a$10$0w4ylfUEE0/zdRarp77hqurWaCJYzvluwdR.J6R/EOSHrpkEl7Dri", "Orpha_Schuster10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1995, 12, 4, 14, 0, 29, 347, DateTimeKind.Local).AddTicks(8684), "Charles Hyatt", "$2a$10$vj9UeCrNK/Ioi1Jbv60r7eCFHrSCNoN89JRoTAqj2lwf0COLVo/2y", "Marisa.Jenkins96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1998, 3, 17, 15, 25, 34, 100, DateTimeKind.Local).AddTicks(3708), "Chris Luettgen", "$2a$10$xoYjUOhsLvj9aVQIYpVX0OHH5o61OvwXcUbu.tGDW9SbMSE9rpAlO", "Pascale82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1966, 6, 9, 11, 24, 31, 108, DateTimeKind.Local).AddTicks(7530), "Roderick Dietrich", "$2a$10$G.73A2KcrGz7Bf2TXFZAMeNiQQOqInq/srrtbhsx08ZPfRIutNibi", "Justyn88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1980, 6, 7, 5, 45, 16, 589, DateTimeKind.Local).AddTicks(2344), "Mindy Tremblay", "$2a$10$MJ1F5ILxiQ8IlA4YuufRHOE9FdvgU8Axk3/gGoFFdNhKVtUxZDwMW", "Samantha78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1967, 3, 20, 2, 41, 55, 970, DateTimeKind.Local).AddTicks(9785), "Antonia Thompson", "$2a$10$BeODujgN59bCIcROD7N3W.WbLkYsBxS/PZ9DvKwlqlKyAIaWBygnC", "Maida.King" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1963, 2, 16, 13, 28, 40, 186, DateTimeKind.Local).AddTicks(8217), "Olga Armstrong", "$2a$10$WtEvqzqTysPeXIgUWqvgyOusDKmoRrQFCSaD.QHaxK37Bwici4u3O", "Clementina.Kunde" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1967, 10, 10, 17, 17, 33, 848, DateTimeKind.Local).AddTicks(7626), "Sally Nader", "$2a$10$nDiU7CXQW8uHSGt5MLV7sei2Nc4hdPhY81ZTkq5Yb.rajX5Yc58VS", "Pietro.Lakin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1963, 1, 17, 17, 8, 24, 488, DateTimeKind.Local).AddTicks(9899), "Winston Bartell", "$2a$10$wh0ez95j5S2oI/O3Hzn.8OzBU5fyr8/x2aORxbzPDoXnDSGB0c1Qq", "Carleton61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1985, 2, 13, 2, 13, 23, 1, DateTimeKind.Local).AddTicks(2659), "Ida Muller", "$2a$10$CAAowUR6NSgbFvbgQapyPO8cNa81cwRArsn.H4gY1TbvhAnUq7kh2", "Kenya.Rosenbaum" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1969, 7, 1, 17, 44, 55, 147, DateTimeKind.Local).AddTicks(9749), "Lori Goyette", "$2a$10$tM3oYeODhpFvJ0EgxGYMLO6cVBARlOcXxtPmZ/dxwcaHoZQ7Dsn8O", "Kaden29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1955, 12, 9, 13, 11, 26, 358, DateTimeKind.Local).AddTicks(8903), "Cindy Kerluke", "$2a$10$GHEwjhzT8INvn2WwUGXrQOSU1/N4Rsh0Q54hfG/GFsC1g0HWrFXLu", "Ethel.Hettinger72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1961, 9, 15, 3, 3, 30, 354, DateTimeKind.Local).AddTicks(76), "Marshall Leuschke", "$2a$10$Fbk3dKcGqYKEgWaTmluPw.1OLzbGfhXuHS2L5s3NOVlLUqnVOsw3S", "Kurtis58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1992, 6, 17, 3, 12, 12, 399, DateTimeKind.Local).AddTicks(3835), "Roland Hermiston", "$2a$10$oV1WaHttKorYas7F4NPY/ud99HaTL5j4FYnwX3QaVAr9pG80WEabq", "Lee_Mills" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1994, 11, 26, 3, 2, 0, 883, DateTimeKind.Local).AddTicks(6247), "Jacob Dickinson", "$2a$10$fnHFe8Nv/90UM4Y6bn.6Re/sKcOubRRo7.p.T8BqXVrrJE/kuRURC", "Tressa8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1994, 8, 16, 7, 50, 31, 275, DateTimeKind.Local).AddTicks(353), "Violet Kuhic", "$2a$10$hsFXLBfdn47q1nvSRCVRletf7nLOwaEU/tW5bHLwlHGzq4vAzoeu2", "Aurelio.Schuppe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2001, 12, 12, 15, 47, 9, 924, DateTimeKind.Local).AddTicks(5366), "Spencer Gutkowski", "$2a$10$.ODoXt4aSDv5IWT25/tKBuFXKKMg/fpiTWpVL63hc88HQe4MJC86K", "Kellen_Zboncak51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1957, 9, 26, 15, 44, 55, 674, DateTimeKind.Local).AddTicks(8632), "Stewart Kautzer", "$2a$10$C3ul8/bUopuU44s59bgpuOPLjD7A4nrdx47n1EyempPbio6pLMIsS", "Dante_Corwin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1988, 11, 28, 7, 1, 42, 106, DateTimeKind.Local).AddTicks(4364), "Kristin Schmeler", "$2a$10$NUiq6KQpSwvtPHPdaw5.SeNR27pABDY9W1p5HUF9O/f7ipOXoBaUm", "Teresa.Bernier95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 1, 13, 4, 22, 10, 702, DateTimeKind.Local).AddTicks(8808), "Jonathan Keebler", "$2a$10$qDH1AY/4GqAZBeQlv0I0EO/13e8c5lVFuk3sumHlsUPlq25oQSdou", "Misael97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1974, 3, 16, 0, 36, 0, 511, DateTimeKind.Local).AddTicks(7295), "Tracy Russel", "$2a$10$W.mMgQ1h8QAO/cTPH.hDp.r3JBl3JwoFj.EHmyvqkHVf20HTilC8C", "Jamarcus_Graham" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1992, 10, 7, 1, 49, 36, 175, DateTimeKind.Local).AddTicks(4587), "Dean Smitham", "$2a$10$3F8TkmLeLEagVKNJUdfJZejc9x6vPR97XNyWhNku85A7PjwFxDd4K", "Rosa_Yost" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1976, 6, 25, 20, 26, 54, 653, DateTimeKind.Local).AddTicks(2061), "Wayne Johns", "$2a$10$XoLszc3xVx8XjfEMkW3QFuK0NVcWcV7cj965x.14fMm.o3pZmqngy", "Kara_Ferry" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1973, 2, 12, 23, 44, 59, 670, DateTimeKind.Local).AddTicks(2353), "Megan Koepp", "$2a$10$aHfAALRLfqvFihd.Xwgtte2JlX.6d1zRLLrNdubs.0yfzX1Qv2Xva", "Jena.Roberts" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1984, 4, 25, 14, 34, 1, 656, DateTimeKind.Local).AddTicks(3092), "Eddie Howell", "$2a$10$.GW05r9I5OnsNa88vbjh8.p14iSeQJ0iVOrhPsNtHsPZhuM6aKSSq", "Luigi33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1990, 6, 4, 2, 42, 33, 963, DateTimeKind.Local).AddTicks(5673), "Jeannette Nolan", "$2a$10$UwLQh2tcqCSxNykKUtutFe/CI4s6y04pDF1GASViCfCana4v1QeUu", "Shad_Swaniawski34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 4, 25, 12, 50, 24, 508, DateTimeKind.Local).AddTicks(8166), "Judith Green", "$2a$10$NT62JSeXHW8BtaqsMZYBp.mM.zvAtBWTeRSUMtvXtEwkTJ3QfCBi.", "Timothy6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1970, 6, 3, 15, 37, 23, 789, DateTimeKind.Local).AddTicks(6505), "Melinda Swift", "$2a$10$u8Dr2jkqh47VkW1kEei40.I8AU7iz9S888Aa73m/iXDh4MfW9cp/G", "Emma_Brown9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1966, 5, 13, 2, 16, 3, 498, DateTimeKind.Local).AddTicks(8231), "Angela Davis", "$2a$10$2CmYT0gqIQhQDO5FWClzv.F1R3prChoiQYpKI6kZQr47x94Wlg9dy", "Ward.Williamson" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1990, 12, 29, 12, 51, 8, 35, DateTimeKind.Local).AddTicks(9270), "Jessie Feest", "$2a$10$BGfzMfDcriYXYu/LUrkH9.MYfcjC3bIkvyZyonvF1WhZ4BIkJskIm", "Miller_Cummings66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1984, 7, 23, 19, 1, 36, 269, DateTimeKind.Local).AddTicks(6494), "Eunice Bradtke", "$2a$10$GuBYUwAAOGMgwEZU7w9k5.6ExxHBB6IzSORc4h7pzJpp3734MRSke", "Tina_Gleason" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1977, 8, 19, 16, 48, 8, 545, DateTimeKind.Local).AddTicks(5667), "Aaron Dare", "$2a$10$aRLVVvjZ4q9t0SLCn9dCl.kcx5FghuvqOzW0y.g7a2seM4KARdm5e", "Dee_Hammes33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1966, 10, 23, 2, 49, 42, 188, DateTimeKind.Local).AddTicks(564), "Michael Adams", "$2a$10$l022sluVH9A18yAb1oh4rOhkZOLR6n9iz9CumjBfVMsofqthCP/Xy", "Van_Heller" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1975, 8, 8, 0, 33, 53, 328, DateTimeKind.Local).AddTicks(5450), "Rosemary King", "$2a$10$fp6dHCL1xOBFqvEMZRjo3O1axHFNPaDtXuzJC3t3OvsWXkXrMjZzu", "Jena.Koch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2000, 8, 9, 12, 53, 46, 232, DateTimeKind.Local).AddTicks(3876), "Mamie Bernier", "$2a$10$P/2VNvdGsMBB1adErCeF0.qLVxs6HXcouvzBg6td9Zp7.QgJa9BlO", "Julian.Durgan74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1970, 7, 20, 1, 36, 7, 901, DateTimeKind.Local).AddTicks(9126), "Loren Lemke", "$2a$10$O1qly5YIyX.KH/ObBjGoP.PAsgNd9kabtRdYoWsTsgLw.LpNI8CpW", "Sebastian_Gislason47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2000, 3, 26, 12, 11, 17, 714, DateTimeKind.Local).AddTicks(4960), "Herbert Klocko", "$2a$10$PCujEVgZB49pdzauZrk85.u/cm3CPh6rTM5ZtHwvU57foGwbGxquS", "Saul.Morar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1993, 1, 31, 10, 41, 7, 66, DateTimeKind.Local).AddTicks(8652), "Joanna Koelpin", "$2a$10$5BXXiikV4lEb/VqdoSbTT.FI5bp4cBzRrAjGeFv/QpAx96VM/.CVG", "Janice39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 2, 22, 15, 35, 18, 354, DateTimeKind.Local).AddTicks(7367), "Essie Schaden", "$2a$10$afByenEHJ2OtoOhStgrtx.4HN67F7VKGvTmEhgEcBtj3WcJw5LcC.", "Krystel_West" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(2003, 6, 28, 16, 20, 57, 105, DateTimeKind.Local).AddTicks(3078), "Marvin West", "$2a$10$IgUotLJQ2QW8p6CcyLj6X.drlGhGDh88hdute0jFYXINoEgpeegYu", "Hillard88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1986, 11, 13, 13, 49, 43, 981, DateTimeKind.Local).AddTicks(7341), "Jermaine Braun", "$2a$10$BRT1d8DpsrtjXbjSA.p2iOoQOmXHDg.PPHviCJypaQ.BW4pPB5bQS", "Maximillian.Bergnaum" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1971, 3, 27, 17, 2, 7, 327, DateTimeKind.Local).AddTicks(2337), "Gayle Macejkovic", "$2a$10$eshi6c2XS8oqoxn6WeUg.u0slgSrVdSVUG97JLogCsyS1MdqMU/CK", "Charley_Erdman20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1965, 4, 7, 14, 35, 18, 913, DateTimeKind.Local).AddTicks(4392), "Natasha Waters", "$2a$10$6SdSV/iGyxSbL9GSCWyC5.ocxA9VuTlOGk0uoDu8vCmtXZbNROYNy", "Ramona.Schaefer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1997, 11, 29, 14, 27, 43, 589, DateTimeKind.Local).AddTicks(6915), "Cecelia Harvey", "$2a$10$JchaKvIuiXKvg91NlpATz.CthDmxcCJLR/yAT.iBBBNNS620I6DDq", "Karianne.Dietrich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1977, 12, 28, 22, 1, 24, 856, DateTimeKind.Local).AddTicks(4307), "Ramona Schroeder", "$2a$10$UuSEr8BzIvC/Hkyymqv7zO.wkCe8aRqSlvd0FqSQCXztqSl4EYjR2", "Lawrence91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1982, 1, 26, 17, 11, 35, 763, DateTimeKind.Local).AddTicks(756), "Kristie Trantow", "$2a$10$K0LcYfso78bUUdCa.9nMvuARsqojx2MTA0BaQlKpw3grc1XcC7PP.", "Reece.Jakubowski46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "Name", "Password", "Username" },
                values: new object[] { new DateTime(1975, 9, 29, 19, 28, 10, 648, DateTimeKind.Local).AddTicks(5679), "Wilson Volkman", "$2a$10$jEezvWwpdKYiY2hFBhYfG.XRb6YU2jku0FgCPTDD4nFahrJazAOKm", "Layla_Hoeger52" });
        }
    }
}
