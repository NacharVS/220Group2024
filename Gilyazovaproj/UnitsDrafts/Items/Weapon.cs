using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
{
    internal abstract class Weapon
    {
        protected Weapon(int minDamage, int maxDamage, int attackSpeed)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
        }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int AttackSpeed { get; set; }

        public abstract int Hit();


    }
}
