using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal abstract class Weapon
    {
        public int MinDamage { get; set; } 
        public int MaxDamage { get; set; }
        public int AttackSpeed { get; set; }
        //public abstract int Hit()
        //{
          //  return 0;
        //}
    }
}
