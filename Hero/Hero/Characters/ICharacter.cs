namespace Hero.Characters
{
    interface ICharacter
    {
        void Attack(Character enemy);

        bool isFaster(Character other);

        bool isAlive();

        bool isLucky();

        void TakeDamage(Character attacker);

        int ComputeDamage(Character attacker);
        void loseHealth(int damage);
        void gainHealth(int health);
    }
}
