using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject
{
    internal class Pistol
    {
        public int MinDamage => 2;
        public int MaxDamage => 7;

        public void Shoot()
        {
            Console.WriteLine($"bum-bum! dealed {new Random().Next(MinDamage, MaxDamage)} of damage");
        }

    }
}
