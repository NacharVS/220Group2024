using System;

namespace NewProlect;

public class Rifle : IWeapon , IBurstShoot
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

    public void BurstShoot()
    {
        throw new NotImplementedException();
    }
}