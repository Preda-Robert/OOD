using Hero.Characters;
using System;

namespace Hero.Stats
{
    class MagicShield : Abilities
    {
        public MagicShield()
        {
        }
        public void Cast(Character caster, Character enemy)
        {
            if (isLucky())
            {
                caster.gainHealth(caster.ComputeDamage(enemy) / 2);
                System.Console.WriteLine(caster.getName() + " used Magic Shield");
            }
        }

        public bool isLucky()
        {
            return 20 > new Random().Next(1, 100);
        }
    }
}
