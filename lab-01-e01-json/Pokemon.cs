using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace lab_01
{
    public class CallApiPokemon
    {
        public static async Task<JsonDocument> AskPokeApi(int id)
        {
            HttpClient client = new HttpClient();

            // https://pokeapi.co/api/v2/pokemon/
            string result = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}");

            JsonDocument jsonResult = JsonDocument.Parse(result);

            return jsonResult;
        }
    }


    public class Pokemon
    {

        private int pokemonId;
        private string nom = "";
        private int pointDeVieBase; // HP / 3 (min 3)
        private int forceBase; // Attaque / 8 (minimum 5)
        private int defenseBase; // Défense / 8 (minimum 3)
        private int experienceBase; // Moyenne des stats x 2
        private string spriteUrl = ""; // URL du sprite front_default
        private string type1 = ""; // Premier type du Pokémon
        private string? type2; // Second type du Pokémon

        [JsonProperty("id")]
        public int MonsterId
        {
            get => pokemonId;
            set { Id = value; }
        }
        public int Id
        {
            get => pokemonId;
            set
            {
                //if (value == 0)
                //{
                //    pokemonId = value;
                //}
                //else throw new ArgumentException("Id can't be 0");
                pokemonId = value;
            }
        }

        [JsonProperty("nom")]
        public string Nom
        {
            get => nom;
            set
            {
                nom = value ?? throw new ArgumentException("Must have a name");
            }
        }

        [JsonProperty("pointsVieBase")]
        public int PointDeVieBase
        {
            get => pointDeVieBase;
            set => pointDeVieBase = value;
        }

        public static int ConvertPv(int value)
        {
            int pv = value / 3;
            if (pv < 10)
            {
                pv = 10;
            }
            return pv;
        }

        [JsonProperty("forceBase")]
        public int ForceBase
        {
            get => forceBase;
            set => forceBase = value;
        }

        public static int ConvertForce(int value)
        {
            int force = value / 8;
            if (force < 5)
            {
                force = 5;
            }
            return force;
        }

        [JsonProperty("defenseBase")]
        public int DefenseBase
        {
            get => defenseBase;
            set => defenseBase = value;
        }

        public static int ConvertDefense(int value)
        {
            int defense = value / 8;
            if (defense < 5)
            {
                defense = 5;
            }
            return defense;
        }

        [JsonProperty("experienceBase")]
        public int ExperienceBase
        {
            get => experienceBase;
            set => experienceBase = value;
        }

        public static int ConvertExp(int value)
            => value < 0 ? 0 : value * 2;

        [JsonProperty("spriteUrl")]
        public string SpriteUrl
        {
            get => spriteUrl;
            set
            {
                spriteUrl = value ?? throw new ArgumentException("Must have a sprite");
            }
        }

        [JsonProperty("type1")]
        public string Type1
        {
            get => type1;
            set
            {
                type1 = value ?? throw new ArgumentException("Must have at least one type");
            }
        }

        [JsonProperty("type2")]
        public string? Type2
        {
            get => type2;
            set { type2 = value; }
        }

        public Pokemon()
        {
            //pokemonId = 0;
            //Nom = "MissingNo."; // https://www.pokepedia.fr/MissingNo
            //PointDeVieBase = 33;
            //ForceBase = 136;
            //DefenseBase = 0;
            //ExperienceBase = 33 + 136 + 0 + 1 + 1 + 29 + 6;
            //SpriteUrl = "https://www.pokepedia.fr/images/9/91/%2C_%27M_%2800%29.png";
            //Type1 = "normal";
            //Type2 = null;
        }

        // From PokeAPI
        public Pokemon(int _pokemonId, string _name,
            Dictionary<string, int> _stats, string _spriteUrl,
            string _type1, string? _type2)
        {
            Id = _pokemonId;
            Nom = _name;
            PointDeVieBase = ConvertPv(_stats["hp"]);
            ForceBase = ConvertForce(_stats["attack"]);
            DefenseBase = ConvertDefense(_stats["defense"]);

            ExperienceBase = ConvertExp(_stats["hp"] + _stats["attack"] +
                _stats["defense"] + _stats["special-attack"] +
                _stats["special-defense"] + _stats["speed"]);

            SpriteUrl = _spriteUrl;
            Type1 = _type1;
            Type2 = _type2;
        }

        // From Json
        private Pokemon(int _pokemonId, string _nom, int _pointVieBase,
            int _forceBase, int _defenseBase, int _experienceBase,
            string _spriteUrl, string _type1, string? _type2)
        {
            pokemonId = _pokemonId;
            nom = _nom;
            pointDeVieBase = _pointVieBase;
            forceBase = _forceBase;
            defenseBase = _defenseBase;
            experienceBase = _experienceBase;
            spriteUrl = _spriteUrl;
            type1 = _type1;
            type2 = _type2;
        }



        public static Pokemon MissingNo()
        {
            return new Pokemon
            (
                -1,
                "MissingNo.",
                ConvertPv(33),
                ConvertForce(136),
                ConvertForce(0),
                ConvertExp(33 + 136 + 0 + 1 + 1 + 29 + 6),
                "https://www.pokepedia.fr/images/9/91/%2C_%27M_%2800%29.png",
                "normal",
                null
            );
        }

        public override string ToString()
            => JsonConvert.SerializeObject(this);
    }
}

    // 1        normal     
    // 2        fighting   
    // 3        flying     
    // 4        poison     
    // 5        ground     
    // 6        rock       
    // 7        bug        
    // 8        ghost      
    // 9        steel      
    // 10       fire       
    // 11       water      
    // 12       grass      
    // 13       electric   
    // 14       psychic    
    // 15       ice        
    // 16       dragon     
    // 17       dark       
    // 18       fairy      
    // 19       stellar    
    // 10001    unknown    
