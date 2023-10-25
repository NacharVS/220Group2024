using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
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