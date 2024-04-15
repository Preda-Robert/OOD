using System;

namespace Hero.Stats
{
    class Strength
    {
        private int strength;
        public Strength(int strength)
        {
            this.strength = strength;
        }
        public Strength(int strengthMin, int strengthMax)
        {
            this.strength = new Random().Next(strengthMin, strengthMax);
        }

        public int Damage()
        {
            return strength;
        }
    }
}
