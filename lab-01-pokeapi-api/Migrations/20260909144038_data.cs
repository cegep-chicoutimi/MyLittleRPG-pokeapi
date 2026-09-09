using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab_01_pokeapi_api.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Monstre",
                table: "Monstre");

            migrationBuilder.RenameTable(
                name: "Monstre",
                newName: "Monstres");

            migrationBuilder.AddColumn<int>(
                name: "MonsterId",
                table: "Monstres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monstres",
                table: "Monstres",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Monstres",
                columns: new[] { "Id", "DefenseBase", "ExperienceBase", "ForceBase", "MonsterId", "Nom", "PointDeVieBase", "SpriteUrl", "Type1", "Type2" },
                values: new object[,]
                {
                    { 1, 6, 636, 6, 1, "bulbasaur", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", "grass", "poison" },
                    { 2, 7, 810, 7, 2, "ivysaur", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png", "grass", "poison" },
                    { 3, 10, 1050, 10, 3, "venusaur", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png", "grass", "poison" },
                    { 4, 5, 618, 6, 4, "charmander", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png", "fire", "" },
                    { 5, 7, 810, 8, 5, "charmeleon", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png", "fire", "" },
                    { 6, 9, 1068, 10, 6, "charizard", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png", "fire", "flying" },
                    { 7, 8, 628, 6, 7, "squirtle", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png", "water", "" },
                    { 8, 10, 810, 7, 8, "wartortle", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/8.png", "water", "" },
                    { 9, 12, 1060, 10, 9, "blastoise", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png", "water", "" },
                    { 10, 4, 390, 5, 10, "caterpie", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png", "bug", "" },
                    { 11, 6, 410, 5, 11, "metapod", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/11.png", "bug", "" },
                    { 12, 6, 790, 5, 12, "butterfree", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/12.png", "bug", "flying" },
                    { 13, 3, 390, 5, 13, "weedle", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/13.png", "bug", "poison" },
                    { 14, 6, 410, 5, 14, "kakuna", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/14.png", "bug", "poison" },
                    { 15, 5, 790, 11, 15, "beedrill", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/15.png", "bug", "poison" },
                    { 16, 5, 502, 5, 16, "pidgey", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/16.png", "normal", "flying" },
                    { 17, 6, 698, 7, 17, "pidgeotto", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/17.png", "normal", "flying" },
                    { 18, 9, 958, 10, 18, "pidgeot", 27, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/18.png", "normal", "flying" },
                    { 19, 4, 506, 7, 19, "rattata", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/19.png", "normal", "" },
                    { 20, 7, 826, 10, 20, "raticate", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/20.png", "normal", "" },
                    { 21, 3, 524, 7, 21, "spearow", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/21.png", "normal", "flying" },
                    { 22, 8, 884, 11, 22, "fearow", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/22.png", "normal", "flying" },
                    { 23, 5, 576, 7, 23, "ekans", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/23.png", "poison", "" },
                    { 24, 8, 896, 11, 24, "arbok", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/24.png", "poison", "" },
                    { 25, 5, 640, 6, 25, "pikachu", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png", "electric", "" },
                    { 26, 6, 970, 11, 26, "raichu", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/26.png", "electric", "" },
                    { 27, 10, 600, 9, 27, "sandshrew", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/27.png", "ground", "" },
                    { 28, 13, 900, 12, 28, "sandslash", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/28.png", "ground", "" },
                    { 29, 6, 550, 5, 29, "nidoran-f", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/29.png", "poison", "" },
                    { 30, 8, 730, 7, 30, "nidorina", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/30.png", "poison", "" },
                    { 31, 10, 1010, 11, 31, "nidoqueen", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/31.png", "poison", "ground" },
                    { 32, 5, 546, 7, 32, "nidoran-m", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/32.png", "poison", "" },
                    { 33, 7, 730, 9, 33, "nidorino", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/33.png", "poison", "" },
                    { 34, 9, 1010, 12, 34, "nidoking", 27, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/34.png", "poison", "ground" },
                    { 35, 6, 646, 5, 35, "clefairy", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png", "fairy", "" },
                    { 36, 9, 966, 8, 36, "clefable", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/36.png", "fairy", "" },
                    { 37, 5, 598, 5, 37, "vulpix", 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/37.png", "fire", "" },
                    { 38, 9, 1010, 9, 38, "ninetales", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/38.png", "fire", "" },
                    { 39, 2, 540, 5, 39, "jigglypuff", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/39.png", "normal", "fairy" },
                    { 40, 5, 870, 8, 40, "wigglytuff", 46, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/40.png", "normal", "fairy" },
                    { 41, 4, 490, 5, 41, "zubat", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/41.png", "poison", "flying" },
                    { 42, 8, 910, 10, 42, "golbat", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/42.png", "poison", "flying" },
                    { 43, 6, 640, 6, 43, "oddish", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/43.png", "grass", "poison" },
                    { 44, 8, 790, 8, 44, "gloom", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/44.png", "grass", "poison" },
                    { 45, 10, 980, 10, 45, "vileplume", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/45.png", "grass", "poison" },
                    { 46, 6, 570, 8, 46, "paras", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/46.png", "bug", "grass" },
                    { 47, 10, 810, 11, 47, "parasect", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/47.png", "bug", "grass" },
                    { 48, 6, 610, 6, 48, "venonat", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/48.png", "bug", "poison" },
                    { 49, 7, 900, 8, 49, "venomoth", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/49.png", "bug", "poison" },
                    { 50, 3, 530, 6, 50, "diglett", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/50.png", "ground", "" },
                    { 51, 6, 850, 12, 51, "dugtrio", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/51.png", "ground", "" },
                    { 52, 4, 580, 5, 52, "meowth", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/52.png", "normal", "" },
                    { 53, 7, 880, 8, 53, "persian", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/53.png", "normal", "" },
                    { 54, 6, 640, 6, 54, "psyduck", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/54.png", "water", "" },
                    { 55, 9, 1000, 10, 55, "golduck", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/55.png", "water", "" },
                    { 56, 4, 610, 10, 56, "mankey", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/56.png", "fighting", "" },
                    { 57, 7, 910, 13, 57, "primeape", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/57.png", "fighting", "" },
                    { 58, 5, 700, 8, 58, "growlithe", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/58.png", "fire", "" },
                    { 59, 10, 1110, 13, 59, "arcanine", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/59.png", "fire", "" },
                    { 60, 5, 600, 6, 60, "poliwag", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/60.png", "water", "" },
                    { 61, 8, 770, 8, 61, "poliwhirl", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/61.png", "water", "" },
                    { 62, 11, 1020, 11, 62, "poliwrath", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/62.png", "water", "fighting" },
                    { 63, 1, 620, 5, 63, "abra", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/63.png", "psychic", "" },
                    { 64, 3, 800, 5, 64, "kadabra", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/64.png", "psychic", "" },
                    { 65, 5, 1000, 6, 65, "alakazam", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/65.png", "psychic", "" },
                    { 66, 6, 610, 10, 66, "machop", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/66.png", "fighting", "" },
                    { 67, 8, 810, 12, 67, "machoke", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/67.png", "fighting", "" },
                    { 68, 10, 1010, 16, 68, "machamp", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/68.png", "fighting", "" },
                    { 69, 4, 600, 9, 69, "bellsprout", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/69.png", "grass", "poison" },
                    { 70, 6, 780, 11, 70, "weepinbell", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/70.png", "grass", "poison" },
                    { 71, 8, 980, 13, 71, "victreebel", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/71.png", "grass", "poison" },
                    { 72, 4, 670, 5, 72, "tentacool", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/72.png", "water", "poison" },
                    { 73, 8, 1030, 8, 73, "tentacruel", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/73.png", "water", "poison" },
                    { 74, 12, 600, 10, 74, "geodude", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/74.png", "rock", "ground" },
                    { 75, 14, 780, 11, 75, "graveler", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/75.png", "rock", "ground" },
                    { 76, 16, 990, 15, 76, "golem", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/76.png", "rock", "ground" },
                    { 77, 6, 820, 10, 77, "ponyta", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/77.png", "fire", "" },
                    { 78, 8, 1000, 12, 78, "rapidash", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/78.png", "fire", "" },
                    { 79, 8, 630, 8, 79, "slowpoke", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/79.png", "water", "psychic" },
                    { 80, 13, 980, 9, 80, "slowbro", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/80.png", "water", "psychic" },
                    { 81, 8, 650, 5, 81, "magnemite", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/81.png", "electric", "steel" },
                    { 82, 11, 930, 7, 82, "magneton", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/82.png", "electric", "steel" },
                    { 83, 6, 754, 11, 83, "farfetchd", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/83.png", "normal", "flying" },
                    { 84, 5, 620, 10, 84, "doduo", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/84.png", "normal", "flying" },
                    { 85, 8, 940, 13, 85, "dodrio", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/85.png", "normal", "flying" },
                    { 86, 6, 650, 5, 86, "seel", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/86.png", "water", "" },
                    { 87, 10, 950, 8, 87, "dewgong", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/87.png", "water", "ice" },
                    { 88, 6, 650, 10, 88, "grimer", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/88.png", "poison", "" },
                    { 89, 9, 1000, 13, 89, "muk", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/89.png", "poison", "" },
                    { 90, 12, 610, 8, 90, "shellder", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/90.png", "water", "" },
                    { 91, 22, 1050, 11, 91, "cloyster", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/91.png", "water", "ice" },
                    { 92, 3, 620, 5, 92, "gastly", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/92.png", "ghost", "poison" },
                    { 93, 5, 810, 6, 93, "haunter", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/93.png", "ghost", "poison" },
                    { 94, 7, 1000, 8, 94, "gengar", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/94.png", "ghost", "poison" },
                    { 95, 20, 770, 5, 95, "onix", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/95.png", "rock", "ground" },
                    { 96, 5, 656, 6, 96, "drowzee", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/96.png", "psychic", "" },
                    { 97, 8, 966, 9, 97, "hypno", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/97.png", "psychic", "" },
                    { 98, 11, 650, 13, 98, "krabby", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/98.png", "water", "" },
                    { 99, 14, 950, 16, 99, "kingler", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/99.png", "water", "" },
                    { 100, 6, 660, 5, 100, "voltorb", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/100.png", "electric", "" },
                    { 101, 8, 980, 6, 101, "electrode", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/101.png", "electric", "" },
                    { 102, 10, 650, 5, 102, "exeggcute", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/102.png", "grass", "psychic" },
                    { 103, 10, 1060, 11, 103, "exeggutor", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/103.png", "grass", "psychic" },
                    { 104, 11, 640, 6, 104, "cubone", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/104.png", "ground", "" },
                    { 105, 13, 850, 10, 105, "marowak", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/105.png", "ground", "" },
                    { 106, 6, 910, 15, 106, "hitmonlee", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/106.png", "fighting", "" },
                    { 107, 9, 910, 13, 107, "hitmonchan", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/107.png", "fighting", "" },
                    { 108, 9, 770, 6, 108, "lickitung", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/108.png", "normal", "" },
                    { 109, 11, 680, 8, 109, "koffing", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/109.png", "poison", "" },
                    { 110, 15, 980, 11, 110, "weezing", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/110.png", "poison", "" },
                    { 111, 11, 690, 10, 111, "rhyhorn", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/111.png", "ground", "rock" },
                    { 112, 15, 970, 16, 112, "rhydon", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/112.png", "ground", "rock" },
                    { 113, 0, 900, 5, 113, "chansey", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/113.png", "normal", "" },
                    { 114, 14, 870, 6, 114, "tangela", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/114.png", "grass", "" },
                    { 115, 10, 980, 11, 115, "kangaskhan", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/115.png", "normal", "" },
                    { 116, 8, 590, 5, 116, "horsea", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/116.png", "water", "" },
                    { 117, 11, 880, 8, 117, "seadra", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/117.png", "water", "" },
                    { 118, 7, 640, 8, 118, "goldeen", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/118.png", "water", "" },
                    { 119, 8, 900, 11, 119, "seaking", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/119.png", "water", "" },
                    { 120, 6, 680, 5, 120, "staryu", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/120.png", "water", "" },
                    { 121, 10, 1040, 9, 121, "starmie", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/121.png", "water", "psychic" },
                    { 122, 8, 920, 5, 122, "mr-mime", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/122.png", "psychic", "fairy" },
                    { 123, 10, 1000, 13, 123, "scyther", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/123.png", "bug", "flying" },
                    { 124, 4, 910, 6, 124, "jynx", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/124.png", "ice", "psychic" },
                    { 125, 7, 980, 10, 125, "electabuzz", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/125.png", "electric", "" },
                    { 126, 7, 990, 11, 126, "magmar", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/126.png", "fire", "" },
                    { 127, 12, 1000, 15, 127, "pinsir", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/127.png", "bug", "" },
                    { 128, 11, 980, 12, 128, "tauros", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/128.png", "normal", "" },
                    { 129, 6, 400, 5, 129, "magikarp", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/129.png", "water", "" },
                    { 130, 9, 1080, 15, 130, "gyarados", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/130.png", "water", "flying" },
                    { 131, 10, 1070, 10, 131, "lapras", 43, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/131.png", "water", "ice" },
                    { 132, 6, 576, 6, 132, "ditto", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png", "normal", "" },
                    { 133, 6, 650, 6, 133, "eevee", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png", "normal", "" },
                    { 134, 7, 1050, 8, 134, "vaporeon", 43, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/134.png", "water", "" },
                    { 135, 7, 1050, 8, 135, "jolteon", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/135.png", "electric", "" },
                    { 136, 7, 1050, 16, 136, "flareon", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/136.png", "fire", "" },
                    { 137, 8, 790, 7, 137, "porygon", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/137.png", "normal", "" },
                    { 138, 12, 710, 5, 138, "omanyte", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/138.png", "rock", "water" },
                    { 139, 15, 990, 7, 139, "omastar", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/139.png", "rock", "water" },
                    { 140, 11, 710, 10, 140, "kabuto", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/140.png", "rock", "water" },
                    { 141, 13, 990, 14, 141, "kabutops", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/141.png", "rock", "water" },
                    { 142, 8, 1030, 13, 142, "aerodactyl", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/142.png", "rock", "flying" },
                    { 143, 8, 1080, 13, 143, "snorlax", 53, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/143.png", "normal", "" },
                    { 144, 12, 1160, 10, 144, "articuno", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/144.png", "ice", "flying" },
                    { 145, 10, 1160, 11, 145, "zapdos", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/145.png", "electric", "flying" },
                    { 146, 11, 1160, 12, 146, "moltres", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/146.png", "fire", "flying" },
                    { 147, 5, 600, 8, 147, "dratini", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/147.png", "dragon", "" },
                    { 148, 8, 840, 10, 148, "dragonair", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/148.png", "dragon", "" },
                    { 149, 11, 1200, 16, 149, "dragonite", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/149.png", "dragon", "flying" },
                    { 150, 11, 1360, 13, 150, "mewtwo", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/150.png", "psychic", "" },
                    { 151, 12, 1200, 12, 151, "mew", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/151.png", "psychic", "" },
                    { 152, 8, 636, 6, 152, "chikorita", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/152.png", "grass", "" },
                    { 153, 10, 810, 7, 153, "bayleef", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/153.png", "grass", "" },
                    { 154, 12, 1050, 10, 154, "meganium", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/154.png", "grass", "" },
                    { 155, 5, 618, 6, 155, "cyndaquil", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/155.png", "fire", "" },
                    { 156, 7, 810, 8, 156, "quilava", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/156.png", "fire", "" },
                    { 157, 9, 1068, 10, 157, "typhlosion", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/157.png", "fire", "" },
                    { 158, 8, 628, 8, 158, "totodile", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/158.png", "water", "" },
                    { 159, 10, 810, 10, 159, "croconaw", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/159.png", "water", "" },
                    { 160, 12, 1060, 13, 160, "feraligatr", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/160.png", "water", "" },
                    { 161, 4, 430, 5, 161, "sentret", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/161.png", "normal", "" },
                    { 162, 8, 830, 9, 162, "furret", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/162.png", "normal", "" },
                    { 163, 3, 524, 5, 163, "hoothoot", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/163.png", "normal", "flying" },
                    { 164, 6, 904, 6, 164, "noctowl", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/164.png", "normal", "flying" },
                    { 165, 3, 530, 5, 165, "ledyba", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/165.png", "bug", "flying" },
                    { 166, 6, 780, 5, 166, "ledian", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/166.png", "bug", "flying" },
                    { 167, 5, 500, 7, 167, "spinarak", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/167.png", "bug", "poison" },
                    { 168, 8, 800, 11, 168, "ariados", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/168.png", "bug", "poison" },
                    { 169, 10, 1070, 11, 169, "crobat", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/169.png", "poison", "flying" },
                    { 170, 4, 660, 5, 170, "chinchou", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/170.png", "water", "electric" },
                    { 171, 7, 920, 7, 171, "lanturn", 41, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/171.png", "water", "electric" },
                    { 172, 1, 410, 5, 172, "pichu", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/172.png", "electric", "" },
                    { 173, 3, 436, 5, 173, "cleffa", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/173.png", "fairy", "" },
                    { 174, 1, 420, 5, 174, "igglybuff", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/174.png", "normal", "fairy" },
                    { 175, 8, 490, 5, 175, "togepi", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/175.png", "fairy", "" },
                    { 176, 10, 810, 5, 176, "togetic", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/176.png", "fairy", "flying" },
                    { 177, 5, 640, 6, 177, "natu", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/177.png", "psychic", "flying" },
                    { 178, 8, 940, 9, 178, "xatu", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/178.png", "psychic", "flying" },
                    { 179, 5, 560, 5, 179, "mareep", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/179.png", "electric", "" },
                    { 180, 6, 730, 6, 180, "flaaffy", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/180.png", "electric", "" },
                    { 181, 10, 1020, 9, 181, "ampharos", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/181.png", "electric", "" },
                    { 182, 11, 980, 10, 182, "bellossom", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/182.png", "grass", "" },
                    { 183, 6, 500, 5, 183, "marill", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/183.png", "water", "fairy" },
                    { 184, 10, 840, 6, 184, "azumarill", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/184.png", "water", "fairy" },
                    { 185, 14, 820, 12, 185, "sudowoodo", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/185.png", "rock", "" },
                    { 186, 9, 1000, 9, 186, "politoed", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/186.png", "water", "" },
                    { 187, 5, 500, 5, 187, "hoppip", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/187.png", "grass", "flying" },
                    { 188, 6, 680, 5, 188, "skiploom", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/188.png", "grass", "flying" },
                    { 189, 8, 920, 6, 189, "jumpluff", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/189.png", "grass", "flying" },
                    { 190, 6, 720, 8, 190, "aipom", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/190.png", "normal", "" },
                    { 191, 3, 360, 5, 191, "sunkern", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/191.png", "grass", "" },
                    { 192, 6, 850, 9, 192, "sunflora", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/192.png", "grass", "" },
                    { 193, 5, 780, 8, 193, "yanma", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/193.png", "bug", "flying" },
                    { 194, 5, 420, 5, 194, "wooper", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/194.png", "water", "ground" },
                    { 195, 10, 860, 10, 195, "quagsire", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/195.png", "water", "ground" },
                    { 196, 7, 1050, 8, 196, "espeon", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/196.png", "psychic", "" },
                    { 197, 13, 1050, 8, 197, "umbreon", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/197.png", "dark", "" },
                    { 198, 5, 810, 10, 198, "murkrow", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/198.png", "dark", "flying" },
                    { 199, 10, 980, 9, 199, "slowking", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/199.png", "water", "psychic" },
                    { 200, 7, 870, 7, 200, "misdreavus", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/200.png", "ghost", "" },
                    { 201, 6, 672, 9, 201, "unown", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/201.png", "psychic", "" },
                    { 202, 7, 810, 5, 202, "wobbuffet", 63, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/202.png", "psychic", "" },
                    { 203, 8, 910, 10, 203, "girafarig", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/203.png", "normal", "psychic" },
                    { 204, 11, 580, 8, 204, "pineco", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/204.png", "bug", "" },
                    { 205, 17, 930, 11, 205, "forretress", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/205.png", "bug", "steel" },
                    { 206, 8, 830, 8, 206, "dunsparce", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/206.png", "normal", "" },
                    { 207, 13, 860, 9, 207, "gligar", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/207.png", "ground", "flying" },
                    { 208, 25, 1020, 10, 208, "steelix", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/208.png", "steel", "ground" },
                    { 209, 6, 600, 10, 209, "snubbull", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/209.png", "fairy", "" },
                    { 210, 9, 900, 15, 210, "granbull", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/210.png", "fairy", "" },
                    { 211, 10, 880, 11, 211, "qwilfish", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/211.png", "water", "poison" },
                    { 212, 12, 1000, 16, 212, "scizor", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/212.png", "bug", "steel" },
                    { 213, 28, 1010, 5, 213, "shuckle", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/213.png", "bug", "rock" },
                    { 214, 9, 1000, 15, 214, "heracross", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/214.png", "bug", "fighting" },
                    { 215, 6, 860, 11, 215, "sneasel", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/215.png", "dark", "ice" },
                    { 216, 6, 660, 10, 216, "teddiursa", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/216.png", "normal", "" },
                    { 217, 9, 1000, 16, 217, "ursaring", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/217.png", "normal", "" },
                    { 218, 5, 500, 5, 218, "slugma", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/218.png", "fire", "" },
                    { 219, 15, 860, 6, 219, "magcargo", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/219.png", "fire", "rock" },
                    { 220, 5, 500, 6, 220, "swinub", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/220.png", "ice", "ground" },
                    { 221, 10, 900, 12, 221, "piloswine", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/221.png", "ice", "ground" },
                    { 222, 11, 820, 6, 222, "corsola", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/222.png", "water", "rock" },
                    { 223, 4, 600, 8, 223, "remoraid", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/223.png", "water", "" },
                    { 224, 9, 960, 13, 224, "octillery", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/224.png", "water", "" },
                    { 225, 5, 660, 6, 225, "delibird", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/225.png", "ice", "flying" },
                    { 226, 8, 970, 5, 226, "mantine", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/226.png", "water", "flying" },
                    { 227, 17, 930, 10, 227, "skarmory", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/227.png", "steel", "flying" },
                    { 228, 3, 660, 7, 228, "houndour", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/228.png", "dark", "fire" },
                    { 229, 6, 1000, 11, 229, "houndoom", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/229.png", "dark", "fire" },
                    { 230, 11, 1080, 11, 230, "kingdra", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/230.png", "water", "dragon" },
                    { 231, 7, 660, 7, 231, "phanpy", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/231.png", "ground", "" },
                    { 232, 15, 1000, 15, 232, "donphan", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/232.png", "ground", "" },
                    { 233, 11, 1030, 10, 233, "porygon2", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/233.png", "normal", "" },
                    { 234, 7, 930, 11, 234, "stantler", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/234.png", "normal", "" },
                    { 235, 4, 500, 5, 235, "smeargle", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/235.png", "normal", "" },
                    { 236, 4, 420, 5, 236, "tyrogue", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/236.png", "fighting", "" },
                    { 237, 11, 910, 11, 237, "hitmontop", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/237.png", "fighting", "" },
                    { 238, 1, 610, 5, 238, "smoochum", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/238.png", "ice", "psychic" },
                    { 239, 4, 720, 7, 239, "elekid", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/239.png", "electric", "" },
                    { 240, 4, 730, 9, 240, "magby", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/240.png", "fire", "" },
                    { 241, 13, 980, 10, 241, "miltank", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/241.png", "normal", "" },
                    { 242, 1, 1080, 5, 242, "blissey", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/242.png", "normal", "" },
                    { 243, 9, 1160, 10, 243, "raikou", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/243.png", "electric", "" },
                    { 244, 10, 1160, 14, 244, "entei", 38, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/244.png", "fire", "" },
                    { 245, 14, 1160, 9, 245, "suicune", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/245.png", "water", "" },
                    { 246, 6, 600, 8, 246, "larvitar", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/246.png", "rock", "ground" },
                    { 247, 8, 820, 10, 247, "pupitar", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/247.png", "rock", "ground" },
                    { 248, 13, 1200, 16, 248, "tyranitar", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/248.png", "rock", "dark" },
                    { 249, 16, 1360, 11, 249, "lugia", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/249.png", "psychic", "flying" },
                    { 250, 11, 1360, 16, 250, "ho-oh", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/250.png", "fire", "flying" },
                    { 251, 12, 1200, 12, 251, "celebi", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/251.png", "psychic", "grass" },
                    { 252, 4, 620, 5, 252, "treecko", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/252.png", "grass", "" },
                    { 253, 5, 810, 8, 253, "grovyle", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/253.png", "grass", "" },
                    { 254, 8, 1060, 10, 254, "sceptile", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/254.png", "grass", "" },
                    { 255, 5, 620, 7, 255, "torchic", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/255.png", "fire", "" },
                    { 256, 7, 810, 10, 256, "combusken", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/256.png", "fire", "fighting" },
                    { 257, 8, 1060, 15, 257, "blaziken", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/257.png", "fire", "fighting" },
                    { 258, 6, 620, 8, 258, "mudkip", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/258.png", "water", "" },
                    { 259, 8, 810, 10, 259, "marshtomp", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/259.png", "water", "ground" },
                    { 260, 11, 1070, 13, 260, "swampert", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/260.png", "water", "ground" },
                    { 261, 4, 440, 6, 261, "poochyena", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/261.png", "dark", "" },
                    { 262, 8, 840, 11, 262, "mightyena", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/262.png", "dark", "" },
                    { 263, 5, 480, 5, 263, "zigzagoon", 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/263.png", "normal", "" },
                    { 264, 7, 840, 8, 264, "linoone", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/264.png", "normal", "" },
                    { 265, 4, 390, 5, 265, "wurmple", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/265.png", "bug", "" },
                    { 266, 6, 410, 5, 266, "silcoon", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/266.png", "bug", "" },
                    { 267, 6, 790, 8, 267, "beautifly", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/267.png", "bug", "flying" },
                    { 268, 6, 410, 5, 268, "cascoon", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/268.png", "bug", "" },
                    { 269, 8, 770, 6, 269, "dustox", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/269.png", "bug", "poison" },
                    { 270, 3, 440, 5, 270, "lotad", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/270.png", "water", "grass" },
                    { 271, 6, 680, 6, 271, "lombre", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/271.png", "water", "grass" },
                    { 272, 8, 960, 8, 272, "ludicolo", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/272.png", "water", "grass" },
                    { 273, 6, 440, 5, 273, "seedot", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/273.png", "grass", "" },
                    { 274, 5, 680, 8, 274, "nuzleaf", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/274.png", "grass", "dark" },
                    { 275, 7, 960, 12, 275, "shiftry", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/275.png", "grass", "dark" },
                    { 276, 3, 540, 6, 276, "taillow", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/276.png", "normal", "flying" },
                    { 277, 7, 910, 10, 277, "swellow", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/277.png", "normal", "flying" },
                    { 278, 3, 540, 5, 278, "wingull", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/278.png", "water", "flying" },
                    { 279, 12, 880, 6, 279, "pelipper", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/279.png", "water", "flying" },
                    { 280, 3, 396, 5, 280, "ralts", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/280.png", "psychic", "fairy" },
                    { 281, 4, 556, 5, 281, "kirlia", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/281.png", "psychic", "fairy" },
                    { 282, 8, 1036, 8, 282, "gardevoir", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/282.png", "psychic", "fairy" },
                    { 283, 4, 538, 5, 283, "surskit", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/283.png", "bug", "water" },
                    { 284, 7, 908, 7, 284, "masquerain", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/284.png", "bug", "flying" },
                    { 285, 7, 590, 5, 285, "shroomish", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/285.png", "grass", "" },
                    { 286, 10, 920, 16, 286, "breloom", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/286.png", "grass", "fighting" },
                    { 287, 7, 560, 7, 287, "slakoth", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/287.png", "normal", "" },
                    { 288, 10, 880, 10, 288, "vigoroth", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/288.png", "normal", "" },
                    { 289, 12, 1340, 20, 289, "slaking", 50, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/289.png", "normal", "" },
                    { 290, 11, 532, 5, 290, "nincada", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/290.png", "bug", "ground" },
                    { 291, 5, 912, 11, 291, "ninjask", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/291.png", "bug", "flying" },
                    { 292, 5, 472, 11, 292, "shedinja", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/292.png", "bug", "ghost" },
                    { 293, 2, 480, 6, 293, "whismur", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/293.png", "normal", "" },
                    { 294, 5, 720, 8, 294, "loudred", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/294.png", "normal", "" },
                    { 295, 7, 980, 11, 295, "exploud", 34, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/295.png", "normal", "" },
                    { 296, 3, 474, 7, 296, "makuhita", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/296.png", "fighting", "" },
                    { 297, 7, 948, 15, 297, "hariyama", 48, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/297.png", "fighting", "" },
                    { 298, 5, 380, 5, 298, "azurill", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/298.png", "normal", "fairy" },
                    { 299, 16, 750, 5, 299, "nosepass", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/299.png", "rock", "" },
                    { 300, 5, 520, 5, 300, "skitty", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/300.png", "normal", "" },
                    { 301, 8, 800, 8, 301, "delcatty", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/301.png", "normal", "" },
                    { 302, 9, 760, 9, 302, "sableye", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/302.png", "dark", "ghost" },
                    { 303, 10, 760, 10, 303, "mawile", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/303.png", "steel", "fairy" },
                    { 304, 12, 660, 8, 304, "aron", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/304.png", "steel", "rock" },
                    { 305, 17, 860, 11, 305, "lairon", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/305.png", "steel", "rock" },
                    { 306, 22, 1060, 13, 306, "aggron", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/306.png", "steel", "rock" },
                    { 307, 6, 560, 5, 307, "meditite", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/307.png", "fighting", "psychic" },
                    { 308, 9, 820, 7, 308, "medicham", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/308.png", "fighting", "psychic" },
                    { 309, 5, 590, 5, 309, "electrike", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/309.png", "electric", "" },
                    { 310, 7, 950, 9, 310, "manectric", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/310.png", "electric", "" },
                    { 311, 5, 810, 6, 311, "plusle", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/311.png", "electric", "" },
                    { 312, 6, 810, 5, 312, "minun", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/312.png", "electric", "" },
                    { 313, 9, 860, 9, 313, "volbeat", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/313.png", "bug", "" },
                    { 314, 9, 860, 5, 314, "illumise", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/314.png", "bug", "" },
                    { 315, 5, 800, 7, 315, "roselia", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/315.png", "grass", "poison" },
                    { 316, 6, 604, 5, 316, "gulpin", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/316.png", "poison", "" },
                    { 317, 10, 934, 9, 317, "swalot", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/317.png", "poison", "" },
                    { 318, 2, 610, 11, 318, "carvanha", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/318.png", "water", "dark" },
                    { 319, 5, 920, 15, 319, "sharpedo", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/319.png", "water", "dark" },
                    { 320, 4, 800, 8, 320, "wailmer", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/320.png", "water", "" },
                    { 321, 5, 1000, 11, 321, "wailord", 56, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/321.png", "water", "" },
                    { 322, 5, 610, 7, 322, "numel", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/322.png", "fire", "ground" },
                    { 323, 8, 920, 12, 323, "camerupt", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/323.png", "fire", "ground" },
                    { 324, 17, 940, 10, 324, "torkoal", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/324.png", "fire", "" },
                    { 325, 4, 660, 5, 325, "spoink", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/325.png", "psychic", "" },
                    { 326, 8, 940, 5, 326, "grumpig", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/326.png", "psychic", "" },
                    { 327, 7, 720, 7, 327, "spinda", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/327.png", "normal", "" },
                    { 328, 5, 580, 12, 328, "trapinch", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/328.png", "ground", "" },
                    { 329, 6, 680, 8, 329, "vibrava", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/329.png", "ground", "dragon" },
                    { 330, 10, 1040, 12, 330, "flygon", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/330.png", "ground", "dragon" },
                    { 331, 5, 670, 10, 331, "cacnea", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/331.png", "grass", "" },
                    { 332, 7, 950, 14, 332, "cacturne", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/332.png", "grass", "dark" },
                    { 333, 7, 620, 5, 333, "swablu", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/333.png", "normal", "flying" },
                    { 334, 11, 980, 8, 334, "altaria", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/334.png", "dragon", "flying" },
                    { 335, 7, 916, 14, 335, "zangoose", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/335.png", "normal", "" },
                    { 336, 7, 916, 12, 336, "seviper", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/336.png", "poison", "" },
                    { 337, 8, 920, 6, 337, "lunatone", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/337.png", "rock", "psychic" },
                    { 338, 10, 920, 11, 338, "solrock", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/338.png", "rock", "psychic" },
                    { 339, 5, 576, 6, 339, "barboach", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/339.png", "water", "ground" },
                    { 340, 9, 936, 9, 340, "whiscash", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/340.png", "water", "ground" },
                    { 341, 8, 616, 10, 341, "corphish", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/341.png", "water", "" },
                    { 342, 10, 936, 15, 342, "crawdaunt", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/342.png", "water", "dark" },
                    { 343, 6, 600, 5, 343, "baltoy", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/343.png", "ground", "psychic" },
                    { 344, 13, 1000, 8, 344, "claydol", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/344.png", "ground", "psychic" },
                    { 345, 9, 710, 5, 345, "lileep", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/345.png", "rock", "grass" },
                    { 346, 12, 990, 10, 346, "cradily", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/346.png", "rock", "grass" },
                    { 347, 6, 710, 11, 347, "anorith", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/347.png", "rock", "bug" },
                    { 348, 12, 990, 15, 348, "armaldo", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/348.png", "rock", "bug" },
                    { 349, 2, 400, 5, 349, "feebas", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/349.png", "water", "" },
                    { 350, 9, 1080, 7, 350, "milotic", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/350.png", "water", "" },
                    { 351, 8, 840, 8, 351, "castform", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/351.png", "normal", "" },
                    { 352, 8, 880, 11, 352, "kecleon", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/352.png", "normal", "" },
                    { 353, 4, 590, 9, 353, "shuppet", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/353.png", "ghost", "" },
                    { 354, 8, 910, 14, 354, "banette", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/354.png", "ghost", "" },
                    { 355, 11, 590, 5, 355, "duskull", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/355.png", "ghost", "" },
                    { 356, 16, 910, 8, 356, "dusclops", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/356.png", "ghost", "" },
                    { 357, 10, 920, 8, 357, "tropius", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/357.png", "grass", "flying" },
                    { 358, 10, 910, 6, 358, "chimecho", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/358.png", "psychic", "" },
                    { 359, 7, 930, 16, 359, "absol", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/359.png", "dark", "" },
                    { 360, 6, 520, 5, 360, "wynaut", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/360.png", "psychic", "" },
                    { 361, 6, 600, 6, 361, "snorunt", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/361.png", "ice", "" },
                    { 362, 10, 960, 10, 362, "glalie", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/362.png", "ice", "" },
                    { 363, 6, 580, 5, 363, "spheal", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/363.png", "ice", "water" },
                    { 364, 8, 820, 7, 364, "sealeo", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/364.png", "ice", "water" },
                    { 365, 11, 1060, 10, 365, "walrein", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/365.png", "ice", "water" },
                    { 366, 10, 690, 8, 366, "clamperl", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/366.png", "water", "" },
                    { 367, 13, 970, 13, 367, "huntail", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/367.png", "water", "" },
                    { 368, 13, 970, 10, 368, "gorebyss", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/368.png", "water", "" },
                    { 369, 16, 970, 11, 369, "relicanth", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/369.png", "water", "rock" },
                    { 370, 6, 660, 5, 370, "luvdisc", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/370.png", "water", "" },
                    { 371, 7, 600, 9, 371, "bagon", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/371.png", "dragon", "" },
                    { 372, 12, 840, 11, 372, "shelgon", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/372.png", "dragon", "" },
                    { 373, 10, 1200, 16, 373, "salamence", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/373.png", "dragon", "flying" },
                    { 374, 10, 600, 6, 374, "beldum", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/374.png", "steel", "psychic" },
                    { 375, 12, 840, 9, 375, "metang", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/375.png", "steel", "psychic" },
                    { 376, 16, 1200, 16, 376, "metagross", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/376.png", "steel", "psychic" },
                    { 377, 25, 1160, 12, 377, "regirock", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/377.png", "rock", "" },
                    { 378, 12, 1160, 6, 378, "regice", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/378.png", "ice", "" },
                    { 379, 18, 1160, 9, 379, "registeel", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/379.png", "steel", "" },
                    { 380, 11, 1200, 10, 380, "latias", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/380.png", "dragon", "psychic" },
                    { 381, 10, 1200, 11, 381, "latios", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/381.png", "dragon", "psychic" },
                    { 382, 11, 1340, 12, 382, "kyogre", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/382.png", "water", "" },
                    { 383, 17, 1340, 18, 383, "groudon", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/383.png", "ground", "" },
                    { 384, 11, 1360, 18, 384, "rayquaza", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/384.png", "dragon", "flying" },
                    { 385, 12, 1200, 12, 385, "jirachi", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/385.png", "steel", "psychic" },
                    { 386, 6, 1200, 18, 386, "deoxys-normal", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/386.png", "psychic", "" },
                    { 387, 8, 636, 8, 387, "turtwig", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/387.png", "grass", "" },
                    { 388, 10, 810, 11, 388, "grotle", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/388.png", "grass", "" },
                    { 389, 13, 1050, 13, 389, "torterra", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/389.png", "grass", "ground" },
                    { 390, 5, 618, 7, 390, "chimchar", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/390.png", "fire", "" },
                    { 391, 6, 810, 9, 391, "monferno", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/391.png", "fire", "fighting" },
                    { 392, 8, 1068, 13, 392, "infernape", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/392.png", "fire", "fighting" },
                    { 393, 6, 628, 6, 393, "piplup", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/393.png", "water", "" },
                    { 394, 8, 810, 8, 394, "prinplup", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/394.png", "water", "" },
                    { 395, 11, 1060, 10, 395, "empoleon", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/395.png", "water", "steel" },
                    { 396, 3, 490, 6, 396, "starly", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/396.png", "normal", "flying" },
                    { 397, 6, 680, 9, 397, "staravia", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/397.png", "normal", "flying" },
                    { 398, 8, 970, 15, 398, "staraptor", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/398.png", "normal", "flying" },
                    { 399, 5, 500, 5, 399, "bidoof", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/399.png", "normal", "" },
                    { 400, 7, 820, 10, 400, "bibarel", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/400.png", "normal", "water" },
                    { 401, 5, 388, 5, 401, "kricketot", 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/401.png", "bug", "" },
                    { 402, 6, 768, 10, 402, "kricketune", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/402.png", "bug", "" },
                    { 403, 4, 526, 8, 403, "shinx", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/403.png", "electric", "" },
                    { 404, 6, 726, 10, 404, "luxio", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/404.png", "electric", "" },
                    { 405, 9, 1046, 15, 405, "luxray", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/405.png", "electric", "" },
                    { 406, 4, 560, 5, 406, "budew", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/406.png", "grass", "poison" },
                    { 407, 8, 1030, 8, 407, "roserade", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/407.png", "grass", "poison" },
                    { 408, 5, 700, 15, 408, "cranidos", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/408.png", "rock", "" },
                    { 409, 7, 990, 20, 409, "rampardos", 32, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/409.png", "rock", "" },
                    { 410, 14, 700, 5, 410, "shieldon", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/410.png", "rock", "steel" },
                    { 411, 21, 990, 6, 411, "bastiodon", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/411.png", "rock", "steel" },
                    { 412, 5, 448, 5, 412, "burmy", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/412.png", "bug", "" },
                    { 413, 10, 848, 7, 413, "wormadam-plant", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/413.png", "bug", "grass" },
                    { 414, 6, 848, 11, 414, "mothim", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/414.png", "bug", "flying" },
                    { 415, 5, 488, 5, 415, "combee", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/415.png", "bug", "flying" },
                    { 416, 12, 948, 10, 416, "vespiquen", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/416.png", "bug", "flying" },
                    { 417, 8, 810, 5, 417, "pachirisu", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/417.png", "electric", "" },
                    { 418, 4, 660, 8, 418, "buizel", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/418.png", "water", "" },
                    { 419, 6, 990, 13, 419, "floatzel", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/419.png", "water", "" },
                    { 420, 5, 550, 5, 420, "cherubi", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/420.png", "grass", "" },
                    { 421, 8, 900, 7, 421, "cherrim", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/421.png", "grass", "" },
                    { 422, 6, 650, 6, 422, "shellos", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/422.png", "water", "" },
                    { 423, 8, 950, 10, 423, "gastrodon", 37, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/423.png", "water", "ground" },
                    { 424, 8, 964, 12, 424, "ambipom", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/424.png", "normal", "" },
                    { 425, 4, 696, 6, 425, "drifloon", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/425.png", "ghost", "flying" },
                    { 426, 5, 996, 10, 426, "drifblim", 50, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/426.png", "ghost", "flying" },
                    { 427, 5, 700, 8, 427, "buneary", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/427.png", "normal", "" },
                    { 428, 10, 960, 9, 428, "lopunny", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/428.png", "normal", "" },
                    { 429, 7, 990, 7, 429, "mismagius", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/429.png", "ghost", "" },
                    { 430, 6, 1010, 15, 430, "honchkrow", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/430.png", "dark", "flying" },
                    { 431, 5, 620, 6, 431, "glameow", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/431.png", "normal", "" },
                    { 432, 8, 904, 10, 432, "purugly", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/432.png", "normal", "" },
                    { 433, 6, 570, 5, 433, "chingling", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/433.png", "psychic", "" },
                    { 434, 5, 658, 7, 434, "stunky", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/434.png", "poison", "dark" },
                    { 435, 8, 958, 11, 435, "skuntank", 34, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/435.png", "poison", "dark" },
                    { 436, 10, 600, 5, 436, "bronzor", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/436.png", "steel", "psychic" },
                    { 437, 14, 1000, 11, 437, "bronzong", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/437.png", "steel", "psychic" },
                    { 438, 11, 580, 10, 438, "bonsly", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/438.png", "rock", "" },
                    { 439, 5, 620, 5, 439, "mime-jr", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/439.png", "psychic", "fairy" },
                    { 440, 0, 440, 5, 440, "happiny", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/440.png", "normal", "" },
                    { 441, 5, 822, 8, 441, "chatot", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/441.png", "normal", "flying" },
                    { 442, 13, 970, 11, 442, "spiritomb", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/442.png", "ghost", "dark" },
                    { 443, 5, 600, 8, 443, "gible", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/443.png", "dragon", "ground" },
                    { 444, 8, 820, 11, 444, "gabite", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/444.png", "dragon", "ground" },
                    { 445, 11, 1200, 16, 445, "garchomp", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/445.png", "dragon", "ground" },
                    { 446, 5, 780, 10, 446, "munchlax", 45, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/446.png", "normal", "" },
                    { 447, 5, 570, 8, 447, "riolu", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/447.png", "fighting", "" },
                    { 448, 8, 1050, 13, 448, "lucario", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/448.png", "fighting", "steel" },
                    { 449, 9, 660, 9, 449, "hippopotas", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/449.png", "ground", "" },
                    { 450, 14, 1050, 14, 450, "hippowdon", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/450.png", "ground", "" },
                    { 451, 11, 660, 6, 451, "skorupi", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/451.png", "poison", "bug" },
                    { 452, 13, 1000, 11, 452, "drapion", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/452.png", "poison", "dark" },
                    { 453, 5, 600, 7, 453, "croagunk", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/453.png", "poison", "fighting" },
                    { 454, 8, 980, 13, 454, "toxicroak", 27, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/454.png", "poison", "fighting" },
                    { 455, 9, 908, 12, 455, "carnivine", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/455.png", "grass", "" },
                    { 456, 7, 660, 6, 456, "finneon", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/456.png", "water", "" },
                    { 457, 9, 920, 8, 457, "lumineon", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/457.png", "water", "" },
                    { 458, 6, 690, 5, 458, "mantyke", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/458.png", "water", "flying" },
                    { 459, 6, 668, 7, 459, "snover", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/459.png", "grass", "ice" },
                    { 460, 9, 988, 11, 460, "abomasnow", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/460.png", "grass", "ice" },
                    { 461, 8, 1020, 15, 461, "weavile", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/461.png", "dark", "ice" },
                    { 462, 14, 1070, 8, 462, "magnezone", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/462.png", "electric", "steel" },
                    { 463, 11, 1030, 10, 463, "lickilicky", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/463.png", "normal", "" },
                    { 464, 16, 1070, 17, 464, "rhyperior", 38, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/464.png", "ground", "rock" },
                    { 465, 15, 1070, 12, 465, "tangrowth", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/465.png", "grass", "" },
                    { 466, 8, 1080, 15, 466, "electivire", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/466.png", "electric", "" },
                    { 467, 8, 1080, 11, 467, "magmortar", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/467.png", "fire", "" },
                    { 468, 11, 1090, 6, 468, "togekiss", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/468.png", "fairy", "flying" },
                    { 469, 10, 1030, 9, 469, "yanmega", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/469.png", "bug", "flying" },
                    { 470, 16, 1050, 13, 470, "leafeon", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/470.png", "grass", "" },
                    { 471, 13, 1050, 7, 471, "glaceon", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/471.png", "ice", "" },
                    { 472, 15, 1020, 11, 472, "gliscor", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/472.png", "ground", "flying" },
                    { 473, 10, 1060, 16, 473, "mamoswine", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/473.png", "ice", "ground" },
                    { 474, 8, 1070, 10, 474, "porygon-z", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/474.png", "normal", "" },
                    { 475, 8, 1036, 15, 475, "gallade", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/475.png", "psychic", "fighting" },
                    { 476, 18, 1050, 6, 476, "probopass", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/476.png", "rock", "steel" },
                    { 477, 16, 1050, 12, 477, "dusknoir", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/477.png", "ghost", "" },
                    { 478, 8, 960, 10, 478, "froslass", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/478.png", "ice", "ghost" },
                    { 479, 9, 880, 6, 479, "rotom", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/479.png", "electric", "ghost" },
                    { 480, 16, 1160, 9, 480, "uxie", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/480.png", "psychic", "" },
                    { 481, 13, 1160, 13, 481, "mesprit", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/481.png", "psychic", "" },
                    { 482, 8, 1160, 15, 482, "azelf", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/482.png", "psychic", "" },
                    { 483, 15, 1360, 15, 483, "dialga", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/483.png", "steel", "dragon" },
                    { 484, 12, 1360, 15, 484, "palkia", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/484.png", "water", "dragon" },
                    { 485, 13, 1200, 11, 485, "heatran", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/485.png", "fire", "steel" },
                    { 486, 13, 1340, 20, 486, "regigigas", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/486.png", "normal", "" },
                    { 487, 15, 1360, 12, 487, "giratina-altered", 50, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/487.png", "ghost", "dragon" },
                    { 488, 13, 1160, 8, 488, "cresselia", 40, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/488.png", "psychic", "" },
                    { 489, 10, 960, 10, 489, "phione", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/489.png", "water", "" },
                    { 490, 12, 1200, 12, 490, "manaphy", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/490.png", "water", "" },
                    { 491, 11, 1200, 11, 491, "darkrai", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/491.png", "dark", "" },
                    { 492, 12, 1200, 12, 492, "shaymin-land", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/492.png", "grass", "" },
                    { 493, 15, 1440, 15, 493, "arceus", 40, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/493.png", "normal", "" },
                    { 494, 12, 1200, 12, 494, "victini", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/494.png", "psychic", "fire" },
                    { 495, 6, 616, 5, 495, "snivy", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/495.png", "grass", "" },
                    { 496, 9, 826, 7, 496, "servine", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/496.png", "grass", "" },
                    { 497, 11, 1056, 9, 497, "serperior", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/497.png", "grass", "" },
                    { 498, 5, 616, 7, 498, "tepig", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/498.png", "fire", "" },
                    { 499, 6, 836, 11, 499, "pignite", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/499.png", "fire", "fighting" },
                    { 500, 8, 1056, 15, 500, "emboar", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/500.png", "fire", "fighting" },
                    { 501, 5, 616, 6, 501, "oshawott", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/501.png", "water", "" },
                    { 502, 7, 826, 9, 502, "dewott", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/502.png", "water", "" },
                    { 503, 10, 1056, 12, 503, "samurott", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/503.png", "water", "" },
                    { 504, 4, 510, 6, 504, "patrat", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/504.png", "normal", "" },
                    { 505, 8, 840, 10, 505, "watchog", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/505.png", "normal", "" },
                    { 506, 5, 550, 7, 506, "lillipup", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/506.png", "normal", "" },
                    { 507, 8, 740, 10, 507, "herdier", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/507.png", "normal", "" },
                    { 508, 11, 1000, 13, 508, "stoutland", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/508.png", "normal", "" },
                    { 509, 4, 562, 6, 509, "purrloin", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/509.png", "dark", "" },
                    { 510, 6, 892, 11, 510, "liepard", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/510.png", "dark", "" },
                    { 511, 6, 632, 6, 511, "pansage", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/511.png", "grass", "" },
                    { 512, 7, 996, 12, 512, "simisage", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/512.png", "grass", "" },
                    { 513, 6, 632, 6, 513, "pansear", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/513.png", "fire", "" },
                    { 514, 7, 996, 12, 514, "simisear", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/514.png", "fire", "" },
                    { 515, 6, 632, 6, 515, "panpour", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/515.png", "water", "" },
                    { 516, 7, 996, 12, 516, "simipour", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/516.png", "water", "" },
                    { 517, 5, 584, 5, 517, "munna", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/517.png", "psychic", "" },
                    { 518, 10, 974, 6, 518, "musharna", 38, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/518.png", "psychic", "" },
                    { 519, 6, 528, 6, 519, "pidove", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/519.png", "normal", "flying" },
                    { 520, 7, 716, 9, 520, "tranquill", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/520.png", "normal", "flying" },
                    { 521, 10, 976, 14, 521, "unfezant", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/521.png", "normal", "flying" },
                    { 522, 4, 590, 7, 522, "blitzle", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/522.png", "electric", "" },
                    { 523, 7, 994, 12, 523, "zebstrika", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/523.png", "electric", "" },
                    { 524, 10, 560, 9, 524, "roggenrola", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/524.png", "rock", "" },
                    { 525, 13, 780, 13, 525, "boldore", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/525.png", "rock", "" },
                    { 526, 16, 1030, 16, 526, "gigalith", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/526.png", "rock", "" },
                    { 527, 5, 646, 5, 527, "woobat", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/527.png", "psychic", "flying" },
                    { 528, 6, 850, 7, 528, "swoobat", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/528.png", "psychic", "flying" },
                    { 529, 5, 656, 10, 529, "drilbur", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/529.png", "ground", "" },
                    { 530, 7, 1016, 16, 530, "excadrill", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/530.png", "ground", "steel" },
                    { 531, 10, 890, 7, 531, "audino", 34, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/531.png", "normal", "" },
                    { 532, 6, 610, 10, 532, "timburr", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/532.png", "fighting", "" },
                    { 533, 10, 810, 13, 533, "gurdurr", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/533.png", "fighting", "" },
                    { 534, 11, 1010, 17, 534, "conkeldurr", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/534.png", "fighting", "" },
                    { 535, 5, 588, 6, 535, "tympole", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/535.png", "water", "" },
                    { 536, 6, 768, 8, 536, "palpitoad", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/536.png", "water", "ground" },
                    { 537, 9, 1018, 11, 537, "seismitoad", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/537.png", "water", "ground" },
                    { 538, 10, 930, 12, 538, "throh", 40, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/538.png", "fighting", "" },
                    { 539, 9, 930, 15, 539, "sawk", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/539.png", "fighting", "" },
                    { 540, 8, 620, 6, 540, "sewaddle", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/540.png", "bug", "grass" },
                    { 541, 11, 760, 7, 541, "swadloon", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/541.png", "bug", "grass" },
                    { 542, 10, 1000, 12, 542, "leavanny", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/542.png", "bug", "grass" },
                    { 543, 7, 520, 5, 543, "venipede", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/543.png", "bug", "poison" },
                    { 544, 12, 720, 6, 544, "whirlipede", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/544.png", "bug", "poison" },
                    { 545, 11, 970, 12, 545, "scolipede", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/545.png", "bug", "poison" },
                    { 546, 7, 560, 5, 546, "cottonee", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/546.png", "grass", "fairy" },
                    { 547, 10, 960, 8, 547, "whimsicott", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/547.png", "grass", "fairy" },
                    { 548, 6, 560, 5, 548, "petilil", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/548.png", "grass", "" },
                    { 549, 9, 960, 7, 549, "lilligant", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/549.png", "grass", "" },
                    { 550, 8, 920, 11, 550, "basculin-red-striped", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/550.png", "water", "" },
                    { 551, 4, 584, 9, 551, "sandile", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/551.png", "ground", "dark" },
                    { 552, 5, 702, 10, 552, "krokorok", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/552.png", "ground", "dark" },
                    { 553, 10, 1038, 14, 553, "krookodile", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/553.png", "ground", "dark" },
                    { 554, 5, 630, 11, 554, "darumaka", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/554.png", "fire", "" },
                    { 555, 6, 960, 17, 555, "darmanitan-standard", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/555.png", "fire", "" },
                    { 556, 8, 922, 10, 556, "maractus", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/556.png", "grass", "" },
                    { 557, 10, 650, 8, 557, "dwebble", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/557.png", "bug", "rock" },
                    { 558, 15, 970, 13, 558, "crustle", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/558.png", "bug", "rock" },
                    { 559, 8, 696, 9, 559, "scraggy", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/559.png", "dark", "fighting" },
                    { 560, 14, 976, 11, 560, "scrafty", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/560.png", "dark", "fighting" },
                    { 561, 10, 980, 7, 561, "sigilyph", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/561.png", "psychic", "flying" },
                    { 562, 10, 606, 5, 562, "yamask", 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/562.png", "ghost", "" },
                    { 563, 18, 966, 6, 563, "cofagrigus", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/563.png", "ghost", "" },
                    { 564, 12, 710, 9, 564, "tirtouga", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/564.png", "water", "rock" },
                    { 565, 16, 990, 13, 565, "carracosta", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/565.png", "water", "rock" },
                    { 566, 5, 802, 14, 566, "archen", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/566.png", "rock", "flying" },
                    { 567, 8, 1134, 17, 567, "archeops", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/567.png", "rock", "flying" },
                    { 568, 7, 658, 6, 568, "trubbish", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/568.png", "poison", "" },
                    { 569, 10, 948, 11, 569, "garbodor", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/569.png", "poison", "" },
                    { 570, 5, 660, 8, 570, "zorua", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/570.png", "dark", "" },
                    { 571, 7, 1020, 13, 571, "zoroark", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/571.png", "dark", "" },
                    { 572, 5, 600, 6, 572, "minccino", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/572.png", "normal", "" },
                    { 573, 7, 940, 11, 573, "cinccino", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/573.png", "normal", "" },
                    { 574, 6, 580, 5, 574, "gothita", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/574.png", "psychic", "" },
                    { 575, 8, 780, 5, 575, "gothorita", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/575.png", "psychic", "" },
                    { 576, 11, 980, 6, 576, "gothitelle", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/576.png", "psychic", "" },
                    { 577, 5, 580, 5, 577, "solosis", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/577.png", "psychic", "" },
                    { 578, 6, 740, 5, 578, "duosion", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/578.png", "psychic", "" },
                    { 579, 9, 980, 8, 579, "reuniclus", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/579.png", "psychic", "" },
                    { 580, 6, 610, 5, 580, "ducklett", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/580.png", "water", "flying" },
                    { 581, 7, 946, 10, 581, "swanna", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/581.png", "water", "flying" },
                    { 582, 6, 610, 6, 582, "vanillite", 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/582.png", "ice", "" },
                    { 583, 8, 790, 8, 583, "vanillish", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/583.png", "ice", "" },
                    { 584, 10, 1070, 11, 584, "vanilluxe", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/584.png", "ice", "" },
                    { 585, 6, 670, 7, 585, "deerling", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/585.png", "normal", "grass" },
                    { 586, 8, 950, 12, 586, "sawsbuck", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/586.png", "normal", "grass" },
                    { 587, 7, 856, 9, 587, "emolga", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/587.png", "electric", "flying" },
                    { 588, 5, 630, 9, 588, "karrablast", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/588.png", "bug", "" },
                    { 589, 13, 990, 16, 589, "escavalier", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/589.png", "bug", "steel" },
                    { 590, 5, 588, 6, 590, "foongus", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/590.png", "grass", "poison" },
                    { 591, 8, 928, 10, 591, "amoonguss", 38, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/591.png", "grass", "poison" },
                    { 592, 6, 670, 5, 592, "frillish-male", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/592.png", "water", "ghost" },
                    { 593, 8, 960, 7, 593, "jellicent-male", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/593.png", "water", "ghost" },
                    { 594, 10, 940, 9, 594, "alomomola", 55, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/594.png", "water", "" },
                    { 595, 6, 638, 5, 595, "joltik", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/595.png", "bug", "electric" },
                    { 596, 7, 944, 9, 596, "galvantula", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/596.png", "bug", "electric" },
                    { 597, 11, 610, 6, 597, "ferroseed", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/597.png", "grass", "steel" },
                    { 598, 16, 978, 11, 598, "ferrothorn", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/598.png", "grass", "steel" },
                    { 599, 8, 600, 6, 599, "klink", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/599.png", "steel", "" },
                    { 600, 11, 880, 10, 600, "klang", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/600.png", "steel", "" },
                    { 601, 14, 1040, 12, 601, "klinklang", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/601.png", "steel", "" },
                    { 602, 5, 550, 6, 602, "tynamo", 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/602.png", "electric", "" },
                    { 603, 8, 810, 10, 603, "eelektrik", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/603.png", "electric", "" },
                    { 604, 10, 1030, 14, 604, "eelektross", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/604.png", "electric", "" },
                    { 605, 6, 670, 6, 605, "elgyem", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/605.png", "psychic", "" },
                    { 606, 9, 970, 9, 606, "beheeyem", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/606.png", "psychic", "" },
                    { 607, 6, 550, 5, 607, "litwick", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/607.png", "ghost", "fire" },
                    { 608, 7, 740, 5, 608, "lampent", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/608.png", "ghost", "fire" },
                    { 609, 11, 1040, 6, 609, "chandelure", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/609.png", "ghost", "fire" },
                    { 610, 7, 640, 10, 610, "axew", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/610.png", "dragon", "" },
                    { 611, 8, 820, 14, 611, "fraxure", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/611.png", "dragon", "" },
                    { 612, 11, 1080, 18, 612, "haxorus", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/612.png", "dragon", "" },
                    { 613, 5, 610, 8, 613, "cubchoo", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/613.png", "ice", "" },
                    { 614, 10, 1010, 16, 614, "beartic", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/614.png", "ice", "" },
                    { 615, 6, 1030, 6, 615, "cryogonal", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/615.png", "ice", "" },
                    { 616, 10, 610, 5, 616, "shelmet", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/616.png", "bug", "" },
                    { 617, 5, 990, 8, 617, "accelgor", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/617.png", "bug", "" },
                    { 618, 10, 942, 8, 618, "stunfisk", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/618.png", "ground", "electric" },
                    { 619, 6, 700, 10, 619, "mienfoo", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/619.png", "fighting", "" },
                    { 620, 7, 1020, 15, 620, "mienshao", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/620.png", "fighting", "" },
                    { 621, 11, 970, 15, 621, "druddigon", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/621.png", "dragon", "" },
                    { 622, 6, 606, 9, 622, "golett", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/622.png", "ground", "ghost" },
                    { 623, 10, 966, 15, 623, "golurk", 29, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/623.png", "ground", "ghost" },
                    { 624, 8, 680, 10, 624, "pawniard", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/624.png", "dark", "steel" },
                    { 625, 12, 980, 15, 625, "bisharp", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/625.png", "dark", "steel" },
                    { 626, 11, 980, 13, 626, "bouffalant", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/626.png", "normal", "" },
                    { 627, 6, 700, 10, 627, "rufflet", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/627.png", "normal", "flying" },
                    { 628, 9, 1020, 15, 628, "braviary", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/628.png", "normal", "flying" },
                    { 629, 9, 740, 6, 629, "vullaby", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/629.png", "dark", "flying" },
                    { 630, 13, 1020, 8, 630, "mandibuzz", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/630.png", "dark", "flying" },
                    { 631, 8, 968, 12, 631, "heatmor", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/631.png", "fire", "" },
                    { 632, 14, 968, 13, 632, "durant", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/632.png", "bug", "steel" },
                    { 633, 6, 600, 8, 633, "deino", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/633.png", "dark", "dragon" },
                    { 634, 8, 840, 10, 634, "zweilous", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/634.png", "dark", "dragon" },
                    { 635, 11, 1200, 13, 635, "hydreigon", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/635.png", "dark", "dragon" },
                    { 636, 6, 720, 10, 636, "larvesta", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/636.png", "bug", "fire" },
                    { 637, 8, 1100, 7, 637, "volcarona", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/637.png", "bug", "fire" },
                    { 638, 16, 1160, 11, 638, "cobalion", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/638.png", "steel", "fighting" },
                    { 639, 11, 1160, 16, 639, "terrakion", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/639.png", "rock", "fighting" },
                    { 640, 9, 1160, 11, 640, "virizion", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/640.png", "grass", "fighting" },
                    { 641, 8, 1160, 14, 641, "tornadus-incarnate", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/641.png", "flying", "" },
                    { 642, 8, 1160, 14, 642, "thundurus-incarnate", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/642.png", "electric", "flying" },
                    { 643, 12, 1360, 15, 643, "reshiram", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/643.png", "dragon", "fire" },
                    { 644, 15, 1360, 18, 644, "zekrom", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/644.png", "dragon", "electric" },
                    { 645, 11, 1200, 15, 645, "landorus-incarnate", 29, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/645.png", "ground", "flying" },
                    { 646, 11, 1320, 16, 646, "kyurem", 41, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/646.png", "dragon", "ice" },
                    { 647, 11, 1160, 9, 647, "keldeo-ordinary", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/647.png", "water", "fighting" },
                    { 648, 9, 1200, 9, 648, "meloetta-aria", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/648.png", "normal", "psychic" },
                    { 649, 11, 1200, 15, 649, "genesect", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/649.png", "bug", "steel" },
                    { 650, 8, 626, 7, 650, "chespin", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/650.png", "grass", "" },
                    { 651, 11, 810, 9, 651, "quilladin", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/651.png", "grass", "" },
                    { 652, 15, 1060, 13, 652, "chesnaught", 29, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/652.png", "grass", "fighting" },
                    { 653, 5, 614, 5, 653, "fennekin", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/653.png", "fire", "" },
                    { 654, 7, 818, 7, 654, "braixen", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/654.png", "fire", "" },
                    { 655, 9, 1068, 8, 655, "delphox", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/655.png", "fire", "psychic" },
                    { 656, 5, 628, 7, 656, "froakie", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/656.png", "water", "" },
                    { 657, 6, 810, 7, 657, "frogadier", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/657.png", "water", "" },
                    { 658, 8, 1060, 11, 658, "greninja", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/658.png", "water", "dark" },
                    { 659, 4, 474, 5, 659, "bunnelby", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/659.png", "normal", "" },
                    { 660, 9, 846, 7, 660, "diggersby", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/660.png", "normal", "ground" },
                    { 661, 5, 556, 6, 661, "fletchling", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/661.png", "normal", "flying" },
                    { 662, 6, 764, 9, 662, "fletchinder", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/662.png", "fire", "flying" },
                    { 663, 8, 998, 10, 663, "talonflame", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/663.png", "fire", "flying" },
                    { 664, 5, 400, 5, 664, "scatterbug", 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/664.png", "bug", "" },
                    { 665, 7, 426, 5, 665, "spewpa", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/665.png", "bug", "" },
                    { 666, 6, 822, 6, 666, "vivillon", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/666.png", "bug", "flying" },
                    { 667, 7, 738, 6, 667, "litleo", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/667.png", "fire", "normal" },
                    { 668, 9, 1014, 8, 668, "pyroar-male", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/668.png", "fire", "normal" },
                    { 669, 4, 606, 5, 669, "flabebe", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/669.png", "fairy", "" },
                    { 670, 5, 742, 5, 670, "floette", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/670.png", "fairy", "" },
                    { 671, 8, 1104, 8, 671, "florges", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/671.png", "fairy", "" },
                    { 672, 6, 700, 8, 672, "skiddo", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/672.png", "grass", "" },
                    { 673, 7, 1062, 12, 673, "gogoat", 41, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/673.png", "grass", "" },
                    { 674, 7, 696, 10, 674, "pancham", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/674.png", "fighting", "" },
                    { 675, 9, 990, 15, 675, "pangoro", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/675.png", "fighting", "dark" },
                    { 676, 7, 944, 10, 676, "furfrou", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/676.png", "normal", "" },
                    { 677, 6, 710, 6, 677, "espurr", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/677.png", "psychic", "" },
                    { 678, 9, 932, 6, 678, "meowstic-male", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/678.png", "psychic", "" },
                    { 679, 12, 650, 10, 679, "honedge", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/679.png", "steel", "ghost" },
                    { 680, 18, 896, 13, 680, "doublade", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/680.png", "steel", "ghost" },
                    { 681, 17, 1000, 6, 681, "aegislash-shield", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/681.png", "steel", "ghost" },
                    { 682, 7, 682, 6, 682, "spritzee", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/682.png", "fairy", "" },
                    { 683, 9, 924, 9, 683, "aromatisse", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/683.png", "fairy", "" },
                    { 684, 8, 682, 6, 684, "swirlix", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/684.png", "fairy", "" },
                    { 685, 10, 960, 10, 685, "slurpuff", 27, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/685.png", "fairy", "" },
                    { 686, 6, 576, 6, 686, "inkay", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/686.png", "dark", "psychic" },
                    { 687, 11, 964, 11, 687, "malamar", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/687.png", "dark", "psychic" },
                    { 688, 8, 612, 6, 688, "binacle", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/688.png", "rock", "water" },
                    { 689, 14, 1000, 13, 689, "barbaracle", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/689.png", "rock", "water" },
                    { 690, 7, 640, 7, 690, "skrelp", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/690.png", "poison", "water" },
                    { 691, 11, 988, 9, 691, "dragalge", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/691.png", "poison", "dragon" },
                    { 692, 7, 660, 6, 692, "clauncher", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/692.png", "water", "" },
                    { 693, 11, 1000, 9, 693, "clawitzer", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/693.png", "water", "" },
                    { 694, 4, 578, 5, 694, "helioptile", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/694.png", "electric", "normal" },
                    { 695, 6, 962, 6, 695, "heliolisk", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/695.png", "electric", "normal" },
                    { 696, 9, 724, 11, 696, "tyrunt", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/696.png", "rock", "dragon" },
                    { 697, 14, 1042, 15, 697, "tyrantrum", 27, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/697.png", "rock", "dragon" },
                    { 698, 6, 724, 7, 698, "amaura", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/698.png", "rock", "ice" },
                    { 699, 9, 1042, 9, 699, "aurorus", 41, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/699.png", "rock", "ice" },
                    { 700, 8, 1050, 8, 700, "sylveon", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/700.png", "fairy", "" },
                    { 701, 9, 1000, 11, 701, "hawlucha", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/701.png", "fighting", "flying" },
                    { 702, 7, 862, 7, 702, "dedenne", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/702.png", "electric", "fairy" },
                    { 703, 18, 1000, 6, 703, "carbink", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/703.png", "rock", "fairy" },
                    { 704, 4, 600, 6, 704, "goomy", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/704.png", "dragon", "" },
                    { 705, 6, 904, 9, 705, "sliggoo", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/705.png", "dragon", "" },
                    { 706, 8, 1200, 12, 706, "goodra", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/706.png", "dragon", "" },
                    { 707, 11, 940, 10, 707, "klefki", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/707.png", "steel", "fairy" },
                    { 708, 6, 618, 8, 708, "phantump", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/708.png", "ghost", "grass" },
                    { 709, 9, 948, 13, 709, "trevenant", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/709.png", "ghost", "grass" },
                    { 710, 8, 670, 8, 710, "pumpkaboo-average", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/710.png", "ghost", "grass" },
                    { 711, 15, 988, 11, 711, "gourgeist-average", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/711.png", "ghost", "grass" },
                    { 712, 10, 608, 8, 712, "bergmite", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/712.png", "ice", "" },
                    { 713, 23, 1028, 14, 713, "avalugg", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/713.png", "ice", "" },
                    { 714, 4, 490, 5, 714, "noibat", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/714.png", "flying", "dragon" },
                    { 715, 10, 1070, 8, 715, "noivern", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/715.png", "flying", "dragon" },
                    { 716, 11, 1360, 16, 716, "xerneas", 42, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/716.png", "fairy", "" },
                    { 717, 11, 1360, 16, 717, "yveltal", 42, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/717.png", "dark", "flying" },
                    { 718, 15, 1200, 12, 718, "zygarde-50", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/718.png", "dragon", "ground" },
                    { 719, 18, 1200, 12, 719, "diancie", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/719.png", "rock", "fairy" },
                    { 720, 7, 1200, 13, 720, "hoopa", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/720.png", "psychic", "ghost" },
                    { 721, 15, 1200, 13, 721, "volcanion", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/721.png", "fire", "water" },
                    { 722, 6, 640, 6, 722, "rowlet", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/722.png", "grass", "flying" },
                    { 723, 9, 840, 9, 723, "dartrix", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/723.png", "grass", "flying" },
                    { 724, 9, 1060, 13, 724, "decidueye", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/724.png", "grass", "ghost" },
                    { 725, 5, 640, 8, 725, "litten", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/725.png", "fire", "" },
                    { 726, 6, 840, 10, 726, "torracat", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/726.png", "fire", "" },
                    { 727, 11, 1060, 14, 727, "incineroar", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/727.png", "fire", "dark" },
                    { 728, 6, 640, 6, 728, "popplio", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/728.png", "water", "" },
                    { 729, 8, 840, 8, 729, "brionne", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/729.png", "water", "" },
                    { 730, 9, 1060, 9, 730, "primarina", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/730.png", "water", "fairy" },
                    { 731, 3, 530, 9, 731, "pikipek", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/731.png", "normal", "flying" },
                    { 732, 6, 710, 10, 732, "trumbeak", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/732.png", "normal", "flying" },
                    { 733, 9, 970, 15, 733, "toucannon", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/733.png", "normal", "flying" },
                    { 734, 3, 506, 8, 734, "yungoos", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/734.png", "normal", "" },
                    { 735, 7, 836, 13, 735, "gumshoos", 29, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/735.png", "normal", "" },
                    { 736, 5, 600, 7, 736, "grubbin", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/736.png", "bug", "" },
                    { 737, 11, 800, 10, 737, "charjabug", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/737.png", "bug", "electric" },
                    { 738, 11, 1000, 8, 738, "vikavolt", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/738.png", "bug", "electric" },
                    { 739, 7, 676, 10, 739, "crabrawler", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/739.png", "fighting", "" },
                    { 740, 9, 956, 16, 740, "crabominable", 32, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/740.png", "fighting", "ice" },
                    { 741, 8, 952, 8, 741, "oricorio-baile", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/741.png", "fire", "flying" },
                    { 742, 5, 608, 5, 742, "cutiefly", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/742.png", "bug", "fairy" },
                    { 743, 7, 928, 6, 743, "ribombee", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/743.png", "bug", "fairy" },
                    { 744, 5, 560, 8, 744, "rockruff", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/744.png", "rock", "" },
                    { 745, 8, 974, 14, 745, "lycanroc-midday", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/745.png", "rock", "" },
                    { 746, 2, 350, 5, 746, "wishiwashi-solo", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/746.png", "water", "" },
                    { 747, 7, 610, 6, 747, "mareanie", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/747.png", "poison", "water" },
                    { 748, 19, 990, 7, 748, "toxapex", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/748.png", "poison", "water" },
                    { 749, 8, 770, 12, 749, "mudbray", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/749.png", "ground", "" },
                    { 750, 12, 1000, 15, 750, "mudsdale", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/750.png", "ground", "" },
                    { 751, 6, 538, 5, 751, "dewpider", 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/751.png", "water", "bug" },
                    { 752, 11, 908, 8, 752, "araquanid", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/752.png", "water", "bug" },
                    { 753, 4, 500, 6, 753, "fomantis", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/753.png", "grass", "" },
                    { 754, 11, 960, 13, 754, "lurantis", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/754.png", "grass", "" },
                    { 755, 6, 570, 5, 755, "morelull", 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/755.png", "grass", "fairy" },
                    { 756, 10, 810, 5, 756, "shiinotic", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/756.png", "grass", "fairy" },
                    { 757, 5, 640, 5, 757, "salandit", 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/757.png", "poison", "fire" },
                    { 758, 7, 960, 8, 758, "salazzle", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/758.png", "poison", "fire" },
                    { 759, 6, 680, 9, 759, "stufful", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/759.png", "normal", "fighting" },
                    { 760, 10, 1000, 15, 760, "bewear", 40, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/760.png", "normal", "fighting" },
                    { 761, 4, 420, 5, 761, "bounsweet", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/761.png", "grass", "" },
                    { 762, 6, 580, 5, 762, "steenee", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/762.png", "grass", "" },
                    { 763, 12, 1020, 15, 763, "tsareena", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/763.png", "grass", "" },
                    { 764, 11, 970, 6, 764, "comfey", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/764.png", "fairy", "" },
                    { 765, 10, 980, 7, 765, "oranguru", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/765.png", "normal", "psychic" },
                    { 766, 11, 980, 15, 766, "passimian", 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/766.png", "fighting", "" },
                    { 767, 5, 460, 5, 767, "wimpod", 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/767.png", "bug", "water" },
                    { 768, 17, 1060, 15, 768, "golisopod", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/768.png", "bug", "water" },
                    { 769, 10, 640, 6, 769, "sandygast", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/769.png", "ghost", "ground" },
                    { 770, 13, 960, 9, 770, "palossand", 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/770.png", "ghost", "ground" },
                    { 771, 16, 820, 7, 771, "pyukumuku", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/771.png", "water", "" },
                    { 772, 11, 1068, 11, 772, "type-null", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/772.png", "normal", "" },
                    { 773, 11, 1140, 11, 773, "silvally", 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/773.png", "normal", "" },
                    { 774, 12, 880, 7, 774, "minior-red-meteor", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/774.png", "rock", "flying" },
                    { 775, 8, 960, 14, 775, "komala", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/775.png", "normal", "" },
                    { 776, 16, 970, 9, 776, "turtonator", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/776.png", "fire", "dragon" },
                    { 777, 7, 870, 12, 777, "togedemaru", 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/777.png", "electric", "steel" },
                    { 778, 10, 952, 11, 778, "mimikyu-disguised", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/778.png", "ghost", "fairy" },
                    { 779, 8, 950, 13, 779, "bruxish", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/779.png", "water", "psychic" },
                    { 780, 10, 970, 7, 780, "drampa", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/780.png", "normal", "dragon" },
                    { 781, 12, 1034, 16, 781, "dhelmise", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/781.png", "ghost", "grass" },
                    { 782, 8, 600, 6, 782, "jangmo-o", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/782.png", "dragon", "" },
                    { 783, 11, 840, 9, 783, "hakamo-o", 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/783.png", "dragon", "fighting" },
                    { 784, 15, 1200, 13, 784, "kommo-o", 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/784.png", "dragon", "fighting" },
                    { 785, 10, 1140, 14, 785, "tapu-koko", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/785.png", "electric", "fairy" },
                    { 786, 9, 1140, 10, 786, "tapu-lele", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/786.png", "psychic", "fairy" },
                    { 787, 14, 1140, 16, 787, "tapu-bulu", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/787.png", "grass", "fairy" },
                    { 788, 14, 1140, 9, 788, "tapu-fini", 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/788.png", "water", "fairy" },
                    { 789, 3, 400, 5, 789, "cosmog", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/789.png", "psychic", "" },
                    { 790, 16, 800, 5, 790, "cosmoem", 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/790.png", "psychic", "" },
                    { 791, 13, 1360, 17, 791, "solgaleo", 45, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/791.png", "psychic", "steel" },
                    { 792, 11, 1360, 14, 792, "lunala", 45, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/792.png", "psychic", "ghost" },
                    { 793, 5, 1140, 6, 793, "nihilego", 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/793.png", "rock", "poison" },
                    { 794, 17, 1140, 17, 794, "buzzwole", 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/794.png", "bug", "fighting" },
                    { 795, 4, 1140, 17, 795, "pheromosa", 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/795.png", "bug", "fighting" },
                    { 796, 8, 1140, 11, 796, "xurkitree", 27, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/796.png", "electric", "" },
                    { 797, 12, 1140, 12, 797, "celesteela", 32, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/797.png", "steel", "flying" },
                    { 798, 16, 1140, 22, 798, "kartana", 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/798.png", "grass", "steel" },
                    { 799, 6, 1140, 12, 799, "guzzlord", 74, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/799.png", "dark", "dragon" },
                    { 800, 12, 1200, 13, 800, "necrozma", 32, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/800.png", "psychic", "" },
                    { 801, 14, 1200, 11, 801, "magearna", 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/801.png", "steel", "fairy" },
                    { 802, 10, 1200, 15, 802, "marshadow", 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/802.png", "fighting", "ghost" },
                    { 803, 8, 840, 9, 803, "poipole", 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/803.png", "poison", "" },
                    { 804, 9, 1080, 9, 804, "naganadel", 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/804.png", "poison", "dragon" },
                    { 805, 26, 1140, 16, 805, "stakataka", 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/805.png", "rock", "steel" },
                    { 806, 6, 1140, 15, 806, "blacephalon", 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/806.png", "fire", "ghost" },
                    { 807, 9, 1200, 14, 807, "zeraora", 29, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/807.png", "electric", "" },
                    { 808, 8, 600, 8, 808, "meltan", 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/808.png", "steel", "" },
                    { 809, 17, 1200, 17, 809, "melmetal", 45, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/809.png", "steel", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Monstres",
                table: "Monstres");

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Monstres",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DropColumn(
                name: "MonsterId",
                table: "Monstres");

            migrationBuilder.RenameTable(
                name: "Monstres",
                newName: "Monstre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monstre",
                table: "Monstre",
                column: "Id");
        }
    }
}
