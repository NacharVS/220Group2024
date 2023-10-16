using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class House
    {
        private int health;
        private int level;
        private string name;
        private int width;
        private int lenght;

        public House(string name, int width, int length, int level, int health)
        {
            this.name = name;
            this.width = width;
            this.lenght = length;
            this.level = level;
            this.health = health;
        }
        public void BuildAuto()
        {

        }
    }
}
