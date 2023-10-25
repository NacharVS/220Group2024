

namespace UnitsDrafts.items
{
    internal class Staff : Weapon
    {
        public Staff() : base(1, 5, 4)
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
