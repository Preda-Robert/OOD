using System;

namespace Hero.Stats
{
    class Luck
    {
        private int luck;
        public Luck(int luck)
        {
            this.luck = luck;
        }
        public Luck(int luckMin, int luckMax)
        {
            this.luck = new Random().Next(luckMin, luckMax);
        }

        public bool isLucky()
        {
            return luck > new Random().Next(1, 100);
        }

        public bool isLucky(int newLuck)
        {
            return newLuck > new Random().Next(1, 100);
        }
    }
}
