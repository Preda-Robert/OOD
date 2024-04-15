using Hero.Characters;
using System.Collections.Generic;

namespace Hero.Stats
{
    class DefensiveAbilities
    {
        private List<Abilities> abilities;
        public DefensiveAbilities()
        {
            abilities = new List<Abilities>();
        }
        public DefensiveAbilities(List<Abilities> abilities)
        {
            this.abilities = abilities;
        }

        public void Use(Character character, Character enemy)
        {
            foreach (var ability in abilities)
            {
                ability.Cast(character, enemy);
            }
        }
    }
}
