using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Предметы
{
    internal class Bow : Weapon
    {
        protected Bow(int minDamage, int maxDamage, int attackSpeed) : base(minDamage, maxDamage, attackSpeed)
        {

        }
        public override int Hit()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }
    }
}
