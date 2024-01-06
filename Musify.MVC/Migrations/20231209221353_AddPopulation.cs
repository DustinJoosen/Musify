using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Musify.MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddPopulation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistImage", "Genre", "Name" },
                values: new object[,]
                {
                    { 1, "beyonce.png", "R&B/Pop", "Beyoncé" },
                    { 2, "johnnycash.png", "Country", "Johnny Cash" },
                    { 3, "madonna.png", "Pop", "Madonna" },
                    { 4, "jayz.png", "Hip-Hop/Rap", "Jay-Z" },
                    { 5, "adcd.png", "Rock", "AC/DC" },
                    { 6, "davidbowie.png", "Rock", "David Bowie" },
                    { 7, "kendricklamar.png", "Hip-Hop/Rap", "Kendrick Lamar" },
                    { 8, "taylorswift.png", "Pop/Country", "Taylor Swift" },
                    { 9, "prince.png", "Funk/R&B", "Prince" },
                    { 10, "nirvana.png", "Grunge/Rock", "Nirvana" },
                    { 11, "rihanna.png", "R&B/Pop", "Rihanna" },
                    { 12, "michaeljackson.png", "Pop/R&B", "Michael Jackson" },
                    { 13, "radiohead.png", "Alternative/Rock", "Radiohead" },
                    { 14, "bobmarley.png", "Reggae", "Bob Marley" },
                    { 15, "ledzeppelin.png", "Rock", "Led Zeppelin" },
                    { 16, "eltonhohn.png", "Pop/Rock", "Elton John" },
                    { 17, "brunomars.png", "Pop/R&B", "Bruno Mars" },
                    { 18, "fleetwoodmac.png", "Rock", "Fleetwood Mac" },
                    { 19, "rollingstones.png", "Rock", "The Rolling Stones" },
                    { 20, "queen.png", "Rock", "Queen" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 3, 7, 17, 43, 19, 544, DateTimeKind.Local).AddTicks(3206), "Carroll Conroy", "$2a$10$JjfphovsAgxEb5ghnTOoQuj4CnF12zxEKL8lr8eV9KAMKOPxYN79u", "Wayne.Cronin27" },
                    { 2, new DateTime(1963, 9, 30, 11, 59, 55, 676, DateTimeKind.Local).AddTicks(3356), "Theodore Conn", "$2a$10$WGnEZ2pBR0tPRAjVZmQdR.6fhg1bbcijZ18uzimn51IrOchI.qOCW", "Janis_Abshire72" },
                    { 3, new DateTime(1958, 10, 20, 4, 45, 19, 708, DateTimeKind.Local).AddTicks(7529), "Marty Shields", "$2a$10$.oW.wtdDqRbwmdlacefZqekO5K4aKTD6AIv4ufB2cwPbCQ588NL6a", "Lola_Herman43" },
                    { 4, new DateTime(1973, 8, 31, 7, 2, 30, 848, DateTimeKind.Local).AddTicks(3317), "Ronald Hammes", "$2a$10$afqTavFgrh4naun3xzkQ7uIHWpip1h9s7pJa7Zv5hMZrKojUG3loi", "Telly_OReilly" },
                    { 5, new DateTime(1966, 6, 4, 21, 21, 39, 373, DateTimeKind.Local).AddTicks(3726), "Genevieve Reinger", "$2a$10$FNJ8SZFTMz9n.zO/LD5yKubyrNsxBaktIvPJncmtddUSpJAWJnbxm", "Neha_Kulas31" },
                    { 6, new DateTime(2001, 2, 18, 20, 12, 23, 128, DateTimeKind.Local).AddTicks(5769), "Mona Stroman", "$2a$10$xc7KEfu.mSgs92g3Gek0P.J4xAwHlnxLeTXfC81hAt3DtSPbhOu06", "Beatrice.Will" },
                    { 7, new DateTime(1956, 2, 28, 14, 17, 49, 3, DateTimeKind.Local).AddTicks(4813), "Connie Mante", "$2a$10$zFwpTSZOpCQgbjd6edeyJOw4CSViVatGe/yS1e6Ip4CFRYFL8EY6K", "Kolby_Crooks" },
                    { 8, new DateTime(2000, 4, 3, 15, 12, 35, 427, DateTimeKind.Local).AddTicks(1385), "Phyllis McLaughlin", "$2a$10$iS1.2u.2qKWhaRi09jxsHuI5nix1lXd/xZ2u/xEq7MN047ghKN7TO", "Marshall91" },
                    { 9, new DateTime(1977, 4, 2, 9, 35, 23, 602, DateTimeKind.Local).AddTicks(4331), "Adam O'Connell", "$2a$10$8pYmUzKIdBUNc40MvZPddORFXVxVHgNWvmnEDrxKizCQEQMt3YK06", "Hilma23" },
                    { 10, new DateTime(1995, 12, 25, 18, 29, 14, 258, DateTimeKind.Local).AddTicks(6482), "Darin Kuphal", "$2a$10$a24xywIf2IIH.HnXfnnot.SbIwqiEh.Oubv.KtX5ZwE9OQNFdfTmO", "Annalise_Mante" },
                    { 11, new DateTime(2002, 1, 31, 12, 52, 35, 362, DateTimeKind.Local).AddTicks(9661), "Pat Feeney", "$2a$10$H/TBryNivD2kGovrlYIQ4.wHcX2dv9Nq/.IPRY4l8NtVUMyMfMlry", "Rico_Oberbrunner" },
                    { 12, new DateTime(1989, 6, 15, 5, 40, 32, 109, DateTimeKind.Local).AddTicks(361), "Nichole Kuhlman", "$2a$10$XCxqWEv82lVpwdu95Dhw3enLL0Sox8CwA1v0NLXXKmxUqKZIAPPqC", "Jonas_MacGyver" },
                    { 13, new DateTime(1982, 2, 9, 7, 31, 11, 311, DateTimeKind.Local).AddTicks(666), "Leah Wunsch", "$2a$10$e/ysOW7t2tSJtDdxjj8Wxe4udQ5tyL4WgFhJyTL2Y.Dy6FYzDbyLO", "Wava.Bogan" },
                    { 14, new DateTime(2001, 7, 12, 8, 50, 41, 443, DateTimeKind.Local).AddTicks(8454), "Carol Morissette", "$2a$10$87Vil9bBqw9SDJ57x8G3Aex6cnHUDx/68QnUK/Oy350O25Yoiv3wO", "Idella_Krajcik" },
                    { 15, new DateTime(1990, 7, 9, 6, 43, 52, 28, DateTimeKind.Local).AddTicks(688), "Amanda Hagenes", "$2a$10$kFyjCPXd4IvuFFtbZ77KXuMy0r4kCD.IaFhQnq7HN7q4H0N4ZZGty", "Heidi.Roob" },
                    { 16, new DateTime(1979, 12, 30, 9, 4, 38, 849, DateTimeKind.Local).AddTicks(2612), "Kristi Lindgren", "$2a$10$8b62KqyCCP/ktswOkxG43OQdSnHVpUTm/aHu.f3A33E.UJ.caoQNK", "Jonathan16" },
                    { 17, new DateTime(1967, 10, 8, 13, 20, 8, 231, DateTimeKind.Local).AddTicks(8120), "Leon Franecki", "$2a$10$l6V0m1u8xB1lp5tBxc2N0.GM1vkJaMF3vrRwFDVGImhDirAN5RzLy", "Karson.Lynch" },
                    { 18, new DateTime(1979, 9, 4, 20, 2, 16, 297, DateTimeKind.Local).AddTicks(4157), "Lois Hilpert", "$2a$10$y6Lam/nuXKxy9M/PkCpWAOTFkC6ncrz2/b6HUJR01aXYqvxyPrNwe", "Ryley.Robel" },
                    { 19, new DateTime(1975, 12, 3, 6, 2, 3, 790, DateTimeKind.Local).AddTicks(2436), "Dwayne O'Reilly", "$2a$10$sUyL2FLcHN5RE5mI5Qj6AOSlCCrl9.oxPiVpEJvIqyat1sRcgDb1e", "Ilene64" },
                    { 20, new DateTime(1998, 10, 9, 18, 53, 27, 339, DateTimeKind.Local).AddTicks(6146), "Perry Feeney", "$2a$10$MU7PhntoGzhcmbR7ESBP8Olp8Icav65rqmq7VDjp0EcZ.lvfbRj4S", "Stefanie54" },
                    { 21, new DateTime(1976, 6, 1, 2, 41, 40, 376, DateTimeKind.Local).AddTicks(5212), "Patsy Rowe", "$2a$10$e3DTMUcrtOJraKeB48l78Oi8xsofYoGe.UZFeNVf4lHuK7pYyxdGC", "Valerie_Quigley" },
                    { 22, new DateTime(1982, 7, 25, 1, 17, 53, 209, DateTimeKind.Local).AddTicks(1832), "Bradley Brown", "$2a$10$0naYDhD.NcOg8KQJVoQCcO8aEqWlLvAiVafxco/Wub7sxYVFrk3pS", "Chanelle6" },
                    { 23, new DateTime(1973, 12, 23, 7, 15, 50, 452, DateTimeKind.Local).AddTicks(1604), "Ann Kerluke", "$2a$10$JumqIXOU67hjlorch63UWOwpAtBpwC9c8xiDh.hc76q.qVFmOEjVm", "Velda.Lindgren" },
                    { 24, new DateTime(1988, 4, 21, 23, 46, 7, 640, DateTimeKind.Local).AddTicks(4084), "Bob Runolfsson", "$2a$10$bO.Vg0bQjWJJnZXVTNe9aOthnMyD/Vg85It2nkXWl/hkIAQStIHA6", "Bonita_Romaguera" },
                    { 25, new DateTime(1982, 1, 25, 5, 8, 39, 861, DateTimeKind.Local).AddTicks(1611), "Colin Schuppe", "$2a$10$ma3pC7S2afAG7b/G8QsFCOVIzlq65S3CCBAAxVlg9ANtJRpzo.FKy", "Lea56" },
                    { 26, new DateTime(1971, 1, 9, 22, 24, 21, 112, DateTimeKind.Local).AddTicks(7640), "Miranda Jast", "$2a$10$Ze.DpaqdRhLzs6BBkEKPOOrnaQsw1mEFDuRmuy0LpuqTFJMLWdvrS", "Akeem.Trantow" },
                    { 27, new DateTime(1984, 1, 5, 3, 43, 14, 645, DateTimeKind.Local).AddTicks(2710), "Glen Weissnat", "$2a$10$Ea4x3Auufh5fhMP95HyGourx8iU9GvadqVJsidx/TNzxyV/tdfUpW", "Eulah78" },
                    { 28, new DateTime(1993, 4, 18, 11, 54, 26, 602, DateTimeKind.Local).AddTicks(2827), "Courtney Reynolds", "$2a$10$IICmN1.GsGXUnZMGXxhPk.9YJ8lOEADCRXB0IUXb7kb/wjQ.hdcki", "Chandler.Predovic" },
                    { 29, new DateTime(1972, 7, 16, 15, 28, 16, 117, DateTimeKind.Local).AddTicks(7045), "Wanda Lemke", "$2a$10$rMO5ILBvyj6C0orUjsLDAe3pt2EIjXH50thBgQo0K6KXjh2rKDue.", "Tyler_Botsford" },
                    { 30, new DateTime(1997, 1, 9, 7, 0, 11, 249, DateTimeKind.Local).AddTicks(2074), "Eddie Ritchie", "$2a$10$bu.FDPmCM.F/fl19MoF6ZuhJiciGHXzhCi4umqub8582tSiuvEGq2", "Narciso62" },
                    { 31, new DateTime(1978, 5, 27, 1, 44, 53, 146, DateTimeKind.Local).AddTicks(760), "Jeannie Wiegand", "$2a$10$pVpvNQRW.sVUt1uzvAmfDO6h58BchY5UNtThRHajY9KzmZdC8y8yi", "Rey94" },
                    { 32, new DateTime(1953, 12, 22, 9, 47, 53, 581, DateTimeKind.Local).AddTicks(1221), "Aubrey Kovacek", "$2a$10$FDgO5QoBWp3IX0MHPbsWOeKXNwUhC3ZP4R2X7.7PHiTHh0zmh/Jhi", "Kurtis.Howell" },
                    { 33, new DateTime(1968, 6, 23, 12, 17, 28, 330, DateTimeKind.Local).AddTicks(9134), "Shelly Rau", "$2a$10$rH9oaaL5alAxEg84NK1.6OtjKNDb09J1dlP5NMUnmAuGll19NFqFO", "Layla_Ratke72" },
                    { 34, new DateTime(1979, 2, 3, 22, 41, 34, 128, DateTimeKind.Local).AddTicks(3555), "Darren Cronin", "$2a$10$mZCVcvqSaPrAfWDKwIm2tOFR3gnnohGFjuwuP.dj4rESEgXL//rI.", "Emmitt.Halvorson" },
                    { 35, new DateTime(1987, 5, 8, 6, 38, 24, 735, DateTimeKind.Local).AddTicks(2216), "Krystal Emmerich", "$2a$10$mG.Fad2eOHRAWGdvEGroTOLJBfeSpGpK5qrBxMjscD37sUO1YXu86", "Rebekah_Hansen" },
                    { 36, new DateTime(1979, 6, 14, 18, 55, 18, 935, DateTimeKind.Local).AddTicks(1796), "Lucille Stanton", "$2a$10$2rRuGnrXzPPxjkGu5bGIKe/XSsVn91iF/G/eOsQ.zYgsHCU0A8OCe", "Godfrey53" },
                    { 37, new DateTime(1962, 9, 8, 20, 47, 50, 276, DateTimeKind.Local).AddTicks(4369), "Natalie Bayer", "$2a$10$XZxA7sJ13X3W39oXKHM6xeJrVX5ou7j4CMm7nqYK4ara8WE775iEi", "Kim_Crooks39" },
                    { 38, new DateTime(1977, 5, 11, 20, 6, 0, 460, DateTimeKind.Local).AddTicks(9763), "Noah Stamm", "$2a$10$mLaVwXyfjRkwDJNnu0Prke7ijuK4pMy5pA6XjRr7YvlNDCUz4MUEK", "Johnson_Rosenbaum" },
                    { 39, new DateTime(1972, 6, 28, 15, 26, 9, 355, DateTimeKind.Local).AddTicks(9660), "Frances Reichert", "$2a$10$zb4b/Y4GXoTNS8/zUa9mWu55Fs0XL9.FjMPVl/mcjEuZhmdkQtkc.", "Christine.Kris" },
                    { 40, new DateTime(1990, 6, 22, 7, 23, 14, 302, DateTimeKind.Local).AddTicks(7752), "Suzanne Towne", "$2a$10$hdpMibbUnbn8/r0mNVQgh.sPws8O1uR9inAPGgSssN3CAtYKG0w7C", "Jay.Fahey93" },
                    { 41, new DateTime(1997, 8, 4, 4, 28, 44, 681, DateTimeKind.Local).AddTicks(1499), "Dawn Schimmel", "$2a$10$3.yZVym2Ya0AgO6RCdSmPuMnujJkx.dZRUMYrzE7Tt.0yKwSOdYzq", "Jeffery_Thiel78" },
                    { 42, new DateTime(1989, 11, 22, 23, 7, 56, 518, DateTimeKind.Local).AddTicks(9328), "Karl Breitenberg", "$2a$10$UjlJgFKGwsuYyXdoEFrGoeMHo3wV3VRqkwstXeW1AcL1goGUpPMBu", "Lottie_Fahey" },
                    { 43, new DateTime(1980, 5, 8, 16, 56, 7, 599, DateTimeKind.Local).AddTicks(9760), "Loren Harvey", "$2a$10$1SxHovCjQox7m/XaCduUGeBf9CiDNpehYpKUbHQpuOT9fVVJ96OmG", "Jaqueline.Towne76" },
                    { 44, new DateTime(1957, 11, 19, 20, 26, 27, 178, DateTimeKind.Local).AddTicks(5615), "Roman Streich", "$2a$10$A874y.ailHIUI/kCMxMjS.zRIXXnjBhXiy0XeEdrmSERdQQRoGQB2", "Neha74" },
                    { 45, new DateTime(1962, 7, 23, 12, 16, 59, 468, DateTimeKind.Local).AddTicks(620), "Roosevelt Donnelly", "$2a$10$bgbAdVTUqx2Bv06AZcxUDeJZjWDlwVl2bP2f3RHEK2K4RQFTU5zB2", "Clair.Deckow" },
                    { 46, new DateTime(1970, 1, 28, 18, 25, 48, 721, DateTimeKind.Local).AddTicks(5916), "Tabitha Rutherford", "$2a$10$gK84wTTd.3LndpV8x8rLiOOCN0xz8izQgMXHkJVi.tWMFAszLnyr2", "Cleve17" },
                    { 47, new DateTime(1999, 7, 19, 12, 8, 27, 553, DateTimeKind.Local).AddTicks(5865), "Lance Treutel", "$2a$10$zOV0cLGNoMiiURIavYc5MeWgSVVeoBrl66Sx9S0w1qbLBmFZv/NYS", "Tina5" },
                    { 48, new DateTime(1955, 6, 10, 8, 13, 23, 572, DateTimeKind.Local).AddTicks(1046), "Corey Ullrich", "$2a$10$SmlWtQmM2oB5xhfcRMhsP.hkT3XUoZYUglNTIaMMo7cqj5KxVviO2", "Kiara_Walter70" },
                    { 49, new DateTime(1992, 10, 8, 7, 35, 10, 583, DateTimeKind.Local).AddTicks(5112), "Tommie Welch", "$2a$10$uRoDONZ8.F6nNrL.uTxWP.lcBVef.HVvDJeos7yzIwZoCCAuscvnG", "Annabel.West" },
                    { 50, new DateTime(1980, 7, 27, 17, 7, 56, 658, DateTimeKind.Local).AddTicks(2074), "Ruben Koss", "$2a$10$sYbbH3mQ.WPDWZa8U0lhe.BYXa/at2dJS9fp3GheWMcr7ZeJv0Ewa", "Giuseppe14" },
                    { 51, new DateTime(1982, 3, 7, 9, 45, 1, 274, DateTimeKind.Local).AddTicks(5115), "Darren Flatley", "$2a$10$91DHtiD3vV8MnNwyVfulXuI.NR2qk4K2K.Cn6m4AngQFUH16j4PaC", "Isaiah17" },
                    { 52, new DateTime(1971, 8, 23, 18, 51, 14, 381, DateTimeKind.Local).AddTicks(2631), "Shannon Stokes", "$2a$10$cQh3o.oTPEBAsP2XRITsLefAxYNWisaWmatl.PZVRaFNYKCC.OUIC", "Camila.Hodkiewicz50" },
                    { 53, new DateTime(1989, 4, 28, 3, 44, 28, 379, DateTimeKind.Local).AddTicks(4517), "Joel Prohaska", "$2a$10$cMRLpPO6W1QJTZO516FjTObmCkylgx53BaoTT4QGpKGHpa38pca8q", "Cortez35" },
                    { 54, new DateTime(1962, 5, 16, 6, 45, 14, 593, DateTimeKind.Local).AddTicks(6605), "Janie Bruen", "$2a$10$xrp4bMKas6JRrWV8Nd9JiOemsAL/uZVnXzjn3wWPW3kv9YZXNUQqi", "Torrey74" },
                    { 55, new DateTime(1985, 6, 6, 19, 27, 30, 962, DateTimeKind.Local).AddTicks(765), "Willie Runolfsson", "$2a$10$fnabK1Tbxk64UUka4.zFyOna5VP9mQ6GMk2dOvOLuLrDnWgbkidJi", "Jefferey_Nolan" },
                    { 56, new DateTime(1965, 12, 25, 10, 18, 26, 261, DateTimeKind.Local).AddTicks(3958), "Jordan Armstrong", "$2a$10$GFJlPwn7MJP.umBxwQaVDuk0gY15qC4nhXVcMhDBy/Qzv8Ad/iKZC", "Billy.Yost" },
                    { 57, new DateTime(1954, 2, 20, 2, 2, 11, 577, DateTimeKind.Local).AddTicks(1041), "Audrey Upton", "$2a$10$Bs2I.npCC.MLS9bVIjOQRuyNTbFkheHy1aOulX49xQjNiDPROKTli", "Irving.Rempel" },
                    { 58, new DateTime(1954, 4, 22, 18, 0, 45, 275, DateTimeKind.Local).AddTicks(6341), "Laurence Ondricka", "$2a$10$a9oCYzlx3fSlbeTGHOnwau/hlkPkOIm9iMCMnm5CGEpRIvq9YU0vK", "Kaley_Bednar20" },
                    { 59, new DateTime(1970, 11, 25, 13, 18, 14, 174, DateTimeKind.Local).AddTicks(722), "Jan Crona", "$2a$10$6pmSVf6pa1phmK1Huq8qiOu7Xad7giHNGPBAM70.4KXQ1fcREDJQG", "Timothy16" },
                    { 60, new DateTime(1988, 9, 30, 10, 41, 8, 707, DateTimeKind.Local).AddTicks(3179), "Bryant Mills", "$2a$10$c/hMbys.ckcZtV8gjeeCR.RjQeLb4bUzU20Pgt4AjaVVpRN5H2Yku", "Monique_Littel22" },
                    { 61, new DateTime(1995, 6, 3, 8, 10, 7, 990, DateTimeKind.Local).AddTicks(3432), "Shaun Considine", "$2a$10$MTofH9rlEUTr6DY5zNwxhenCbI3NOKGrbW1/m1d6SvJ94nJTadC7.", "Assunta57" },
                    { 62, new DateTime(1973, 12, 15, 7, 59, 31, 353, DateTimeKind.Local).AddTicks(9610), "Tina Vandervort", "$2a$10$kxZ6y/9Nxuy88dWSxKB2uuKzwgP7ArCl4u2R/r6M14nHNnFnWR5Iy", "Myron17" },
                    { 63, new DateTime(1969, 4, 26, 9, 43, 21, 933, DateTimeKind.Local).AddTicks(402), "Faith Feeney", "$2a$10$M4F82skmaAI7qUiVqmepveXSynSalfZIJ/oHSdlVOu7Cva19cjaea", "Thea_Blick55" },
                    { 64, new DateTime(1992, 7, 6, 18, 27, 0, 577, DateTimeKind.Local).AddTicks(2022), "Patrick Wyman", "$2a$10$ezvukv4Kgjh2J4oO0dhZ2eqhja4lbIrngWunuu.oy2dNF/oLXeXTa", "Joshuah_Lowe" },
                    { 65, new DateTime(1992, 4, 15, 23, 29, 45, 820, DateTimeKind.Local).AddTicks(3442), "Guadalupe Kulas", "$2a$10$a3WyTS262vPx0QFLvpDvjufL9F1pwX5CA85sqmpdzsj8oLgk5oKGy", "Jaclyn21" },
                    { 66, new DateTime(1954, 10, 18, 10, 2, 39, 167, DateTimeKind.Local).AddTicks(8250), "Beatrice Schuster", "$2a$10$CF4B3FPDjhcAQgMx4o5qKOGUdcjKjSJJNDJ/EI6yCBSF/E2MexmY6", "Jettie.Schmidt32" },
                    { 67, new DateTime(1966, 8, 28, 4, 13, 18, 922, DateTimeKind.Local).AddTicks(9235), "Candace Kunze", "$2a$10$vjiGXUKLzhNFAcmzHT.3WeMNxrzodPNuPbffalCknjIo3rDJgoUye", "Velda23" },
                    { 68, new DateTime(1981, 6, 13, 2, 52, 3, 732, DateTimeKind.Local).AddTicks(2181), "Josh Franecki", "$2a$10$k8IYrOlYOXkMkdUIqj.QOOswzyvrzI/cxEgpbD8vz3Ihw5bnMYOqG", "Hiram_Torp53" },
                    { 69, new DateTime(1969, 5, 27, 17, 28, 1, 959, DateTimeKind.Local).AddTicks(391), "Otis Buckridge", "$2a$10$cSOP0B14n73w77ySlXH.xOyIvPmo9v7jbWCwkvO4WvIUS3PcaYBJK", "Madalyn.Witting14" },
                    { 70, new DateTime(1986, 10, 15, 15, 25, 12, 385, DateTimeKind.Local).AddTicks(450), "Debra Roob", "$2a$10$yqcBjKTGyZIBabS.SJSK3ufYhL5KLCnzyR7HgLloLQNqj8qYzGo/.", "Niko97" },
                    { 71, new DateTime(1990, 9, 5, 1, 4, 22, 439, DateTimeKind.Local).AddTicks(2533), "Wilbert Rogahn", "$2a$10$LNvHPjRE/EAFMTX4X3SrFOUJ/K1D4YZaw73bHQg6gMwsbyrBFJMQC", "Bobby.King" },
                    { 72, new DateTime(1982, 8, 1, 0, 48, 38, 629, DateTimeKind.Local).AddTicks(4028), "Woodrow McCullough", "$2a$10$J5AANCCUSeqOkYrZerfrr.ju1MamEezJK6NZ1XV4vqmmoEvWji2DO", "Karli_Gerlach49" },
                    { 73, new DateTime(1978, 12, 25, 0, 8, 14, 304, DateTimeKind.Local).AddTicks(4582), "Leticia Wisoky", "$2a$10$8JGOoxJ.z29mkgrNbGvtju34Dy3iHRbVysn8UV.eFHf4ioS5YH5M6", "Eldon_Pfannerstill38" },
                    { 74, new DateTime(1979, 4, 27, 21, 36, 42, 249, DateTimeKind.Local).AddTicks(2686), "Silvia Reynolds", "$2a$10$Sxjv0iGIimFuqK1mJp8Xr.HnDO3OgPFaS804eHhoX0zdSEWuOHqkO", "Enoch_Considine" },
                    { 75, new DateTime(1994, 6, 26, 1, 50, 35, 537, DateTimeKind.Local).AddTicks(4886), "Heidi Walker", "$2a$10$mOiiZT5eZR6Dc.bCiyr7AOldBfuxYRmbayYMZnhSiMFDxHawp3Kl.", "Ian_Rippin78" },
                    { 76, new DateTime(1958, 8, 31, 12, 36, 24, 137, DateTimeKind.Local).AddTicks(2748), "Tricia Goyette", "$2a$10$p3/lkGtAzb4jFQFBbDGSNebpgvla3Uafwu5WMGLDyVjPqzscn5o1u", "Caleigh80" },
                    { 77, new DateTime(1981, 12, 1, 15, 4, 39, 835, DateTimeKind.Local).AddTicks(2022), "Rudolph King", "$2a$10$MHIVq3KxOSeuU9PZX1zC4u/fB.kfkftVColaItpmYkOzcG6iNvHp6", "Darlene61" },
                    { 78, new DateTime(2002, 8, 23, 13, 40, 6, 62, DateTimeKind.Local).AddTicks(7940), "Jeannette Berge", "$2a$10$v0mLOrdcEOcFF7ck4tZthuB8hx6UtTOi8WfYr93RHVc1M8S0YUBFC", "Jerod59" },
                    { 79, new DateTime(1964, 1, 25, 4, 22, 3, 134, DateTimeKind.Local).AddTicks(8116), "Marlene D'Amore", "$2a$10$RtktCv0K9VTxCirYJAuI4eL/LfbXHXgIvRJ6pP0qGhl1Qb1SNjpiy", "Adell80" },
                    { 80, new DateTime(1972, 3, 21, 4, 46, 46, 470, DateTimeKind.Local).AddTicks(7418), "Kathryn Bashirian", "$2a$10$iCECj1HvSIIdUS8vd0ymI.Dp9/JAYbkpefUoKGKIBZ7.aCW0p/oT6", "Lazaro_Becker26" },
                    { 81, new DateTime(1968, 1, 13, 13, 47, 36, 139, DateTimeKind.Local).AddTicks(3393), "Gary Boehm", "$2a$10$INnWtetjh9aPzIiSKAxd0etsvX5GuqIR7PCxBYwqVquOQXJ2QrBTq", "Oma17" },
                    { 82, new DateTime(1969, 11, 24, 12, 7, 35, 857, DateTimeKind.Local).AddTicks(9480), "Levi Kunze", "$2a$10$Q/AFbx9PS.NgyWyGxNQLCuYDgPqj/VKQWO/ATKgpQ2GCFCSUZKr7W", "Bryce.Harvey" },
                    { 83, new DateTime(1990, 9, 27, 5, 37, 53, 729, DateTimeKind.Local).AddTicks(5193), "Darrel Morar", "$2a$10$hK.HHQSwMwNs0yvSMRMMPeOoZ7DbcAht/Zxod8OCPSjc/heGln3qO", "Jamison.Miller45" },
                    { 84, new DateTime(1957, 6, 8, 21, 52, 44, 609, DateTimeKind.Local).AddTicks(5851), "Manuel VonRueden", "$2a$10$6.fasVXpgZrTHd3r4pG0Tu9.Qetx1J4xAxqaPHB1Dvr2aD5ZqshOq", "Giles69" },
                    { 85, new DateTime(1959, 5, 14, 16, 41, 6, 867, DateTimeKind.Local).AddTicks(8850), "Boyd Cormier", "$2a$10$cG4XSM5qIhSvcdV6nanA.ux9WYN1DYw9ZmmYdtdtL/UBVDXSDKpoq", "Albert_Harber" },
                    { 86, new DateTime(1959, 1, 9, 6, 16, 2, 896, DateTimeKind.Local).AddTicks(244), "Alyssa Block", "$2a$10$QgOic9uWUrck3A8pEEL5Oe4zt/wxgW6DbcPPa5Q09fACoYUjZqFdS", "Elmira_Stracke" },
                    { 87, new DateTime(2002, 6, 28, 0, 46, 58, 966, DateTimeKind.Local).AddTicks(8308), "Floyd Okuneva", "$2a$10$V/sdWbymwNE77iOnkVwT3..r4pB9EjZKQBt96.buE6oNRO3roxHH2", "Destin.Koch89" },
                    { 88, new DateTime(1958, 10, 10, 13, 36, 3, 294, DateTimeKind.Local).AddTicks(5291), "Ted Borer", "$2a$10$kb53P8XkHw/fNlfiaq2iZOvi0OItBIMTpY/qg1/BNh3OolqOTEHTC", "Jeffrey_Kling" },
                    { 89, new DateTime(1954, 11, 27, 3, 37, 27, 355, DateTimeKind.Local).AddTicks(6788), "Kristen Donnelly", "$2a$10$k7tQ4xsN.AP75PoxI/G7teIZ6qkzfy329bYleI/oSpsIapJH8ii3m", "Felton31" },
                    { 90, new DateTime(1980, 1, 5, 16, 48, 16, 647, DateTimeKind.Local).AddTicks(4988), "Katherine Koss", "$2a$10$yN719y1ho.tEOpkM0KT0Qe.KBTedkASqH45HRjycG1C3HbN8knRti", "Raquel_Kassulke" },
                    { 91, new DateTime(2002, 4, 1, 0, 53, 56, 773, DateTimeKind.Local).AddTicks(607), "Tommy Fritsch", "$2a$10$JSYIooQ5yWaaguQ/.HEFzO354XuQ14StYQNQCgOHW247yqPOtyLDS", "Zoey.Feest" },
                    { 92, new DateTime(1966, 11, 17, 2, 24, 17, 588, DateTimeKind.Local).AddTicks(6078), "Omar Bergstrom", "$2a$10$MDh0QhFiRckbZwQt5RRaueGiWRWJXC9xBcPc/grq2EmQsUOWuaaUO", "Ari_Wintheiser" },
                    { 93, new DateTime(1993, 4, 9, 5, 46, 15, 510, DateTimeKind.Local).AddTicks(3543), "Craig Kautzer", "$2a$10$260itRGbfssFysgDRNiwa.CRvoGtPqEVtAcfIWQazykb0PaLX9ciu", "Dena_Cremin83" },
                    { 94, new DateTime(1973, 11, 17, 8, 33, 11, 926, DateTimeKind.Local).AddTicks(1225), "Sidney Hirthe", "$2a$10$5g7yXF6K2SBHD8KkstUpwOe0FHm4Ae9gMbhPsBSwzaA7JZ1JKvbvC", "Bobby30" },
                    { 95, new DateTime(1976, 5, 12, 6, 55, 36, 87, DateTimeKind.Local).AddTicks(2065), "Miriam Rogahn", "$2a$10$qNqD9ESXlJSATqzTpTcPk.OIrsJ13vONQDkVuODWE01.40lZLXKqG", "Alexzander.West" },
                    { 96, new DateTime(1991, 9, 23, 7, 28, 51, 626, DateTimeKind.Local).AddTicks(7517), "Cindy Kuhlman", "$2a$10$t4vxdOPiITw/0yVqTB6IHem9L8A9w2PtUTkE/drHdcfoQENfOyryu", "Gregorio41" },
                    { 97, new DateTime(1997, 8, 2, 15, 51, 58, 103, DateTimeKind.Local).AddTicks(500), "Benjamin Conroy", "$2a$10$OzDwuoKohCUzCmxKdtAQzuXy9wkRz4czpfMXgOi8PlMEXwI.gI2fm", "Sydnie17" },
                    { 98, new DateTime(1986, 3, 24, 11, 49, 21, 492, DateTimeKind.Local).AddTicks(4152), "Charlie Weber", "$2a$10$OfCtL9KdEVFJ8iyAUcjZiumxeYkiiu3h2wjPa5s3ImKuGsPJbKG.y", "Rosalind.Ratke" },
                    { 99, new DateTime(1972, 6, 6, 3, 37, 32, 532, DateTimeKind.Local).AddTicks(2220), "Whitney Stark", "$2a$10$w.WJzLzrRSCLgDJF7cCTIObfTaiSJpKMzn1jYP3a/Wx/l68IdXbKy", "Bonnie.Schumm84" },
                    { 100, new DateTime(2000, 3, 9, 3, 23, 8, 573, DateTimeKind.Local).AddTicks(1635), "Rhonda Walter", "$2a$10$T.R4hyFB.1vnXqR83Ngd.OTG9PzamQdbn.FtVc1E9xyG5DUY7Iz6S", "Ruthie_Lebsack27" }
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "ArtistId", "CoverImage", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, 1, "lemonade.png", "Pop/R&B", "Lemonade" },
                    { 2, 1, "bday.png", "Pop/R&B", "B'Day" },
                    { 3, 2, "atfolsomprison.png", "Country", "At Folsom Prison" },
                    { 4, 2, "themancomesaround.png", "Country", "The Man Comes Around" },
                    { 5, 3, "likeavirgin.png", "Pop/Dance", "Like a Virgin" },
                    { 6, 3, "rayoflight.png", "Pop/Dance", "Ray of Light" },
                    { 7, 4, "theblueprint.png", "Hip-Hop", "The Blueprint" },
                    { 8, 4, "reasonabledoubt.png", "Hip-Hop", "Reasonable Doubt" },
                    { 9, 5, "backinblack.png", "Rock", "Back in Black" },
                    { 10, 5, "highwaytohell.png", "Rock", "Highway to Hell" },
                    { 11, 6, "ziggyardust.png", "Rock", "The Rise and Fall of Ziggy Stardust..." },
                    { 12, 6, "blackstar.png", "Rock", "Blackstar" },
                    { 13, 7, "topimpabutterfly.png", "Hip-Hop", "To Pimp a Butterfly" },
                    { 14, 7, "damn.png", "Hip-Hop", "DAMN." },
                    { 15, 8, "1989.png", "Pop", "1989" },
                    { 16, 8, "fearless.png", "Country/Pop", "Fearless" },
                    { 17, 9, "purplerain.png", "Pop/R&B", "Purple Rain" },
                    { 18, 9, "signothetimes.png", "Pop/R&B", "Sign o' the Times" },
                    { 19, 10, "nevermind.png", "Grunge/Rock", "Nevermind" },
                    { 20, 10, "inutero.png", "Grunge/Rock", "In Utero" },
                    { 21, 11, "goodgirlgonebad.png", "Pop/R&B", "Good Girl Gone Bad" },
                    { 22, 11, "anti.png", "Pop/R&B", "Anti" },
                    { 23, 12, "thriller.png", "Pop/R&B", "Thriller" },
                    { 24, 12, "bad.png", "Pop/R&B", "Bad" },
                    { 25, 13, "okcomputer.png", "Alternative Rock", "OK Computer" },
                    { 26, 13, "thebends.png", "Alternative Rock", "The Bends" },
                    { 27, 14, "legend.png", "Reggae", "Legend" },
                    { 28, 14, "exodus.png", "Reggae", "Exodus" },
                    { 29, 15, "iv.png", "Rock", "IV" },
                    { 30, 15, "physicalgraffiti.png", "Rock", "Physical Graffiti" },
                    { 31, 16, "yellowbrickroad.png", "Pop/Rock", "Goodbye Yellow Brick Road" },
                    { 32, 16, "rocketman.png", "Pop/Rock", "Rocket Man: Number Ones" },
                    { 33, 17, "24kmagic.png", "Pop/R&B", "24K Magic" },
                    { 34, 17, "unorthodoxjukebox.png", "Pop/R&B", "Unorthodox Jukebox" },
                    { 35, 18, "rumours.png", "Rock", "Rumours" },
                    { 36, 18, "tangointhenight.png", "Rock", "Tango in the Night" },
                    { 37, 19, "stickyfingers.png", "Rock", "Sticky Fingers" },
                    { 38, 19, "exileonmainst.png", "Rock", "Exile on Main St." },
                    { 39, 20, "anightattheopera.png", "Rock", "A Night at the Opera" },
                    { 40, 20, "thegame.png", "Rock", "The Game" }
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "IsPublic", "Timestamp", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, true, 0, "Sapphire Melodies", 21 },
                    { 2, false, 0, "Whispering Echoes", 3 },
                    { 3, true, 0, "Celestial Rhythms", 45 },
                    { 4, false, 0, "Serendipity Sounds", 77 },
                    { 5, true, 0, "Ethereal Grooves", 12 },
                    { 6, true, 0, "Dusk Harmonies", 34 },
                    { 7, true, 0, "Velocity Beats", 56 },
                    { 8, false, 0, "Tranquil Whispers", 89 },
                    { 9, true, 0, "Aurora Harmonics", 7 },
                    { 10, false, 0, "Enigmatic Echo", 92 },
                    { 11, true, 0, "Pulse Pumpers", 18 },
                    { 12, true, 0, "Jazzy Journeys", 41 },
                    { 13, false, 0, "Nebula Nostalgia", 63 },
                    { 14, true, 0, "Velocity Beats", 29 },
                    { 15, true, 0, "Celestial Harmony", 51 },
                    { 16, false, 0, "Rhythmic Revolution", 84 },
                    { 17, true, 0, "Latin Fiesta", 6 },
                    { 18, true, 0, "Metal Mayhem", 72 },
                    { 19, true, 0, "Harmonious Classics", 94 },
                    { 20, false, 0, "Disco Fever", 38 },
                    { 21, true, 0, "Acoustic Serenity", 82 },
                    { 22, true, 0, "Reggae Rhythms", 17 },
                    { 23, false, 0, "Hip-Hop Heat", 49 },
                    { 24, true, 0, "Summer Sizzlers", 27 },
                    { 25, true, 0, "Alternative Jams", 61 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "ArtistId", "Duration", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, 235, new DateTime(2003, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crazy in Love" },
                    { 2, 1, 230, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo" },
                    { 3, 1, 213, new DateTime(2008, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Single Ladies" },
                    { 4, 1, 197, new DateTime(2006, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irreplaceable" },
                    { 5, 1, 233, new DateTime(2016, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Formation" },
                    { 6, 2, 163, new DateTime(1963, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ring of Fire" },
                    { 7, 2, 165, new DateTime(1956, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I Walk the Line" },
                    { 8, 2, 170, new DateTime(1955, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hurt" },
                    { 9, 2, 215, new DateTime(2002, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Folsom Prison Blues" },
                    { 10, 2, 165, new DateTime(1971, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Boy Names Sue" },
                    { 11, 3, 224, new DateTime(1984, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Like a Virgin" },
                    { 12, 3, 314, new DateTime(1990, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vogue" },
                    { 13, 3, 225, new DateTime(1985, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Material Girl" },
                    { 14, 3, 334, new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Like a Prayer" },
                    { 15, 3, 303, new DateTime(2005, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hung Up" },
                    { 16, 4, 278, new DateTime(2009, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empire State of Mind" },
                    { 17, 4, 235, new DateTime(2003, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "99 Problems" },
                    { 18, 4, 212, new DateTime(1998, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Knock Life" },
                    { 19, 4, 308, new DateTime(2013, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dirt Off Your Shoulder" },
                    { 20, 4, 306, new DateTime(1999, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Run This Town" },
                    { 21, 5, 208, new DateTime(1979, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Highway to Hell" },
                    { 22, 5, 255, new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Back in Black" },
                    { 23, 5, 292, new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderstruck" },
                    { 24, 5, 210, new DateTime(1980, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "You Shook Me All Night Long" },
                    { 25, 5, 209, new DateTime(1975, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "T.N.T." },
                    { 26, 6, 313, new DateTime(1969, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Space Oddity" },
                    { 27, 6, 370, new DateTime(1977, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes" },
                    { 28, 6, 324, new DateTime(1983, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Let's Dance" },
                    { 29, 6, 258, new DateTime(1972, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starman" },
                    { 30, 6, 224, new DateTime(1971, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Life on Mars?" },
                    { 31, 7, 177, new DateTime(2017, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "HUMBLE." },
                    { 32, 7, 309, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alright" },
                    { 33, 7, 185, new DateTime(2017, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "DNA." },
                    { 34, 7, 259, new DateTime(2012, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swimming Pools (Drank)" },
                    { 35, 7, 234, new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "King Kunta" },
                    { 36, 8, 219, new DateTime(2014, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shake It Off" },
                    { 37, 8, 231, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blank Space" },
                    { 38, 8, 235, new DateTime(2008, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Story" },
                    { 39, 8, 231, new DateTime(2008, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "You Belong with Me" },
                    { 40, 8, 231, new DateTime(2014, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delicate" },
                    { 41, 9, 270, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Purple Rain" },
                    { 42, 9, 220, new DateTime(2010, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "When Doves Cry" },
                    { 43, 9, 223, new DateTime(2010, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiss" },
                    { 44, 9, 225, new DateTime(2016, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Red Corvette" },
                    { 45, 9, 232, new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raspberry Beret" },
                    { 46, 10, 231, new DateTime(1976, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smells Like Teen Spirit" },
                    { 47, 10, 256, new DateTime(1977, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Come as You Are" },
                    { 48, 10, 276, new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heart-Shaped Box" },
                    { 49, 10, 207, new DateTime(1975, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lithium" },
                    { 50, 10, 268, new DateTime(1975, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Bloom" },
                    { 51, 11, 219, new DateTime(1966, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Umbrella" },
                    { 52, 11, 366, new DateTime(1968, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diamonds" },
                    { 53, 11, 271, new DateTime(1969, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Only Girl" },
                    { 54, 11, 275, new DateTime(1973, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work" },
                    { 55, 11, 227, new DateTime(1981, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "We Found Love" },
                    { 56, 12, 366, new DateTime(1975, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billie Jean" },
                    { 57, 12, 218, new DateTime(1980, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller" },
                    { 58, 12, 122, new DateTime(1977, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beat It" },
                    { 59, 12, 298, new DateTime(1976, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Man in the Mirror" },
                    { 60, 12, 210, new DateTime(1979, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smooth Criminal" },
                    { 61, 13, 208, new DateTime(1979, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creep" },
                    { 62, 13, 255, new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karma Police" },
                    { 63, 13, 292, new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paranoid Android" },
                    { 64, 13, 210, new DateTime(1980, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Suprises" },
                    { 65, 13, 209, new DateTime(1975, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fake Platic Threes" },
                    { 66, 14, 313, new DateTime(1969, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three Little Birds" },
                    { 67, 14, 370, new DateTime(1977, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Woman, No Cry" },
                    { 68, 14, 324, new DateTime(1983, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Redemption Song" },
                    { 69, 14, 258, new DateTime(1972, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "One Love" },
                    { 70, 14, 224, new DateTime(1971, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buffalo Soldier" },
                    { 71, 15, 177, new DateTime(2017, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stairway to Heaven." },
                    { 72, 15, 309, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whole Lotta Love" },
                    { 73, 15, 185, new DateTime(2017, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Immigrant Song" },
                    { 74, 15, 259, new DateTime(2012, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Dog" },
                    { 75, 15, 234, new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock and Roll" },
                    { 76, 16, 219, new DateTime(2014, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Song" },
                    { 77, 16, 231, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocket Man" },
                    { 78, 16, 235, new DateTime(2008, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiny Dancer" },
                    { 79, 16, 231, new DateTime(2008, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goodbye Yellow Brick Road" },
                    { 80, 16, 231, new DateTime(2014, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bnnie and the Jets" },
                    { 81, 17, 270, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uptown Funk" },
                    { 82, 17, 220, new DateTime(2010, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Just the Way You Are" },
                    { 83, 17, 223, new DateTime(2010, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Treasure" },
                    { 84, 17, 225, new DateTime(2016, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "24K Magic" },
                    { 85, 17, 232, new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Locked Out of Heaven" },
                    { 86, 18, 231, new DateTime(1976, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go Your Own Way" },
                    { 87, 18, 256, new DateTime(1977, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dreams" },
                    { 88, 18, 276, new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Chain" },
                    { 89, 18, 207, new DateTime(1975, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Landslide" },
                    { 90, 18, 268, new DateTime(1975, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rhiannon" },
                    { 91, 19, 219, new DateTime(1966, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paint It Black" },
                    { 92, 19, 366, new DateTime(1968, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angie" },
                    { 93, 19, 271, new DateTime(1969, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satisfaction" },
                    { 94, 19, 275, new DateTime(1973, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sympathy for the Devil" },
                    { 95, 19, 227, new DateTime(1981, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Start Me Up" },
                    { 96, 20, 366, new DateTime(1975, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bohemian Rhapsody" },
                    { 97, 20, 218, new DateTime(1980, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Another One Bites the Dust" },
                    { 98, 20, 122, new DateTime(1977, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "We Will Rock You" },
                    { 99, 20, 298, new DateTime(1976, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somebody to Love" },
                    { 100, 20, 210, new DateTime(1979, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't Stop Me Now" }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "AlbumId", "SongId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 5, 11 },
                    { 5, 12 },
                    { 5, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 7, 16 },
                    { 7, 17 },
                    { 7, 18 },
                    { 8, 19 },
                    { 8, 20 },
                    { 9, 21 },
                    { 9, 22 },
                    { 9, 23 },
                    { 10, 24 },
                    { 10, 25 },
                    { 11, 26 },
                    { 11, 27 },
                    { 11, 28 },
                    { 12, 29 },
                    { 12, 30 },
                    { 13, 31 },
                    { 13, 32 },
                    { 13, 33 },
                    { 14, 34 },
                    { 14, 35 },
                    { 15, 36 },
                    { 15, 37 },
                    { 15, 38 },
                    { 16, 39 },
                    { 16, 40 },
                    { 17, 41 },
                    { 17, 42 },
                    { 17, 43 },
                    { 18, 44 },
                    { 18, 45 },
                    { 19, 46 },
                    { 19, 47 },
                    { 19, 48 },
                    { 20, 49 },
                    { 20, 50 },
                    { 21, 51 },
                    { 21, 52 },
                    { 21, 53 },
                    { 22, 54 },
                    { 22, 55 },
                    { 23, 56 },
                    { 23, 57 },
                    { 23, 58 },
                    { 24, 59 },
                    { 24, 60 },
                    { 25, 61 },
                    { 25, 62 },
                    { 25, 63 },
                    { 26, 64 },
                    { 26, 65 },
                    { 27, 66 },
                    { 27, 67 },
                    { 27, 68 },
                    { 28, 69 },
                    { 28, 70 },
                    { 29, 71 },
                    { 29, 72 },
                    { 29, 73 },
                    { 30, 74 },
                    { 30, 75 },
                    { 31, 76 },
                    { 31, 77 },
                    { 31, 78 },
                    { 32, 79 },
                    { 32, 80 },
                    { 33, 81 },
                    { 33, 82 },
                    { 33, 83 },
                    { 34, 84 },
                    { 34, 85 },
                    { 35, 86 },
                    { 35, 87 },
                    { 35, 88 },
                    { 36, 89 },
                    { 36, 90 },
                    { 37, 91 },
                    { 37, 92 },
                    { 37, 93 },
                    { 38, 94 },
                    { 38, 95 },
                    { 39, 96 },
                    { 39, 97 },
                    { 39, 98 },
                    { 40, 99 },
                    { 40, 100 }
                });

            migrationBuilder.InsertData(
                table: "PlaylistSongs",
                columns: new[] { "PlaylistId", "SongId" },
                values: new object[,]
                {
                    { 1, 18 },
                    { 1, 29 },
                    { 1, 42 },
                    { 1, 73 },
                    { 1, 83 },
                    { 2, 2 },
                    { 2, 19 },
                    { 2, 23 },
                    { 2, 25 },
                    { 2, 40 },
                    { 2, 52 },
                    { 2, 62 },
                    { 3, 10 },
                    { 3, 14 },
                    { 3, 35 },
                    { 3, 50 },
                    { 3, 67 },
                    { 3, 77 },
                    { 3, 91 },
                    { 4, 31 },
                    { 4, 46 },
                    { 4, 65 },
                    { 4, 75 },
                    { 4, 84 },
                    { 4, 93 },
                    { 5, 11 },
                    { 5, 28 },
                    { 5, 45 },
                    { 5, 54 },
                    { 5, 76 },
                    { 6, 3 },
                    { 6, 16 },
                    { 6, 39 },
                    { 6, 59 },
                    { 6, 71 },
                    { 6, 88 },
                    { 6, 98 },
                    { 7, 5 },
                    { 7, 7 },
                    { 7, 36 },
                    { 7, 60 },
                    { 7, 74 },
                    { 7, 81 },
                    { 7, 97 },
                    { 8, 12 },
                    { 8, 38 },
                    { 8, 53 },
                    { 8, 64 },
                    { 8, 87 },
                    { 8, 99 },
                    { 9, 24 },
                    { 9, 28 },
                    { 9, 33 },
                    { 9, 45 },
                    { 9, 54 },
                    { 9, 76 },
                    { 10, 21 },
                    { 10, 37 },
                    { 10, 66 },
                    { 10, 72 },
                    { 11, 15 },
                    { 11, 22 },
                    { 11, 32 },
                    { 11, 49 },
                    { 11, 57 },
                    { 11, 68 },
                    { 11, 86 },
                    { 12, 7 },
                    { 12, 20 },
                    { 12, 27 },
                    { 12, 44 },
                    { 12, 63 },
                    { 12, 78 },
                    { 12, 94 },
                    { 13, 13 },
                    { 13, 30 },
                    { 13, 37 },
                    { 13, 51 },
                    { 13, 58 },
                    { 13, 61 },
                    { 13, 92 },
                    { 14, 26 },
                    { 14, 43 },
                    { 14, 55 },
                    { 14, 69 },
                    { 14, 80 },
                    { 14, 95 },
                    { 15, 16 },
                    { 15, 42 },
                    { 15, 91 },
                    { 16, 34 },
                    { 16, 53 },
                    { 16, 62 },
                    { 16, 70 },
                    { 16, 81 },
                    { 16, 97 },
                    { 17, 22 },
                    { 17, 36 },
                    { 17, 48 },
                    { 17, 59 },
                    { 17, 76 },
                    { 17, 87 },
                    { 18, 14 },
                    { 18, 25 },
                    { 18, 37 },
                    { 18, 54 },
                    { 18, 69 },
                    { 18, 92 },
                    { 19, 17 },
                    { 19, 28 },
                    { 19, 46 },
                    { 19, 63 },
                    { 19, 82 },
                    { 19, 96 },
                    { 20, 11 },
                    { 20, 35 },
                    { 20, 55 },
                    { 20, 66 },
                    { 20, 77 },
                    { 20, 93 },
                    { 21, 9 },
                    { 21, 33 },
                    { 21, 49 },
                    { 21, 58 },
                    { 21, 78 },
                    { 21, 86 },
                    { 22, 10 },
                    { 22, 24 },
                    { 22, 31 },
                    { 22, 40 },
                    { 22, 65 },
                    { 22, 74 },
                    { 23, 15 },
                    { 23, 20 },
                    { 23, 53 },
                    { 23, 64 },
                    { 23, 77 },
                    { 23, 89 },
                    { 24, 21 },
                    { 24, 32 },
                    { 24, 43 },
                    { 24, 56 },
                    { 24, 68 },
                    { 24, 95 },
                    { 25, 13 },
                    { 25, 28 },
                    { 25, 39 },
                    { 25, 52 },
                    { 25, 63 },
                    { 25, 88 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 8, 19 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 8, 20 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 9, 21 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 9, 22 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 9, 23 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 10, 24 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 10, 25 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 11, 26 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 11, 27 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 11, 28 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 12, 29 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 12, 30 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 13, 31 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 13, 32 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 13, 33 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 14, 34 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 14, 35 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 15, 36 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 15, 37 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 15, 38 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 16, 39 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 16, 40 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 17, 41 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 17, 42 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 17, 43 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 18, 44 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 18, 45 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 19, 46 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 19, 47 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 19, 48 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 20, 49 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 20, 50 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 21, 51 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 21, 52 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 21, 53 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 22, 54 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 22, 55 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 23, 56 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 23, 57 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 23, 58 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 24, 59 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 24, 60 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 25, 61 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 25, 62 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 25, 63 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 26, 64 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 26, 65 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 27, 66 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 27, 67 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 27, 68 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 28, 69 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 28, 70 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 29, 71 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 29, 72 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 29, 73 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 30, 74 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 30, 75 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 31, 76 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 31, 77 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 31, 78 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 32, 79 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 32, 80 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 33, 81 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 33, 82 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 33, 83 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 34, 84 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 34, 85 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 35, 86 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 35, 87 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 35, 88 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 36, 89 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 36, 90 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 37, 91 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 37, 92 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 37, 93 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 38, 94 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 38, 95 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 39, 96 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 39, 97 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 39, 98 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 40, 99 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 40, 100 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 1, 73 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 1, 83 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 2, 52 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 2, 62 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 3, 35 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 3, 50 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 3, 67 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 3, 77 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 3, 91 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 4, 31 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 4, 46 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 4, 65 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 4, 75 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 4, 84 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 4, 93 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 5, 28 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 5, 45 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 5, 54 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 5, 76 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 6, 39 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 6, 59 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 6, 71 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 6, 88 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 6, 98 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 7, 60 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 7, 74 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 7, 81 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 7, 97 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 8, 38 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 8, 53 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 8, 64 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 8, 87 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 8, 99 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 9, 24 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 9, 28 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 9, 33 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 9, 45 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 9, 54 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 9, 76 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 10, 37 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 10, 66 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 10, 72 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 11, 22 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 11, 32 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 11, 49 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 11, 57 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 11, 68 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 11, 86 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 12, 27 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 12, 44 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 12, 63 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 12, 78 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 12, 94 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 13, 30 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 13, 37 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 13, 51 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 13, 58 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 13, 61 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 13, 92 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 14, 26 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 14, 43 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 14, 55 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 14, 69 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 14, 80 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 14, 95 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 15, 42 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 15, 91 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 16, 34 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 16, 53 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 16, 62 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 16, 70 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 16, 81 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 16, 97 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 17, 22 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 17, 36 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 17, 48 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 17, 59 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 17, 76 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 17, 87 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 18, 14 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 18, 25 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 18, 37 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 18, 54 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 18, 69 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 18, 92 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 19, 17 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 19, 28 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 19, 46 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 19, 63 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 19, 82 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 19, 96 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 20, 11 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 20, 35 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 20, 55 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 20, 66 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 20, 77 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 20, 93 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 21, 33 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 21, 49 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 21, 58 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 21, 78 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 21, 86 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 22, 24 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 22, 31 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 22, 40 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 22, 65 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 22, 74 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 23, 15 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 23, 20 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 23, 53 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 23, 64 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 23, 77 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 23, 89 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 24, 21 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 24, 32 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 24, 43 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 24, 56 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 24, 68 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 24, 95 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 25, 13 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 25, 28 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 25, 39 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 25, 52 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 25, 63 });

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumns: new[] { "PlaylistId", "SongId" },
                keyValues: new object[] { 25, 88 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);
        }
    }
}
