window.onload = () => {
    const NROWS = 5;
    const NCOLS = 5;

    let boxesInGrid = document.querySelectorAll("#ig_game_grid .box");

    for(let i = 0 ; i < NROWS*NCOLS ; i++)
    {
        boxesInGrid[i].addEventListener("click", (e) => {
            boxesInGrid[i].className = "box explored " + intToCaseType(generateNumber());
            console.error(i);
        });
    }

    let gridJS = new Array(50);
    for(var x = 0 ; x < 50 ; x++)
    {
        gridJS[x] = new Array(50);
        for(var y = 0 ; y < 50 ; y++)
        {
            gridJS[x][y] = 0;
        }
    }


}

function generateNumber()
{
    return Math.floor(Math.random() * 6)+1;
}

function intToCaseType(n)
{
    var caseType = "";
    switch(n)
    {
        case 1 :
            caseType = "b-forest";
            break;
        case 2 :
            caseType = "b-mountain";
            break
        case 3 :
            caseType = "b-plains";
            break
        case 4 :
            caseType = "b-river";
            break
        case 5 :
            caseType = "b-road";
            break
        case 6 :
            caseType = "b-town";
            break
    }
    return caseType
}