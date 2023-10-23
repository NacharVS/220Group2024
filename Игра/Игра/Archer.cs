using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Core
{
    internal class Archer : Unit
    {

        public Archer(double damage) : base("Archer", 50, 50, 12)
        {
            Damage = damage;
        }



    }
}