using UnitsDrafts;

Footman ft1 = new Footman();
int a = 0;
int b = 1;
var gg = (name: "Tom", age:55);

Console.WriteLine(gg);

Console.WriteLine($"a - {a} b - {b}");

static ((int,int), string) Method33()
{
    return ((4, 6), "qq");
}

static void WeaponInfo(WeaponDamage weapon)
{
    switch (weapon)
    {
        case WeaponDamage.Lance: Console.WriteLine($"{WeaponDamage.Lance} - {(int)WeaponDamage.Lance}");
            break;
        case WeaponDamage.LongSword: Console.WriteLine($"{WeaponDamage.LongSword} - {(int)WeaponDamage.LongSword}");
            break;
            default: Console.WriteLine("OtherWeapon");
            break;

    }
}




enum WeaponDamage
{
    LongSword = 10,
    ShortSword = 7,
    SmallAxe = 8,
    TwoHandedAxe = 15,
    Spear = 6,
    Lance = 22,
    ShortBow,
    LongWarBow
}














