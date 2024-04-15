using Hero.Characters;
using System;

namespace Hero.Stats
{
    class RapidStrikes : Abilities
    {
        public RapidStrikes()
        {
        }
        public void Cast(Character caster, Character enemy)
        {
            if (isLucky())
            {
                enemy.TakeDamage(caster);
                System.Console.WriteLine(caster.getName() + " used Rapid Strikes");
            }
        }
        public bool isLucky()
        {
            return 10 > new Random().Next(1, 100);
        }
    }
}
