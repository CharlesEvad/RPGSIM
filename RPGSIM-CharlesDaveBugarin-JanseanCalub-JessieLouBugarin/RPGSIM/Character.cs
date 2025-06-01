using System;

namespace RPGSIM
{
    public enum CharacterClass
    {
        Fighter,
        Marksman,
        Assassin,
        Wizard
    }

    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public CharacterClass ClassType { get; protected set; }

        protected static Random rng = new Random();

        public Character(string name, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;
        }

        public abstract int Attack(Character opponent);

        protected bool HasAdvantage(CharacterClass attacker, CharacterClass defender)
        {
            return (attacker == CharacterClass.Fighter && defender == CharacterClass.Assassin)
                || (attacker == CharacterClass.Marksman && defender == CharacterClass.Fighter)
                || (attacker == CharacterClass.Assassin && defender == CharacterClass.Marksman)
                || (attacker == CharacterClass.Wizard && defender == CharacterClass.Marksman);
        }
    }

    public class Charles_Fighter : Character
    {
        public Charles_Fighter(string name) : base(name, 120)
        {
            ClassType = CharacterClass.Fighter;
        }

        public override int Attack(Character opponent)
        {
            int damage = rng.Next(10, 22);
            if (HasAdvantage(ClassType, opponent.ClassType))
                damage = (int)(damage * 1.25);
            return damage;
        }
    }

    public class Jansean_Marksman : Character
    {
        public Jansean_Marksman(string name) : base(name, 90)
        {
            ClassType = CharacterClass.Marksman;
        }

        public override int Attack(Character opponent)
        {
            int damage = rng.Next(12, 20);
            if (HasAdvantage(ClassType, opponent.ClassType))
                damage = (int)(damage * 1.25);
            return damage;
        }
    }

    public class JessieLou_Assassin : Character
    {
        public JessieLou_Assassin(string name) : base(name, 80)
        {
            ClassType = CharacterClass.Assassin;
        }

        public override int Attack(Character opponent)
        {
            int damage = rng.Next(14, 24);
            if (HasAdvantage(ClassType, opponent.ClassType))
                damage = (int)(damage * 1.25);
            return damage;
        }
    }
    public class Dex_Wizard : Character
    {
        public Dex_Wizard(string name) : base(name, 80)
        {
            ClassType = CharacterClass.Wizard;
        }

        public override int Attack(Character opponent)
        {
            int damage = rng.Next(15, 25);
            if (HasAdvantage(ClassType, opponent.ClassType))
                damage = (int)(damage * 1.25);
            return damage;
        }
    }
}