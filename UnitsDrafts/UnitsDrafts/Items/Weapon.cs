
namespace UnitsDrafts.Items
{
    internal abstract class Weapon
    {
        public Weapon(int minDamage, int maxDamage, int attackSpeed)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
        }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int AttackSpeed { get; set; }

        public abstract int Hit();
    }

}
