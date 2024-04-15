using Hero.Stats;

namespace Hero.Characters
{
    class Character : ICharacter
    {
        private string name;
        private Health health;
        private Speed speed;
        private Strength strength;
        private Luck luck;
        private Defense defense;
        private OffensiveAbilities OffensiveAbilities;
        private DefensiveAbilities DefensiveAbilities;

        public Character(string name, Health health, Speed speed, Strength strength, Luck luck, Defense defense, OffensiveAbilities OffensiveAbilities, DefensiveAbilities DefensiveAbilities)
        {
            this.name = name;
            this.health = health;
            this.speed = speed;
            this.strength = strength;
            this.luck = luck;
            this.defense = defense;
            this.OffensiveAbilities = OffensiveAbilities;
            this.DefensiveAbilities = DefensiveAbilities;
        }

        public void Attack(Character enemy)
        {
            OffensiveAbilities.Use(this, enemy);
            if (!enemy.isLucky())
            {
                enemy.TakeDamage(this);
            }
            else
            {
                System.Console.WriteLine($"{enemy.name} was lucky and dodged the attack.");
            }
        }
        public void TakeDamage(Character attacker)
        {
            DefensiveAbilities.Use(this, attacker);
            int damage = ComputeDamage(attacker);
            System.Console.WriteLine($"{attacker.name} attacked {this.name} for {damage} damage.");
            health.Query(-damage);
        }

        public bool isFaster(Character other)
        {
            if (this.speed > other.speed)
                return true;
            return false;
        }
        public bool isAlive()
        {
            if (health > 0)
                return true;
            return false;
        }
        public int ComputeDamage(Character attacker)
        {
            int damage = defense.ReduceDamage(attacker.strength);
            return damage;
        }
        public bool isLucky()
        {
            if (luck.isLucky())
                return true;
            return false;
        }
        public void loseHealth(int damage)
        {
            health.Query(-damage);
        }
        public void gainHealth(int hp)
        {
            health.Query(hp);
        }

        public string getName()
        {
            return name;
        }

        public int getHealth()
        {
            return health.getHealth();
        }
    }
}
