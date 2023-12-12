using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject
{
    internal interface IWeapon
    {
        public int MinDamage { get; }
        public int MaxDamage { get; }

        public void Shoot();
    }
}
