namespace UnitsDrafts.items
{
    internal abstract class Weapon
    {
       protected Weapon(int minDamage, int maxdamage, int attackSpeed)
        {
            MinDamage = minDamage;
            MaxDamage = maxdamage;
            AttackSpeed = attackSpeed;
        }

        public int MinDamage { get; private set; }
        public int MaxDamage { get; set; } 
        public int AttackSpeed { get; set; }
        public abstract int Hit();
    }
}
