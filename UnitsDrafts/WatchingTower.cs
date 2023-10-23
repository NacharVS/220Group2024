using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class WatchingTower
    {
        List<Unit> UnitsInTower = new List<Unit>();
        public Archer AddArcher()
        {
            UnitsInTower.Add(new Archer());
            return new Archer();
        }
    }
}
