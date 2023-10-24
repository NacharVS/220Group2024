namespace UnitsDrafts.items
{
    internal class Axe : Weapon
    {
        public Axe(int minDamage, int maxDamage, int attackSpeed) : base(minDamage, maxDamage, attackSpeed) 
        {
        } 
        public override int Hit()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }

    }
}
