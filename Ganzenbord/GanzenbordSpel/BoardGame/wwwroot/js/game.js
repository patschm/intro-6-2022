$(document).ready(async () => {
    const positions = [{ "x": 144, "y": 659 }, { "x": 314, "y": 661 }, { "x": 372, "y": 663 }, { "x": 426, "y": 664 }, { "x": 489, "y": 664 }, { "x": 554, "y": 668 }, { "x": 628, "y": 664 }, { "x": 690, "y": 666 }, { "x": 742, "y": 654 }, { "x": 815, "y": 624 }, { "x": 872, "y": 582 }, { "x": 903, "y": 532 }, { "x": 930, "y": 487 }, { "x": 947, "y": 432 }, { "x": 951, "y": 364 }, { "x": 946, "y": 300 }, { "x": 924, "y": 245 }, { "x": 884, "y": 200 }, { "x": 842, "y": 149 }, { "x": 758, "y": 113 }, { "x": 673, "y": 99 }, { "x": 616, "y": 96 }, { "x": 555, "y": 97 }, { "x": 490, "y": 93 }, { "x": 428, "y": 97 }, { "x": 373, "y": 93 }, { "x": 310, "y": 99 }, { "x": 252, "y": 113 }, { "x": 198, "y": 151 }, { "x": 159, "y": 190 }, { "x": 139, "y": 242 }, { "x": 125, "y": 300 }, { "x": 131, "y": 365 }, { "x": 147, "y": 423 }, { "x": 170, "y": 468 }, { "x": 211, "y": 512 }, { "x": 259, "y": 544 }, { "x": 320, "y": 560 }, { "x": 374, "y": 564 }, { "x": 430, "y": 561 }, { "x": 497, "y": 567 }, { "x": 552, "y": 562 }, { "x": 631, "y": 560 }, { "x": 688, "y": 562 }, { "x": 747, "y": 545 }, { "x": 804, "y": 513 }, { "x": 841, "y": 459 }, { "x": 855, "y": 407 }, { "x": 856, "y": 353 }, { "x": 832, "y": 299 }, { "x": 795, "y": 242 }, { "x": 733, "y": 211 }, { "x": 655, "y": 194 }, { "x": 560, "y": 197 }, { "x": 484, "y": 197 }, { "x": 425, "y": 200 }, { "x": 368, "y": 198 }, { "x": 310, "y": 203 }, { "x": 242, "y": 244 }, { "x": 215, "y": 329 }, { "x": 241, "y": 400 }, { "x": 278, "y": 432 }, { "x": 319, "y": 454 }, { "x": 571, "y": 448 }];
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/game")
        .build();
    const diceButton = $("#throwDices");
    const startButton = $("#start");
    const gameid = $("#gameId").val();
    const userid = $("#userId").val();
    const username = $("#userName").val();
    const usercolor = $("#userColor").val();
    const gamestate = $("#gameState");
   
    await connection.start();
    const connectionId = await connection.invoke("GetConnectionId");
    const movepawn = ($elem, startPos, endPos) => {
        let promises = [];
        for (let idx = startPos; idx <= endPos; idx++) {
            promises.push($elem.animate({ left: positions[idx].x, top: positions[idx].y }, { duration: "1s", easing: "swing" }).promise());
            // TODO walk back
        }
        return Promise.all(promises);
    };

    const moveplayers = (players) => {
        let promises = [];
        $.each(players, (idx, player) => {
            let pl = $("#" + player.id);
            if (pl.length == 0) {
                pl = $("<div>").addClass("token")
                    .attr("id", player.id)
                    .attr("data-position", player.position)
                    .css("background-color", player.color)
                    .text(player.name)
                    .appendTo($("div#board"));
            }
            let oldPos = pl.attr("data-position");
            promises.push(movepawn(pl, oldPos, player.position));
            pl.attr("data-position", player.position);
        });
        return Promise.all(promises);
    };  
    
    connection.on("changeState", async (state) => {
        diceButton.prop("disabled", true);
        await moveplayers(state.players);
        if (!state.isEnded) {
            if (state.currentPlayer?.id == userid) diceButton.prop("disabled", false);
        }  
    });

    connection.on("throw", state => {
        $("#status")
            .css("background-color", state.color)
            .text(`${state.name} throws: dice1: ${state.dice1}, dice2: ${state.dice2}`);
    });
    connection.on("register", (state) => {
        $("#status")
            .css("background-color", state.color)
            .text(`${state.name} joined the game`);
    });
    connection.on("unregister", (state) => {
        $("#status")
            .css("background-color", state.color)
            .text(`${state.name} has left the game`);
    });
    connection.on("gamestate", (state) => {

        $("<h3>").text(state).appendTo(gamestate);
        gamestate.scrollTop(100000000);
    });
    startButton.click(async () => {
        try {
            await fetch("/home/start?gameId=" + gameid);
            startButton.hide();
        }
        catch (e) {
            console.error(e);
        }
    });
    diceButton.click(async () => {
        try {
            await fetch("/home/throw?gameId=" + gameid);
        }
        catch (e) {
            console.error(e);
        }
    });
    $(window).bind("beforeunload", async () => {      
        connection.invoke("LeaveGame", connectionId, gameid, username, usercolor);
        await fetch("/home/leave?gameId=" + gameid);
    });
    await connection.invoke("JoinGame", connectionId, gameid, username, usercolor);
    await fetch("/home/state?gameId=" + gameid);
});
