const BASE_URL = `https://localhost:7002/`;

let CONNECTED = 0;

let NX = 5;
let NY = 5;
const CENTER_X = Math.floor(NX / 2);
const CENTER_Y = Math.floor(NY / 2);
const sizeMap = {x:49, y:49};

const PLAYER_VIEW = 1;
const playerPosition = {y:0, x:0};


let tileList = null;
let playableChar = null;

let mapHtml = [];


let mapJS = new Array(sizeMap.y + 1);
for(var y = 0 ; y <= sizeMap.y ; y++)
{
  mapJS[y] = new Array(sizeMap.x + 1);
  for(var x = 0 ; x <= sizeMap.x ; x++)
  {
    mapJS[y][x] = 0;
  }
}

let moveTop = 'jsp'
let moveBot = 'jsp'
let moveLeft = 'jsp'
let moveRight = 'jsp'

window.onpagehide = () => {
  if(CONNECTED != 0) localStorage.setItem('map', JSON.stringify(mapJS));
}

window.onload = async function() {
  var jsonLocalStorage = JSON.parse(localStorage.getItem('map') ?? 'null');
  mapJS = jsonLocalStorage ?? mapJS;

  
  try {
    CONNECTED = await isConnected(BASE_URL);
    if(CONNECTED === 0)
    {
      await partialView("partial/select-login.html", document.getElementById("main-sidebar"));
    }
    else if (CONNECTED === 1)
    {
      playableChar = await getActualCharacter(BASE_URL);
      // console.log(playableChar);
      await initGame();
      playerPosition.x = playableChar.positionX -1;
      playerPosition.y = playableChar.positionY -1;
      await refreshMap(BASE_URL, playerPosition, mapHtml, mapJS);
      await goAroundPlayer(BASE_URL, playerPosition, mapHtml, mapJS);
      drawWindow(mapJS, mapHtml, playerPosition);
    }
  }
  catch {
    serverIsDown();
  }
      
  if(tileList != null) {
    

    // let colonnesHTML = document.querySelectorAll("#ig_game_grid > tbody > tr");
    // NY = colonnesHTML.length;

    // for (let y = 0 ; y < NY ; y++) {
    //   let lignesTML = colonnesHTML[y].querySelectorAll(".box");
    //   NX = lignesTML.length;
    //   let ligne = [];

    //   for (let x = 0 ; x < NX ; x++) {
    //     let caseHTML = lignesTML[x];
    //     ligne.push(caseHTML);

    //     caseHTML.addEventListener("click", async function(e) {
    //       await visiterUneCase(caseHTML, playerPosition.y + y - 2, playerPosition.x + x - 2, BASE_URL, true);
    //     });
    //   }
    //   mapHtml.push(ligne);
    // }
  }
}

async function partialView(url, toEdit) {
  var response = await fetch(url);
  if (!response.ok) {
    console.error("Contenu inchargeable");
  }
  toEdit.innerHTML = await response.text();
}

function pressKey(event, listMoveBtn)
{
  if(event.key === 'ArrowUp' || event.key === moveTop)
  {
    event.preventDefault();
    listMoveBtn[0].click();
  }
  else if(event.key === 'ArrowDown' || event.key === moveBot)
  {
    event.preventDefault();
    listMoveBtn[1].click();
  }
  else if(event.key === 'ArrowLeft' || event.key === moveLeft)
  {
    event.preventDefault();
    listMoveBtn[2].click();
  }
  else if(event.key === 'ArrowRight' || event.key === moveRight)
  {
    event.preventDefault();
    listMoveBtn[3].click();
  }
  // else if(event.key === 'CapsLock' || event.key === moveRight)
  // {
  //   event.preventDefault();
  //   listMoveBtn[2].click();
  // }
}

async function initCssFromApi(list) {
  let style = document.createElement('style');
  let styleRoot = document.createElement('style');
  if(list != null) {
    styleRoot.innerHTML = ":root {\n";
    list.forEach(tuile => {
      styleRoot.innerHTML += `--url-image-${tuile.nom} : url(${tuile.url});\n`
      style.innerHTML +=
        `.b-${tuile.nom}
        { background-image: var(--url-image-${tuile.nom}); }\n`;
    });
  }
  style.innerHTML += ".b-limit { background-color:var(--ui-red);}";
  styleRoot.innerHTML += "}";
  document.head.appendChild(styleRoot);
  document.head.appendChild(style);
  style = null;
}

function initLegend(list) {
  let legend = document.createElement('ul');
  legend.className = "legend-tile-list"
  var h2 = document.createElement('h2');
  h2.textContent = "Tuiles :"
  if(list != null) {
    list.forEach(t => {
      // console.log(t);
      var li = document.createElement('li');
      li.className = "li-legend"
      var img = document.createElement('div');
      img.className = "legend-img b-" + t.nom;
      li.appendChild(img);

      var ulDetail = document.createElement('ul');
      var liTitle = document.createElement("span");
      liTitle.textContent = t.nom;
      ulDetail.appendChild(liTitle);

      var liToward = document.createElement('li');
      var liText;
      if(t.estTraversable) {
        liText = "Case traversable";
      }
      else {
        liText = "Case non traversable";
      }
      liToward.textContent = liText;
      ulDetail.appendChild(liToward);

      li.appendChild(ulDetail);
      legend.appendChild(li);
    });
  }
  document.getElementById("side-tile-list").appendChild(h2);
  document.getElementById("side-tile-list").appendChild(legend);
}

async function initGame() {
  tileList = await getTileList(BASE_URL);
  initCssFromApi(tileList);

  await partialView("partial/game.html", document.getElementById("main-sidebar"));
  var gridHtml = document.getElementById("ig_game_grid");

  for(let y = 0 ; y < NY ; y++) {
    let tr = document.createElement("tr");
    let line = [];
    for (let x = 0 ; x < NX ; x++) {
      let td = document.createElement("td");
      let div = document.createElement("div");
      div.className = "box";
      td.appendChild(div);
      // if (CONNECTED === 1){
      // }
      // else
      if (CONNECTED === -1 || CONNECTED === 1) {
        td.addEventListener("click", async function(e) {
          await goToOneTile(mapJS, div, playerPosition.y + y - CENTER_Y, playerPosition.x + x - CENTER_X, BASE_URL, true);
        });
      }

      line.push(div);
      tr.appendChild(td);
    }
    mapHtml.push(line);
    gridHtml.appendChild(tr);
  }
  var divPlayer = document.createElement("div");
  divPlayer.id = "player";
  mapHtml[CENTER_Y][CENTER_X].appendChild(divPlayer);

  listBtnMoveIg = document.querySelectorAll(".ig_btn_move");

  
  if (CONNECTED === 1) {
    listBtnMoveIg[0].addEventListener('click', e => {
      moveCharacter(mapJS, mapHtml, playableChar, playerPosition, -1, 0, BASE_URL);
    })

    listBtnMoveIg[1].addEventListener('click', e => {
      moveCharacter(mapJS, mapHtml, playableChar, playerPosition, 1, 0, BASE_URL);
    })

    listBtnMoveIg[2].addEventListener('click', e => {
      moveCharacter(mapJS, mapHtml, playableChar, playerPosition, 0, -1, BASE_URL);
    })

    listBtnMoveIg[3].addEventListener('click', e => {
      moveCharacter(mapJS, mapHtml, playableChar, playerPosition, 0, 1, BASE_URL);
    })
  }


  else if (CONNECTED === -1) {
    listBtnMoveIg[0].addEventListener('click', e => {
      movePlayer(mapJS, mapHtml, playerPosition, -1, 0, BASE_URL);
    })

    listBtnMoveIg[1].addEventListener('click', e => {
      movePlayer(mapJS, mapHtml, playerPosition, 1, 0, BASE_URL);
    })

    listBtnMoveIg[2].addEventListener('click', e => {
      movePlayer(mapJS, mapHtml, playerPosition, 0, -1, BASE_URL);
    })

    listBtnMoveIg[3].addEventListener('click', e => {
      movePlayer(mapJS, mapHtml, playerPosition, 0, 1, BASE_URL);
    })
  }

  document.addEventListener("keydown", e => {pressKey(e, listBtnMoveIg);});

  initLegend(tileList);
}

async function serverIsDown() {
  CONNECTED = 0;
  tileList = null;
  localStorage.clear();
  await partialView("partial/erreur503.html", document.getElementById("main-sidebar"));
}

function playOffline() {
  CONNECTED = -1;
  makeStartingChoice();
}

async function makeStartingChoice() {
  console.log(CONNECTED);
  switch(CONNECTED) {
    case -1 :
      await initGame();
      await refreshMap(BASE_URL, playerPosition, mapHtml, mapJS);
      await goAroundPlayer(BASE_URL, playerPosition, mapHtml, mapJS);
      break;
    case 1 :
      break;
  }
}

async function disconnect() {
  await disconnectApi(BASE_URL);
  CONNECTED = 0;
  localStorage.clear();
  window.location.reload();
}