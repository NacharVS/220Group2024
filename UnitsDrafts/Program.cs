using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft2 = new Footman();
ft2.action = () => Console.WriteLine("Invoked action delegate!");

ft2.HealthDecreasedEvent += (int health, int diff) =>
{
    Console.WriteLine($"Unit tooks {diff} damage, current health {health}");
};

ft2.HealthIncreasedEvent += (int health, int diff) =>
{
    Console.WriteLine($"Unit tooks {diff} healing, current health {health}");
};

ft1.infDamage = (Unit unit) =>
{
    unit.Health -= 10;
    unit.Health -= 10;
    unit.Health -= 10;
};
ft1.InflictDamage(ft2);


Footman ft3 = new Footman();
ft3.InDelegate = (speed) =>
{
    Console.WriteLine(speed);
};
ft3.InnerDelegateVoid();

Barracs barrac = new Barracs();
barrac.StatisticsArcherEvent += (int count) =>
{
    Console.WriteLine($"{count} Archers in Barrac");
};

barrac.StatisticsFootmanEvent += (int count) =>
{
    Console.WriteLine($"{count} Footmans in Barrac");
};
barrac.CreateArcher();
barrac.CreateFootman();

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
