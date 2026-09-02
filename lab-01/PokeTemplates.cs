using System;
using System.Collections.Generic;
using System.Text;

namespace lab_01
{
    public class PokeTemplate
    {
        public int id { get; set; }
        public string name { get; set; } = "";
        public List<StatsTemplate> stats { get; set; } = new List<StatsTemplate>();
        public SpriteTemplate sprites { get; set; } = new SpriteTemplate();
        public List<TypeTemplate> types { get; set; } = new List<TypeTemplate>();

        public override string ToString()
        {
            string strStats = "";
            stats.ForEach(st => strStats = $"{strStats}{st.stat.name} : {st.base_stat}\n");
            string stTypes;

            switch (types.Count())
            {
                case 1:
                    stTypes = $"t1 {types[0].type.name ?? "strStats"}";
                    break;
                case 2:
                    stTypes = $"t1 {types[0].type.name ?? "strStats"}\nt2 {types[1].type.name ?? "Nop"}";
                    break;
                default:
                    stTypes = "";
                    break;
            }

            return $"{id}, {name}\n{strStats}\n{sprites.front_default}\n{stTypes}";
        }

        public Pokemon ConvertToPoke()
        {
            Dictionary<string, int> dicoStats = new Dictionary<string, int>();
            stats.ForEach(st => dicoStats.Add(st.stat.name, st.base_stat));

            if (types.Count() < 2) types.Add(new TypeTemplate());

            return new Pokemon
            (
                id, name, dicoStats, sprites.front_default, 
                types[0].type.name, types[1].type.name
            );
        }
    }

    public class StatsTemplate
    {
        public int base_stat;
        public StatTemplate stat { get; set; } = new StatTemplate();
    }

    public class StatTemplate
    {
        public string name = "";
    }

    public class SpriteTemplate
    {
        public string front_default { get; set; } = "";
    }

    public class TypeTemplate
    {
        public TNameTemplate type = new TNameTemplate();
    }

    public class TNameTemplate
    {
        public string name = "";
    }
}
