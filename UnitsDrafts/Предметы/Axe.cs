using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal abstract class Axe : Weapon
    {
        protected Axe(int minDamage, int maxDamage, int attackSpeed) : base(minDamage, maxDamage, attackSpeed)
        {

        }
    }
}
