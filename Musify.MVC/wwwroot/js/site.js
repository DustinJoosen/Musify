$(document).ready(() => {
    $(".songplaybtn").on("click", () => {
        new Audio("https://henryruss2.github.io/rickroll.mp3").play();
    });

    $(".songlikebtn").on("click", function () {
        $(this).toggleClass("liked");
        let songid = parseInt($(this).attr("songid"));
        $.post("/api/Likes/ToggleUserLikeSong/" + songid);
    })
    $(".albumlikebtn").on("click", function () {
        $(this).toggleClass("liked");
        let albumid = parseInt($(this).attr("albumid"));
        $.post("/api/Likes/ToggleUserLikeAlbum/" + albumid);
    })
    $(".artistlikebtn").on("click", function () {
        $(this).toggleClass("liked");
        let artistid = parseInt($(this).attr("artistid"));
        $.post("/api/Likes/ToggleUserLikeArtist/" + artistid);
    })
})
