

using System;
using UnitsDrafts;

namespace UnitsDrafts.items
{
    internal class Axe : Weapon
    {
        public Axe() : base(2, 9, 5)
        {

        }
        public void TakeDamage(Unit unit)
        {
            int CritChance = new Random().Next(1, 10);
            if (CritChance == 2)
            {
                unit.Health -= Hit() / 100 * 300;
                MinDamage += 2;
                MaxDamage += 2;
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
