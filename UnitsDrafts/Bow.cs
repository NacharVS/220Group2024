
using System;
using Работа;

namespace UnitsDrafts.items
{
    internal class Bow : Weapon
    {
        public Bow() : base(3, 12, 3)
        {
        }
        public void TakeDamage(Unit unit)
        {
            int CritChance = new Random().Next(1, 10);
            if (CritChance == 6)
            {
                unit.Health -= Hit() / 100 * 150;
                MinDamage += 4;
                MaxDamage += 1;
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
