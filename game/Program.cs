using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game.Core;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Archer ar1 = new Archer(30);
            Pudge pudge = new Pudge(30,100);
            Peasent ps1 = new Peasent();
            Medic medic = new Medic();

            pudge.BaseInfo();
            ar1.TakeDamage(pudge);

            pudge.BaseInfo();
            ar1.TakeDamage(pudge);













        }
    }
}
