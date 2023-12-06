using UnitsDrafts;




    static void WeaponInfo(WeaponDamage weapon)
    {
        switch (weapon)
        {
            case WeaponDamage.Spear:
                Console.WriteLine($"{WeaponDamage.Spear} - {(int)WeaponDamage.Spear}");
                break;
            case WeaponDamage.LongWarBow:
                Console.WriteLine($"{WeaponDamage.LongWarBow} - {(int)WeaponDamage.LongWarBow}");
                break;
            default:
                Console.WriteLine("OtherWeapon");
                break;

        }
    }

    enum WeaponDamage
    {
        LongSword = 5,
        ShortSword = 45,
        SmallAxe = 12,
        TwoHandedAxe = 66,
        Spear = 41,
        Lanse = 22,
        ShortBow = 12,
        LongWarBow = 33,
    }

