using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft2 = new Footman();
Bishop bishop = new Bishop();   

ft1.infDamage = Method1;
ft1.infDamage += Method2;
ft1.infDamage += bishop.HealSomebody;
ft1.InflictDamage(ft2);

static void Method1(Unit unit)
{
    Console.WriteLine($"{unit.Name} took headshot");
}

static void Method2(Unit unit)
{
    if(unit.Health < unit.MaxHealth / 2)
        Console.WriteLine($"{unit.Name} took armBraker");
}










