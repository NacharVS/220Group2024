

namespace UnitsDrafts.items
{
    internal class Staff : Weapon
    {
        public Staff() : base("staff", 1, 5, 4, 1, 5)
        {
        }
        public void Heal(Unit unit)
        {
            unit.Health += Hit();
        }

        public override int Hit()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }
    }
}
