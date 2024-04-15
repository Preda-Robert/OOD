using System;

namespace Hero.Stats
{
    class Speed
    {
        private int speed;
        public Speed(int speed)
        {
            this.speed = speed;
        }
        public Speed(int speedMin, int speedMax)
        {
            this.speed = new Random().Next(speedMin, speedMax);
        }

        public static bool operator >(Speed a, Speed b)
        {
            return a.speed > b.speed;
        }
        public static bool operator <(Speed a, Speed b)
        {
            return a.speed < b.speed;
        }
    }
}
