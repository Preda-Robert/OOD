using System;

namespace Hero.Stats
{
    internal class Defense
    {
        private int defense;
        public Defense(int defense)
        {
            this.defense = defense;
        }
        public Defense(int defenseMin, int defenseMax)
        {
            this.defense = new Random().Next(defenseMin, defenseMax);
        }
        public int ReduceDamage(Strength strength)
        {
            return Math.Max(0, strength.Damage() - defense);
        }
    }
}
