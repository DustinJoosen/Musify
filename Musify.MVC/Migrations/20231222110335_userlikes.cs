using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musify.MVC.Migrations
{
    /// <inheritdoc />
    public partial class userlikes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAlbumLikes",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAlbumLikes", x => new { x.AlbumId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserAlbumLikes_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAlbumLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserArtistLikes",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArtistLikes", x => new { x.ArtistId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserArtistLikes_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserArtistLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserPlaylistLikes",
                columns: table => new
                {
                    PlaylistId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlaylistLikes", x => new { x.PlaylistId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserPlaylistLikes_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPlaylistLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserSongLikes",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSongLikes", x => new { x.SongId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserSongLikes_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSongLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAlbumLikes_UserId",
                table: "UserAlbumLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserArtistLikes_UserId",
                table: "UserArtistLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlaylistLikes_UserId",
                table: "UserPlaylistLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSongLikes_UserId",
                table: "UserSongLikes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAlbumLikes");

            migrationBuilder.DropTable(
                name: "UserArtistLikes");

            migrationBuilder.DropTable(
                name: "UserPlaylistLikes");

            migrationBuilder.DropTable(
                name: "UserSongLikes");
        }
    }
}
