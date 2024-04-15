using Hero.Stats;
using System.Collections.Generic;

namespace Hero.Characters
{
    class Ordeus : Character
    {
        public Ordeus(string name, Health health, Speed speed, Strength strength, Luck luck, Defense defense, OffensiveAbilities OffensiveAbilities, DefensiveAbilities DefensiveAbilities)
           : base("Ordeus", new Health(70, 100), new Speed(40, 50), new Strength(70, 80), new Luck(10, 30), new Defense(45, 55), new OffensiveAbilities(new List<Abilities> { new RapidStrikes() }), new DefensiveAbilities(new List<Abilities> { new MagicShield() }))
        {
        }


    }
}
