using Hero.Characters;
using Hero.Stats;
using System;
using System.Collections.Generic;
namespace Hero
{
    class Battle
    {
        private Character attacker;
        private Character defender;
        public Battle(Character attacker, Character defender)
        {

            int timer = 0;
            if (defender.isFaster(attacker))
            {
                this.attacker = defender;
                this.defender = attacker;
            }
            else
            {
                this.attacker = attacker;
                this.defender = defender;
            }

            while (attacker.isAlive() && defender.isAlive() && timer < 20)
            {
                System.Console.WriteLine("Round " + timer + ":");
                timer++;
                attacker.Attack(defender);

                System.Console.WriteLine(attacker.getName() + " has " + attacker.getHealth() + " health left");
                System.Console.WriteLine(defender.getName() + " has " + defender.getHealth() + " health left\n");

                (attacker, defender) = (defender, attacker);
            }
            if (attacker.isAlive())
                System.Console.WriteLine(attacker.getName() + " won the battle");
            else if (defender.isAlive())
                System.Console.WriteLine(defender.getName() + " won the battle");
            else
                System.Console.WriteLine("It's a draw, the timer ran out");
        }
    }

    public class Program
    {
        public static int Main(string[] args)
        {

            Ordeus ordeus = new Ordeus("Ordeus", new Health(70, 100), new Speed(40, 50), new Strength(70, 80), new Luck(10, 30), new Defense(45, 55), new OffensiveAbilities(new List<Abilities> { new RapidStrikes() }), new DefensiveAbilities(new List<Abilities> { new MagicShield() }));
            Beast beast = new Beast("Beast", new Health(60, 90), new Speed(40, 60), new Strength(60, 90), new Luck(25, 40), new Defense(40, 60), new OffensiveAbilities(), new DefensiveAbilities());

            Battle battle = new Battle(ordeus, beast);

            Console.ReadLine();
            Console.Read();
            Console.ReadKey();
            return 0;
        }
    }
}