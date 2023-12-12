using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject
{
    internal class Machinegun
    {
        public int MinDamage => 3;

        public int MaxDamage => 9;

        public void BurstShoot()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"piu! dealed {new Random().Next(MinDamage, MaxDamage)} of damage");
            }
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
