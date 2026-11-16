const BASE_URL = `https://localhost:7002/`;

window.onload = async function() {
    let formInscr = document.getElementById("formulaireInsc");

    if (formInscr != null) {
        var p = document.createElement("p");
        formInscr.appendChild(p);

        formInscr.addEventListener("submit", async (e) => {
            e.preventDefault();

            let formData = new FormData(e.target);
            let data = new URLSearchParams(formData);

            var enfin = await register(BASE_URL, data);
            console.error(enfin);
            if(!enfin) {
                p.textContent = "Informations invalides";
            }
            else {
                p.textContent = "Inscription réussie";
                setTimeout(() => {window.location.href = "select-character.html";}, 2000);
            }
        });
    }
    
    
    let formConnect = document.getElementById("formulaireConnect");
    if (formConnect != null) {
        p = document.createElement("p");
        formConnect.appendChild(p);

        formConnect.addEventListener("submit", async (e) => {
            e.preventDefault();

            let formData = new FormData(e.target);
            let data = new URLSearchParams(formData);      

            var enfin = await connect(BASE_URL, data);
            console.error(enfin);
            if(!enfin) {
                p.textContent = "Informations invalides";
            }
            else {
                p.textContent = "Connexion réussie";
                setTimeout(() => {window.location.href = "select-character.html";}, 2000);
            }
        });
    }
}