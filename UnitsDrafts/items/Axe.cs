

namespace UnitsDrafts.items
{
    internal class Axe : Weapon
    {
        public Axe() : base("axe", 2, 9, 5, 1, 5) 
        {

        }
        public void TakeDamage(Unit unit)
        {
            int CritChance = new Random().Next(1, 100);
            if (CritChance <= 20)
            {
                unit.Health -= 3 * Hit();
            }
            else
            {
                unit.Health -= Hit();
            }
        }

        public override int Hit()
        {
             return new Random().Next(MinDamage, MaxDamage);
        }
    }
}
