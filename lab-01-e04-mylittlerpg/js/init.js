const BASE_URL = `https://localhost:7002/`;

let NX = 5;
let NY = 5;

let liste_tuiles;

let carteHtml = [];

const carte = new Array(51);
for(var y = 0 ; y <= 50 ; y++)
{
    carte[y] = new Array(50);
    for(var x = 0 ; x <= 50 ; x++)
    {
        carte[y][x] = 0;
    }
}

const caseJoueur = {y:1, x:1};

window.onload = async function() {

    liste_tuiles = await recupListeTuiles(BASE_URL);
    initCssDepuisApi(liste_tuiles);
    
    let colonnesHTML = document.querySelectorAll("#ig_game_grid > tbody > tr");
    NY = colonnesHTML.length;

    for (let y = 0 ; y < NY ; y++) {
        let lignesTML = colonnesHTML[y].querySelectorAll(".box");
        NX = lignesTML.length;
        let ligne = [];

        for (let x = 0 ; x < NX ; x++) {
            let caseHTML = lignesTML[x];
            ligne.push(caseHTML);

            caseHTML.addEventListener("click", async function(e) {
                await visiterUneCase(caseHTML, caseJoueur.y + y - 2, caseJoueur.x + x - 2, true);
                // caseHTML.className = "box explored " + intToCaseType(generateNumber(liste_tuiles), liste_tuiles);
            });
        }
        carteHtml.push(ligne);
    }
    await actualiserCarte();

    await visiterAutourJoueur();
    document.getElementById("ig_btn_move-top").addEventListener('click', e => {
        deplacerJoueur(0, -1);
    })

    document.getElementById("ig_btn_move-bot").addEventListener('click', e => {
        deplacerJoueur(0, 1);
    })

    document.getElementById("ig_btn_move-left").addEventListener('click', e => {
        deplacerJoueur(-1, 0);
    })

    document.getElementById("ig_btn_move-right").addEventListener('click', e => {
        deplacerJoueur(1, 0);
    })


    // for()
    // {
    //     trCarte[i].addEventListener("click", (e) => {
    //         trCarte[i].className = "box explored " + intToCaseType(generateNumber(liste_tuiles) , liste_tuiles);
    //          console.error(i);

    //     });
    // }
}

async function initCssDepuisApi(liste)
{
    let style = document.createElement('style');
    
    liste.forEach(tuile => {
        document.documentElement.style.setProperty(
            '--url-image-' + tuile.nom ,
            'url('+ tuile.url +')'
        );
        
        style.innerHTML += 
            '#ig_game_grid .b-' + tuile.nom +
            '{ background-image: var(--url-image-' + tuile.nom + '); }';
    });
    style.innerHTML += "#ig_game_grid .b-limit { background-color:var(--ui-red);}"

    document.head.appendChild(style);
    style = null;
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
        console.error('Erreur lors du chargement:', error);
    }
}

async function avoirTuile(siteUrl, x, y) {
    try {
        var url = siteUrl + `api/Tuile/`+(x+1)+`/`+(y+1);
        let response = await fetch(url);
        
        if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
        }
        
        var tuile = await response.json();
        return tuile;
        
    } catch (error) {
        console.error('Erreur lors du chargement:', error);
    }
}

async function visiterAutourJoueur()
{
    for (let y = caseJoueur.y - 1 ; y < caseJoueur.y + 2 ; y++) {
        for (let x = caseJoueur.x - 1 ; x < caseJoueur.x + 2 ; x++) {
            // console.log((y - caseJoueur.y + 2) + " | " + (x - caseJoueur.x + 2))
            await visiterUneCase(carteHtml[y - caseJoueur.y + 2][x - caseJoueur.x + 2], y, x, true);
        }
    }
}

async function visiterUneCase(carreHTML, y, x, clique=false)
{
    if(x < 0 || y < 0  || x > 50 || y > 50) {
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
            var typeTuile = liste_tuiles.find(t =>
                t.type == tuile.type
            );
            ajouteText = typeTuile.nom;
        }
        carreHTML.className = "box explored b-" + ajouteText;
    }
}

async function deplacerJoueur(depX, depY) {
    if ((depX != depY && depX != -depY) && (depX == 1 || depX == 0 || depX == -1) && (depY == 1 || depY == 0 || depY == -1) ) {
        caseJoueur.x += depX;
        caseJoueur.y += depY;
        // console.error("JOUEUR : " + caseJoueur.y + " | " + caseJoueur.x);
        await actualiserCarte();
    }
}

async function actualiserCarte(){
    for (let y = caseJoueur.y - 2 ; y < caseJoueur.y + 3 ; y++) {
        for (let x = caseJoueur.x - 2 ; x < caseJoueur.x + 3 ; x++) {
            // console.log((y - caseJoueur.y + 2) + " | " + (x - caseJoueur.x + 2))
            await visiterUneCase(carteHtml[y - caseJoueur.y + 2][x - caseJoueur.x + 2], y, x);
        }
    }
    await visiterAutourJoueur();

    // for (let y = caseJoueur.y - 2 ; y < caseJoueur.y + NY - 2 ; y++) {
    //     for (let x = caseJoueur.x - 2 ; x < caseJoueur.x + NX - 2 ; x++) {
    //         await visiterUneCase(carteHtml[y - caseJoueur.y + 2][x - caseJoueur.x + 2], x, y);
    //     }
    // }
}