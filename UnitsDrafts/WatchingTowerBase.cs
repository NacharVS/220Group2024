using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class WatchingTowerBase
    {
        private string _name;
        private double _health;
        public WatchingTowerBase(string name, double health)
        {
            _name = name;
            _health = health;
        }
    }
}
