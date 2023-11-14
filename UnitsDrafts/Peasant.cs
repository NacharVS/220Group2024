using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа
{
    internal class Peasant : Unit
    {
        public Peasant() : base("Peasant", 30, 5, "Field")
        {
        }
        public override void BaseInfo(Unit unit)
        {
            base.BaseInfo(unit);
        }
    }
}
