using Hero.Stats;

namespace Hero.Characters
{
    class Beast : Character
    {
        public Beast(string name, Health health, Speed speed, Strength strength, Luck luck, Defense defense, OffensiveAbilities OffensiveAbilities, DefensiveAbilities DefensiveAbilities)
            : base("Beast", new Health(60, 90), new Speed(40, 60), new Strength(60, 90), new Luck(25, 40), new Defense(40, 60), OffensiveAbilities, DefensiveAbilities)
        {
        }
    }
}
