using System;
namespace Hero.Stats
{
    class Health
    {
        private int health;
        public Health(int health)
        {
            this.health = health;
        }
        public Health(int healthMin, int healthMax)
        {
            this.health = new Random().Next(healthMin, healthMax);
        }
        public void Query(int hp)
        {
            health += hp;
        }
        public static bool operator >(Health a, int nr)
        {
            return a.health > nr;
        }

        public static bool operator <(Health a, int nr)
        {
            return a.health < nr;
        }

        public int getHealth()
        {
            return health;
        }
    }
}
