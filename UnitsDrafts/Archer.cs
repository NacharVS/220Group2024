using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public Archer() : base("Archer", 40, 11, "Tower")
        {

        }

        public override void GoToService()
        {
            Console.WriteLine($"{Name} пошел на службу в {Service}");
        }
    }
}
