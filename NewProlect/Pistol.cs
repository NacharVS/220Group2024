using System;

namespace NewProlect
{
    public class Pistol : Weapon, IWeapon
    {
        public int MinDamage => 2; 
        public int MaxDamage => 7; 

        public void Shoot()
        {
            Console.WriteLine($"piu-piu! dealed {new Random().Next(MinDamage, MaxDamage)} of damage");
        }
    }
}