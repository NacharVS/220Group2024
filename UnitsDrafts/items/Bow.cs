
namespace UnitsDrafts.items
{
    internal class Bow : Weapon
    {
        public Bow() : base(3, 12, 3)
        {
        }
        public void TakeDamage(Unit unit)
        {
            int CritChance = new Random().Next(1,100) ;
            if(CritChance <= 60) 
            {
                unit.Health -= Convert.ToInt32(1.5 * Hit());
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
