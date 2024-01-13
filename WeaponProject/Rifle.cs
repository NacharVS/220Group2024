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

        public int CritDamage => new Random().Next(13, 16);

        public void Shoot()
        {
            Console.WriteLine($"bum-bum! dealed {new Random().Next(MinDamage, MaxDamage)} of damage");
        }

        public void UpgradeWeapon(IWeapon weapon)
        {
            throw new NotImplementedException();
        }
    }
}
