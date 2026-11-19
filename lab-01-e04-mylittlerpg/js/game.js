async function goAroundPlayer(siteUrl, player, htmlMap, jsMap) {
    for (let vision_y = -PLAYER_VIEW ; vision_y <= PLAYER_VIEW ; vision_y++) {
        for (let vision_x = -PLAYER_VIEW; vision_x <= PLAYER_VIEW; vision_x++) {
            await goToOneTile(jsMap, htmlMap[CENTER_Y + vision_y][CENTER_X + vision_x], player.y + vision_y, player.x + vision_x, siteUrl, true);
        }
    }
}

async function goToOneTile(jsMap, divBoxHtml, y, x, siteUrl, clique=false) {
    if(isOutMap(y, x) || tileList == null) {
        divBoxHtml.className = "box explored b-limit";
    }
    else {
        let tile = null;
        var textToAdd = "";
        if (jsMap[y][x] === null) {
            if (clique) {
                try {
                    if(CONNECTED === -1) {
                        tile = await getOneTile(siteUrl, y, x);
                    }
                    else if(CONNECTED === 1) {
                        tile = await getTileArounCharApi(siteUrl, playableChar.id, y, x);
                    }
                        
                }
                catch(error) {
                    console.error(error);
                    serverIsDown();
                }
                jsMap[y][x] = tile;
            }
        }
        else {
            tile = jsMap[y][x];
        }

        if (tile != null) {
            var typetile = tileList.find(t =>
                t.type == tile.type
            );
            textToAdd = typetile.name;
        }
        divBoxHtml.className = "box explored b-" + textToAdd;
    }
}

function isOutMap(y, x) {
    return x < 0 || y < 0  || x > sizeMap.x || y > sizeMap.y;
}

async function movePlayer(jsMap, htmlMap, player, depY, depX, siteUrl) {
    if ((depX != depY && depX != -depY) && (depX == 1 || depX == 0 || depX == -1) && (depY == 1 || depY == 0 || depY == -1) ) {
        var postDeplY = player.y + depY;
        var postDeplX = player.x + depX;

        if (!isOutMap(postDeplY, postDeplX) && jsMap[postDeplY][postDeplX].canGoThrough) {
            player.y = postDeplY;
            player.x = postDeplX;
            await refreshMap(siteUrl, player, htmlMap, jsMap);
        }
    }
}

async function refreshMap(siteUrl, player, htmlMap, jsMap) {
    // for (let y = player.y - CENTER_Y ; y < player.y + PLAYER_VIEW ; y++) {
    //     for (let x = player.x - CENTER_X ; x < player.x + PLAYER_VIEW ; x++) {
    //         await goToOneTile(htmlMap[y - player.y + CENTER_Y][x - player.x + CENTER_X], y, x, siteUrl, true);
    //     }
    // }
    for (let dy = -CENTER_Y; dy < NY - CENTER_Y; dy++) {
        for (let dx = -CENTER_X; dx < NX - CENTER_X; dx++) {
            await goToOneTile(jsMap, htmlMap[CENTER_Y + dy][CENTER_X + dx], player.y + dy, player.x + dx, siteUrl);
        }
    }
    await goAroundPlayer(siteUrl, player, htmlMap, jsMap);
}

// ========= AFTER CONNECTION

// Affiche UNE case depuis une donnée déjà en mémoire (aucun appel API)
function drawTile(divBoxHtml, tile) {
    if (tile == null || tile == 0) {
        divBoxHtml.className = "box";
        return;
    }
    var typeTile = tileList.find(t => t.type == tile.type);
    divBoxHtml.className = "box explored b-" + (typeTile ? typeTile.name : "");
}

// Écrit les tuiles renvoyées par l'API dans jsMap (API en base 1, jsMap en base 0)
function applyTilesToMap(jsMap, tiles) {
    tiles.forEach(t => {
        jsMap[t.y - 1][t.x - 1] = t;
    });
}

// Redessine la fenêtre 5x5 autour du joueur, uniquement depuis jsMap
function drawWindow(jsMap, htmlMap, player) {
    for (let dy = -CENTER_Y; dy < NY - CENTER_Y; dy++) {
        for (let dx = -CENTER_X; dx < NX - CENTER_X; dx++) {
            var y = player.y + dy;
            var x = player.x + dx;
            var div = htmlMap[CENTER_Y + dy][CENTER_X + dx];
            if (isOutMap(y, x)) {
                div.className = "box explored b-limit";
            }
            else {
                drawTile(div, jsMap[y][x]);
            }
        }
    }
}

let isMoving = false;

async function moveCharacter(jsMap, htmlMap, character, player, depY, depX, siteUrl) {
    if (isMoving) return;

    if ((depX != depY && depX != -depY) && (depX == 1 || depX == 0 || depX == -1) && (depY == 1 || depY == 0 || depY == -1) ) {
        var postDeplY = player.y + depY;
        var postDeplX = player.x + depX;

        if (!isOutMap(postDeplY, postDeplX) && jsMap[postDeplY][postDeplX].canGoThrough) {
            isMoving = true;
            try {
                var result = await moveCharApi(siteUrl, {y: postDeplY, x: postDeplX}, character.id);

                // Le serveur fait foi (API en base 1, player en base 0)
                character.posY = result.finalY;
                character.posX = result.finalX;
                player.y = result.finalY - 1;
                player.x = result.finalX - 1;

                if (result.isCorrect && result.tiles != null) {
                    applyTilesToMap(jsMap, result.tiles);
                }

                drawWindow(jsMap, htmlMap, player);
            }
            catch(error) {
                console.error(error);
            }
            finally {
                isMoving = false;
            }
        }
    }
}