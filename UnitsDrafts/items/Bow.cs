using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.items
{
    internal class Bow : Weapon
    {
        public Bow(int minDamage, int maxDamage, int attackSpeed) : base(3, 12, 3)
        {

        }

        public override int Hit()
        {
            return 0;
        }
    }
}
