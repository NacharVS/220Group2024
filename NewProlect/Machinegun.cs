using System;

namespace NewProlect
{
    public class Machinegun : Weapon , IBurstShoot
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