const BASE_URL = `https://localhost:7002/`;

let NX = 5;
let NY = 5;

let liste_tuiles;

let carteHtml = [];

let carte = new Array(50);
for(var x = 0 ; x < 50 ; x++)
{
    carte[x] = new Array(50);
    for(var y = 0 ; y < 50 ; y++)
    {
        carte[x][y] = 0;
    }
}

window.onload = async function() {

    liste_tuiles = await recupListeTuiles(BASE_URL);
    initCssDepuisApi(liste_tuiles);
    
    let colonnesHTML = document.querySelectorAll("#ig_game_grid > tbody > tr");
    NY = colonnesHTML.length;

    for (let y = 0; y < NY; y++) {
        let lignesTML = colonnesHTML[y].querySelectorAll(".box");
        NX = lignesTML.length;
        let ligne = [];

        for (let x = 0; x < NX; x++) {
            let caseHTML = lignesTML[x];
            ligne.push(caseHTML);

            caseHTML.addEventListener("click", async function(e) {
                let tuile = await avoirTuile(BASE_URL, x, y);
                carte[y][x] = tuile;
                typeTuile = liste_tuiles.find(t =>
                    t.type == tuile.type
                )
                caseHTML.className = "box explored b-" + typeTuile.nom;
                // caseHTML.className = "box explored " + intToCaseType(generateNumber(liste_tuiles), liste_tuiles);
                console.log(x + ' | ' + y);
                console.log(carte);
            });
        }
        carteHtml.push(ligne);
    }

    // for()
    // {
    //     trCarte[i].addEventListener("click", (e) => {
    //         trCarte[i].className = "box explored " + intToCaseType(generateNumber(liste_tuiles) , liste_tuiles);
    //          console.error(i);

    //     });
    // }
}

function generateNumber(liste)
{
    return Math.floor(Math.random() * liste.length);
}

function intToCaseType(n)
{
    return 'b-' + liste_tuiles[n].nom;
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
