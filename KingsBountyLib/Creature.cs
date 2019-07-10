namespace KingsBountyLib
{
    public class Creature
    {
        public int Attack { get; }
        public int Defence { get; }
        public int MinDamage { get; }
        public int MaxDamage { get; }

        public Creature(int attack, int defence, int minDamage, int maxDamage)
        {
            Attack = attack;
            Defence = defence;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public Damage PureDamage(Creature unit)
        {
            return new Damage(1, 2);
        }
    }
}