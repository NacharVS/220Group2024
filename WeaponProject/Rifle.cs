using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject
{
    internal class Rifle : IWeapon, IBurstShoot
    {
        public int MinDamage => 7;
        public int MaxDamage => 12;

        public void Shoot()
        {
            Console.WriteLine($"bum-bum! dealed {new Random().Next(MinDamage, MaxDamage)} of damage");
        }

    }
}
