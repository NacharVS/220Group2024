using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class BuildingFactory
    {
        public BuildingFactory() { }
        public WatchingTower BuildTower(List<Archer> Units, int Level)
        {
            return new WatchingTower(Units, Level);
        }
        public TownHall BuildTH()
        {
            return new TownHall();
        }
    }
}
