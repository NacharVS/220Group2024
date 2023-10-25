using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Pudge : Unit
    {

        public Pudge(string name, int health, int maxHealth, double damage, double defence) : base("Pudge", 100, 100, 5)
        {
            Damage = damage;
            Defence = defence;
        }

        public Pudge() : base("Pudge", 50, 50, 8)
        {
            Damage = 15;
            Defence = 30;
        }



    }
}