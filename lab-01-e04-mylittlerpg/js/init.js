const BASE_URL = `https://localhost:7002/`;

let NX = 5;
let NY = 5;

let listeTuiles = null;

let carteHtml = [];

const sizeMap = {x:50, y:50};

const carte = new Array(sizeMap.y + 1);
for(var y = 0 ; y <= sizeMap.y ; y++)
{
    carte[y] = new Array(sizeMap.x + 1);
    for(var x = 0 ; x <= sizeMap.x ; x++)
    {
        carte[y][x] = 0;
    }
}

const caseJoueur = {y:1, x:1};

let movementTop = 'jsp'
let movementBot = 'jsp'
let movementLeft = 'jsp'
let movementRight = 'jsp'
let switchShoot = 'jsp'

window.onload = async function() {

    try 
    {
        listeTuiles = await recupListeTuiles(BASE_URL);
        initCssDepuisApi(listeTuiles);
        console.log(listeTuiles);
    }
    catch(error) {
        listeTuiles = null;
    }
    
    let colonnesHTML = document.querySelectorAll("#ig_game_grid > tbody > tr");
    NY = colonnesHTML.length;

    document.onkeydown = (event) => {
		pressKey(event);
	};

    for (let y = 0 ; y < NY ; y++) {
        let lignesTML = colonnesHTML[y].querySelectorAll(".box");
        NX = lignesTML.length;
        let ligne = [];

        for (let x = 0 ; x < NX ; x++) {
            let caseHTML = lignesTML[x];
            ligne.push(caseHTML);

            caseHTML.addEventListener("click", async function(e) {
                await visiterUneCase(caseHTML, caseJoueur.y + y - 2, caseJoueur.x + x - 2, true);
                // caseHTML.className = "box explored " + intToCaseType(generateNumber(listeTuiles), listeTuiles);
            });
        }
        carteHtml.push(ligne);
    }
    await actualiserCarte(caseJoueur);

    await visiterAutourJoueur(caseJoueur);

    listBtnMoveIg = document.querySelectorAll(".ig_btn_move");

    listBtnMoveIg[0].addEventListener('click', e => {
        deplacerJoueur(carte, caseJoueur, 0, -1);
    })

    listBtnMoveIg[1].addEventListener('click', e => {
        deplacerJoueur(carte, caseJoueur, 0, 1);
    })

    listBtnMoveIg[2].addEventListener('click', e => {
        deplacerJoueur(carte, caseJoueur, -1, 0);
    })

    listBtnMoveIg[3].addEventListener('click', e => {
        deplacerJoueur(carte, caseJoueur, 1, 0);
    })

    document.addEventListener("keypress", e => {pressKey(e, listBtnMoveIg);});

    initLegende(listeTuiles);

    // for()
    // {
    //     trCarte[i].addEventListener("click", (e) => {
    //         trCarte[i].className = "box explored " + intToCaseType(generateNumber(listeTuiles) , listeTuiles);
    //          console.error(i);

    //     });
    // }
}

function pressKey(event, listMoveBtn)
{
    if(event.key === 'ArrowUp' || event.key === movementTop)
    {
        event.preventDefault();
        listMoveBtn[0].click();
    }
    else if(event.key === 'ArrowDown' || event.key === movementBot)
    {
        event.preventDefault();
        listMoveBtn[1].click();
    }
    else if(event.key === 'ArrowLeft' || event.key === movementLeft)
    {
        event.preventDefault();
        listMoveBtn[2].click();
    }
    else if(event.key === 'ArrowRight' || event.key === movementRight)
    {
        event.preventDefault();
        listMoveBtn[3].click();
    }
    // else if(event.key === 'CapsLock' || event.key === movementRight)
    // {
    //     event.preventDefault();
    //     listMoveBtn[2].click();
    // }
}


async function initCssDepuisApi(liste) {
    let style = document.createElement('style');
    if(liste != null) {
        liste.forEach(tuile => {
            document.documentElement.style.setProperty(
                '--url-image-' + tuile.nom ,
                'url('+ tuile.url +')'
            );
            
            style.innerHTML += 
                '.b-' + tuile.nom +
                '{ background-image: var(--url-image-' + tuile.nom + '); }\n';
        });
    }
    style.innerHTML += ".b-limit { background-color:var(--ui-red);}"

    document.head.appendChild(style);
    style = null;
}

function initLegende(liste) {
    let legende = document.createElement('ul');
    if(liste != null) {
        liste.forEach(t => {
            var li = document.createElement('li');
            li.className = "li-legend"
            var img = document.createElement('div');
            img.className = "legend-img b-" + t.nom;
            // img.style.setProperty("height", "32px");
            li.appendChild(img);
            var span = document.createElement("span");
            span.textContent = t.nom;
            li.appendChild(span);
            legende.appendChild(li);
        });
    }
    document.getElementById("side-tile-list").appendChild(legende);
}

async function recupListeTuiles(siteUrl) {
    try {
        var url = siteUrl + `api/Tuile/all`;
        let response = await fetch(url);

        if (!response.ok) {
            throw new Error(`Erreur HTTP: ${response.status}`);
        }

        var tuiles = await response.json();
        return tuiles;

    } catch (error) {
        // console.error('Erreur lors du chargement:', error);
    }
}

async function avoirTuile(siteUrl, x, y) {
    try {
        var url = siteUrl + `api/Tuile/`+(x+1)+`/`+(y+1);
        console.log(url);
        let response = await fetch(url);
        
        if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
        }
        
        var tuile = await response.json();
        return tuile;
        
    } catch (error) {
        // console.error('Erreur lors du chargement:', error);
    }
}

async function visiterAutourJoueur(joueur)
{
    for (let y = joueur.y - 1 ; y < joueur.y + 2 ; y++) {
        for (let x = joueur.x - 1 ; x < joueur.x + 2 ; x++) {
            // console.log((y - joueur.y + 2) + " | " + (x - joueur.x + 2))
            await visiterUneCase(carteHtml[y - joueur.y + 2][x - joueur.x + 2], y, x, true);
        }
    }
}

async function visiterUneCase(carreHTML, y, x, clique=false)
{
    if( estHorsMap(y, x) || listeTuiles == null) {
        carreHTML.className = "box explored b-limit";
    }
    else {
        let tuile = null;
        var ajouteText = "";
        if (carte[y][x] == 0) {
            if (clique) {
                tuile = await avoirTuile(BASE_URL, x, y);
                carte[y][x] = tuile;
            }
        }
        else {
            tuile = carte[y][x];
        }

        if (tuile != null) {
            var typeTuile = listeTuiles.find(t =>
                t.type == tuile.type
            );
            ajouteText = typeTuile.nom;
        }
        carreHTML.className = "box explored b-" + ajouteText;
    }
}

function estHorsMap(x, y) {
    return x < 0 || y < 0  || x > sizeMap.x || y > sizeMap.y;
}

async function deplacerJoueur(carteJeu, joueur, depX, depY) {
    if ((depX != depY && depX != -depY) && (depX == 1 || depX == 0 || depX == -1) && (depY == 1 || depY == 0 || depY == -1) ) {
        var postDeplX = joueur.x + depX;
        var postDeplY = joueur.y + depY;

        if (!estHorsMap(postDeplX, postDeplY) && carteJeu[postDeplY][postDeplX].estTraversable) {
            joueur.x = postDeplX;
            joueur.y = postDeplY;
            console.log(joueur)
            // console.error("JOUEUR : " + caseJoueur.y + " | " + caseJoueur.x);
            await actualiserCarte(joueur);
        }
    }
}

async function actualiserCarte(joueur){
    for (let y = joueur.y - 2 ; y < joueur.y + 3 ; y++) {
        for (let x = joueur.x - 2 ; x < joueur.x + 3 ; x++) {
            // console.log((y - joueur.y + 2) + " | " + (x - joueur.x + 2))
            await visiterUneCase(carteHtml[y - joueur.y + 2][x - joueur.x + 2], y, x);
        }
    }
    await visiterAutourJoueur(joueur);

    // for (let y = caseJoueur.y - 2 ; y < caseJoueur.y + NY - 2 ; y++) {
    //     for (let x = caseJoueur.x - 2 ; x < caseJoueur.x + NX - 2 ; x++) {
    //         await visiterUneCase(carteHtml[y - caseJoueur.y + 2][x - caseJoueur.x + 2], x, y);
    //     }
    // }
}

function pressKey(event)
{
    if(event.key === 'ArrowUp' || event.key === movementTop)
    {
        event.preventDefault();
        listBtnMoveIg[0].click();
    }
    else if(event.key === 'ArrowDown' || event.key === movementBot)
    {
        event.preventDefault();
        listBtnMoveIg[1].click();
    }
    else if(event.key === 'ArrowLeft' || event.key === movementLeft)
    {
        event.preventDefault();
        listBtnMoveIg[2].click();
    }
    else if(event.key === 'ArrowRight' || event.key === movementRight)
    {
        event.preventDefault();
        listBtnMoveIg[3].click();
    }
}