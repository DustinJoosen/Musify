const ambientMusicSrc = "https://dustinjoosen.github.io/WebArchive/ambient.mp3";

$(document).ready(() => {
    $.post("/api/playlist/UserID").done((data) => {
        globalThis.userid = data;
        let currentSong = localStorage.getItem(data + "currentSong")
        if (currentSong != null) {
            currentSong = JSON.parse(currentSong);
            playAudio(ambientMusicSrc, currentSong.song, currentSong.time, true)
            
        }
        setInterval(() => {
            const player = $("#audioPlayer")[0];
            const playing = $("#nowPlaying")[0];
            const song = playing.innerHTML.split(":")[1].trim();
            if (song != '') {
                localStorage.setItem(globalThis.userid+"currentSong", JSON.stringify({song: song, time: player.currentTime}))
            }
        }, 1000);
    })
    $("#audioPlayer").on("ended", function () {
        playQueue();
    });

    $(".addQueue").on("click", function () {
        const songname = $(this).attr("songname").split(",");
        songname.forEach(song => addToQueue(song));
    });

    $(".songplaybtn").on("click", function () {
        // clearQueue();
        const songname = $(this).attr("songname").split(",");
        songname.forEach(song => addToQueue(song))
        // playQueue();
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
function skipQueue() {
    const player = $("#audioPlayer")[0];
    player.currentTime = 100000000;
}
function playQueue() {
    const queue = getQueue();
    if (queue.length != 0) {
        const song = queue.shift();
        playAudio(ambientMusicSrc, song);
        removeFromQueue(song);
    }
}
function addToQueue(song) {
    const queue = getQueue();
    if(queue.indexOf(song) == -1)
        queue.push(song);
    saveQueue(queue);
}
function position(song, pos) {
    let queue = getQueue();
    var index = queue.indexOf(song)
    if (pos == -1 && index > 0) {
        var current = queue[index];
        var previous = queue[index - 1];
        queue[index - 1] = current;
        queue[index] = previous;
    } else if (pos == 1 && index < (queue.length - 2)) {
        var current = queue[index]
        var next = queue[index + 1];
        queue[index + 1] = current;
        queue[index] = next;
    }
    saveQueue(queue);
}
function getQueue() {
    if (globalThis.userid == null) {
        setTimeout(getQueue, 1000);
    } else {
        let queue = localStorage.getItem(globalThis.userid+"queue");
        if (queue == null)
            queue = "[]"
        queue = JSON.parse(queue);
        return queue;
    }
}

function saveQueue(queue) {
    if (globalThis.userid == null) {
        setTimeout(() => {
            saveQueue(queue);
        }, 1000);
    } else {
        localStorage.setItem(globalThis.userid+"queue", JSON.stringify(queue));
    }
}

function removeFromQueue(song) {
    saveQueue(getQueue().filter(s => s !== song))
}
function clearQueue() {
    saveQueue([]);
}
function playAudio(src, song, time, paused) {
    const player = $("#audioPlayer")[0];
    const playing = $("#nowPlaying")[0];
    playing.innerHTML = `Now playing: ${song}`;
    player.pause();
    if (time) {
        player.currentTime = time;
    }
    player.innerHTML = '';
    $('<source>').attr({
        src: src,
        type: "audio/mp3"
    }).appendTo(player);

    if(paused === undefined)
        player.play();
}
