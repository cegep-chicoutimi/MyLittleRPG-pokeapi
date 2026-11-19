const BASE_URL = `https://localhost:7002/`;

let pError;

window.onload = async () => {
    let result = null;
    try {
        result = await getCharacters(BASE_URL);
    }
    catch {
        window.location.href = "../";
    }

        let ulHtml = document.getElementById("select-char-ul");
        if(result != null)
        {
            result.forEach(res => {
                resLi = document.createElement("li");
                console.log(res);
                resLi.textContent = `${res.id} : ${res.name} de niveau ${res.level}`;
                resLi.onclick = () => clickToSelect(res.id);
                ulHtml.appendChild(resLi);
            });
        }

    let formSelect = document.getElementById("form-create-char");
    if (formSelect != null) {
        pError = document.createElement("p");
        formSelect.appendChild(pError);

        formSelect.addEventListener("submit", async (e) => {
            e.preventDefault();

            let formData = new FormData(e.target);
            let data = new URLSearchParams(formData);      

            var enfin = await createCharacter(BASE_URL, data);
            console.error(enfin);
            if(!enfin) {
                pError.textContent = "Informations invalides";
            }
            else {
                pError.textContent = "Connexion réussie";
                setTimeout(() => {window.location.href = "../";}, 1000);
            }
        });
    }
};


async function clickToSelect(idChar) {
    var result = selectCharacter(BASE_URL, idChar);
    if(result)
        setTimeout(() => {window.location.href = "../";}, 3000);
    else {
        pError = "erreur wsh";
    }
}