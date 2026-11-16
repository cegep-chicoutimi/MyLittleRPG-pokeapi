async function getTileList(siteUrl) {
    try {
        var url = siteUrl + `api/Tuile/all`;
        let response = await fetch(url, {
            method: 'get',
            credentials: 'include',
        });

        if (!response.ok) {
            throw new Error(`Erreur HTTP: ${response.status}`);
        }

        var tuiles = await response.json();
        return tuiles;

    } catch (error) {
        ('Erreur fetch :', error);
        return null;
    }
}

async function getOneTile(siteUrl, y, x) {
    var url = siteUrl + `api/Tuile/${x+1}/${y+1}`;

    // console.log(url);
    let response = await fetch(url, {
        method: 'get',
        credentials: 'include',
    });
    
    if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
    }
    
    var tuile = await response.json();
    return tuile;
}

async function connect(siteUrl, data) {
    try { // https://www.youtube.com/watch?v=fGYQJAlLD68
        var url = siteUrl + `api/auth/login`;

        let response = await fetch(url, {
            method: 'POST',
            credentials: 'include',
            body: data
        });

        if (!response.ok) {
            throw new Error(`Erreur HTTP: ${response.status}`);
        }

        var reussite = await response.json();
        console.log(response)
        return reussite;

    } catch (error) {
        console.error('Erreur fetch :', error);
        return 0;
    }
}

async function register(siteUrl, data) {
    try {
        var url = siteUrl + `api/auth/register`;

        let response = await fetch(url, {
            method: 'POST',
            credentials: 'include', // car api
            body: data
        });

        if (!response.ok) {
            throw new Error(`Erreur HTTP: ${response.status}`);
        }

        var reussite = await response.json();
        console.log(response)
        return reussite;

    } catch (error) {
        console.error('Erreur fetch :', error);
        return 0;
    }
}

async function isConnected(siteUrl) {
    var url = siteUrl + `api/auth/isconnected`;
    // // console.log(url);
    let response = await fetch(url, {
        method: 'get',
        credentials: 'include',
    });
    
    if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
    }
    return parseInt(await response.text());
}

async function getCharacters(siteUrl) {
    var url = siteUrl + `api/Personnages/all`;
    // // console.log(url);
    let response = await fetch(url, {
        method: 'get',
        credentials: 'include',
    });
    
    if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
    }
    return await response.json();
}

async function createCharacter(siteUrl, data) {
    var url = siteUrl + `api/Personnages/create`;
    try {
        let response = await fetch(url, {
            method: 'POST',
            credentials: 'include', 
            body: data
        });

        if (!response.ok) {
            throw new Error(`Erreur HTTP: ${response.status}`);
        }

        var reussite = await response.json();
        console.log(response)
        return reussite;
    } 
    catch (error) {
        console.error('Erreur fetch :', error);
        return 0;
    }
}

async function selectCharacter(siteUrl, id) {
    var url = siteUrl + `api/Personnages/select/` + id;
    // // console.log(url);
    let response
    try {
        response = await fetch(url, {
            method: 'post',
            credentials: 'include',
        });
    }
    catch(error)
    {
        throw new Error(`Erreur HTTP: ${error}`);
    }
    
    if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
    }
    console.log(response);
    return await response.text();
}

async function getActualCharacter(siteUrl) {
    var url = siteUrl + `api/Personnages/actual`;
    // // console.log(url);
    let response = await fetch(url, {
        method: 'get',
        credentials: 'include',
    });
    
    if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
    }
    return await response.json();
}

async function disconnectApi(siteUrl) {
    try {
        var url = siteUrl + `api/auth/disconnect`;

        let response = await fetch(url, {
            method: 'POST',
            credentials: 'include',
        });

        if (!response.ok) {
            throw new Error(`Erreur HTTP: ${response.status}`);
        }

        var reussite = await response.text();
        console.log(response)
        return reussite;

    } catch (error) {
        console.error('Erreur fetch :', error);
        return false;
    }
}

async function moveCharApi(siteUrl, player, characterId) {
    var url = siteUrl + 
    `api/Deplacement/${characterId}/${player.x +1}/${player.y +1}`;

    console.log(url);
    let response = await fetch(url, {
        method: 'get',
        credentials: 'include',
    });
    
    if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
    }
    
    var tuile = await response.json();
    // console.log(tuile);
    return tuile;
}

async function getTileArounCharApi(siteUrl, characterId, y, x) {
    var url = siteUrl + 
    `api/Tuile/${characterId}/${x +1}/${y +1}`;

    console.log(url);
    let response = await fetch(url, {
        method: 'get',
        credentials: 'include',
    });
    
    if (!response.ok) {
        throw new Error(`Erreur HTTP: ${response.status}`);
    }
    
    var tuile = await response.json();
    // console.log(tuile);
    return tuile;
}