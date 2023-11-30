using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
{
    internal class Axe : Weapon
    {
        public Axe() : base(3, 10, 6)
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