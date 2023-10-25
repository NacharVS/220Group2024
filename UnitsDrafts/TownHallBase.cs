using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class TownHallBase
    {
        private string _name;
        private double _health;
        public TownHallBase(string name, double health)
        {
            _name = name;
            _health = health;
        }
    }
}
