import { Dice } from '/js/dice.js';
$(document).ready(async () => {
    const positions = [{ "x": 144, "y": 659 }, { "x": 314, "y": 661 }, { "x": 372, "y": 663 }, { "x": 426, "y": 664 }, { "x": 489, "y": 664 }, { "x": 554, "y": 668 }, { "x": 628, "y": 664 }, { "x": 690, "y": 666 }, { "x": 742, "y": 654 }, { "x": 815, "y": 624 }, { "x": 872, "y": 582 }, { "x": 903, "y": 532 }, { "x": 930, "y": 487 }, { "x": 947, "y": 432 }, { "x": 951, "y": 364 }, { "x": 946, "y": 300 }, { "x": 924, "y": 245 }, { "x": 884, "y": 200 }, { "x": 842, "y": 149 }, { "x": 758, "y": 113 }, { "x": 673, "y": 99 }, { "x": 616, "y": 96 }, { "x": 555, "y": 97 }, { "x": 490, "y": 93 }, { "x": 428, "y": 97 }, { "x": 373, "y": 93 }, { "x": 310, "y": 99 }, { "x": 252, "y": 113 }, { "x": 198, "y": 151 }, { "x": 159, "y": 190 }, { "x": 139, "y": 242 }, { "x": 125, "y": 300 }, { "x": 131, "y": 365 }, { "x": 147, "y": 423 }, { "x": 170, "y": 468 }, { "x": 211, "y": 512 }, { "x": 259, "y": 544 }, { "x": 320, "y": 560 }, { "x": 374, "y": 564 }, { "x": 430, "y": 561 }, { "x": 497, "y": 567 }, { "x": 552, "y": 562 }, { "x": 631, "y": 560 }, { "x": 688, "y": 562 }, { "x": 747, "y": 545 }, { "x": 804, "y": 513 }, { "x": 841, "y": 459 }, { "x": 855, "y": 407 }, { "x": 856, "y": 353 }, { "x": 832, "y": 299 }, { "x": 795, "y": 242 }, { "x": 733, "y": 211 }, { "x": 655, "y": 194 }, { "x": 560, "y": 197 }, { "x": 484, "y": 197 }, { "x": 425, "y": 200 }, { "x": 368, "y": 198 }, { "x": 310, "y": 203 }, { "x": 242, "y": 244 }, { "x": 215, "y": 329 }, { "x": 241, "y": 400 }, { "x": 278, "y": 432 }, { "x": 319, "y": 454 }, { "x": 571, "y": 448 }];
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/game")
        .build();
    const diceButton = $("#throwDices");
    const gameid = $("#gameId").val();
    const userid = $("#userId").val();
    const username = $("#userName").val();
    const usercolor = $("#userColor").val();
    const messages = $("#messages");
    const dice1 = new Dice("dice1");
    const dice2 = new Dice("dice2");
    dice1.value = 6;
    dice2.value = 6;
    let isCloseRequested = false;
    let isMoving = false;
         
    await connection.start();
    const connectionId = await connection.invoke("GetConnectionId");

    const findOrCreatePlayer = (id, name, color) => {
        let token = $(`#${id}`)
        if (token == null || token.length == 0) {
            $("<div>").addClass("token")
                .attr({
                    "id": id,
                    "data-position": 0
                })
                .css({
                    "background-color": color,
                    "left": positions[0].x,
                    "top": positions[0].y
                })
                .text(name)
                .appendTo($("div#board"));
        }
        return token;
    }
    const moveone = ($elem, left, top) => {
        return $elem.animate({ left: left-15, top: top-15 }, { duration: "1s", easing: "swing" }).promise()
    }
    const movepawn = ($token, startPos, endPos, absPos) => {
        let promises = [];
        if (absPos >= positions.length) {
            // Part of the movement is walking back. First move to 63 (positions.length - 1)
            let idx = startPos;
            for (; idx < positions.length; idx++) {
                promises.push(moveone($token, positions[idx].x, positions[idx].y));
            }
            // And now walk back. We're already on 63 so next position is 62
            for (idx-=2; idx >= endPos; idx--) {
                promises.push(moveone($token, positions[idx].x, positions[idx].y));
            }
        }
        else {
            // Normal behavior
            for (let idx = startPos; idx <= endPos; idx++) {
                promises.push(moveone($token, positions[idx].x, positions[idx].y));
            }
        }
        return Promise.all(promises);
    };
    const moveplayer = async (player) => {
        let token = findOrCreatePlayer(player.id);
        if (token != null) {
            let oldPos = token.attr("data-position");
            // Routine need to know when to walk back.
            // Since player.position is already corrected it is useless.
            let absolutePos = parseInt(oldPos) + dice1.value + dice2.value;
            isMoving = true;
            await movepawn(token, oldPos, player.position, absolutePos);
            token.attr("data-position", player.position);
            isMoving = false;
        }
    };  
   
    connection.on("close", async (error) => {
        // Since a year Chrome closes connections after 3 minutes when not in focus.
        // this workaround reopens it. Check if it is an official close.
        if (!isCloseRequested) {
            await connection.start();
        }
    });
    connection.on("changeState", async (state) => {
        diceButton.prop("disabled", true);
        if (!state.isStarted && !state.isEnded) {
            $(state.players).each((idx, player) => {
                findOrCreatePlayer(player.id, player.name, player.color);
            });
        }
        else {
            await moveplayer(state.current);
        }
        if (state.isEnded) {
            $("#status")
                .css("background-color", state.current.color)
                .text(`Game over: ${state.current.name} has won.`);
            diceButton.prop("disabled", true);
            isCloseRequested = true;
            connection.stop();
        }      
    });

    connection.on("throw", state => {
        dice1.value = state.dice1;
        dice2.value = state.dice2      
    });
    connection.on("register", async (state) => {
        $("#status")
            .css("background-color", state.color)
            .text(`${state.name} joined the game`);
        await fetch("/home/state?gameId=" + gameid);
    });
    connection.on("unregister", (state) => {
        $("#status")
            .css("background-color", state.color)
            .text(`${state.name} has left the game`);
    });
    connection.on("message", (state) => {
        $("<h3>").text(state).appendTo(messages);
        messages.scrollTop(100000000);
    });
    connection.on("started", (state) => {
        if (state.current.id == userid) {
            diceButton.prop("disabled", false);
        }
    });
    connection.on("nextturn", (state) => {
        $("#status")
            .css("background-color", state.current.color)
            .text(`${state.current.name}'s turn`);
        let interval = setInterval(() => {
            if (!isMoving) { 
                if (state.current.id == userid) {
                    diceButton.prop("disabled", false);
                }
                clearInterval(interval);
            }
        }, 500)
    });
    $("#start").click(async () => {
        try {
            isCloseRequested = false;
            await fetch("/home/start?gameId=" + gameid);
            $("#start").hide();
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
        connection.invoke("LeaveGame", connectionId, gameid, userid, username, usercolor);
        await fetch("/home/leave?gameId=" + gameid);
        isCloseRequested = true;
        connection.stop();
    });
    await connection.invoke("JoinGame", connectionId, gameid, userid, username, usercolor);
});
