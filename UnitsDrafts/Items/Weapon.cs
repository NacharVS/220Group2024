
namespace UnitsDrafts.items
{
    internal abstract class Weapon
    {


        protected Weapon(string name, int minDamage, int maxDamage, int attackSpeed, int level, int maxLevel)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Level = level;
            MaxLevel = maxLevel;
        }
        public string Name {  get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int AttackSpeed { get; set; }

        public int Level { get; set; }
        
        public int MaxLevel { get; set; }
        public abstract int Hit();
        public virtual void ShowWeaponInfo()
        {
            Console.WriteLine($"MinDamage = {MinDamage}, MaxDamage = {MaxDamage}, AttackSpeed = {AttackSpeed}, Level = {Level}");
        }

    }
}
