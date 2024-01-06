$(document).ready(() => {
    $(".songplaybtn").on("click", () => {
        new Audio("https://henryruss2.github.io/rickroll.mp3").play();
    });

    $(".songlikebtn").on("click", function () {
        $(this).toggleClass("liked");
        let songid = parseInt($(this).attr("songid"));
        $.post("/api/Likes/ToggleUserLikeSong/" + songid);
    });
    $(".albumlikebtn").on("click", function () {
        $(this).toggleClass("liked");
        let albumid = parseInt($(this).attr("albumid"));
        $.post("/api/Likes/ToggleUserLikeAlbum/" + albumid);
    });
    $(".artistlikebtn").on("click", function () {
        $(this).toggleClass("liked");
        let artistid = parseInt($(this).attr("artistid"));
        $.post("/api/Likes/ToggleUserLikeArtist/" + artistid);
    });
    $(".playlistlikebtn").on("click", function () {
        $(this).toggleClass("liked");
        let playlistid = parseInt($(this).attr("playlistid"));
        $.post("/api/Likes/ToggleUserLikePlaylist/" + playlistid);
    });

    $(".refreshmixlistbtn").on("click", function () {
        $(".loading-mix").css("display", "block");
        $.post("/api/MixGenerator/Generate")
            .done(function (data) {
                $(".loading-mix").css("display", "none");
                $(".reload-message").css("display", "block");
            })
    });
})