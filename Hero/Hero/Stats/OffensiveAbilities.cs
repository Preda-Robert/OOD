using Hero.Characters;
using System.Collections.Generic;

namespace Hero.Stats
{
    class OffensiveAbilities
    {
        private List<Abilities> abilities;

        public OffensiveAbilities()
        {
            abilities = new List<Abilities>();
        }
        public OffensiveAbilities(List<Abilities> abilities)
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
