using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft2 = new Footman();
ft2.action = () => Console.WriteLine("Invoked action delegate!");

ft1.infDamage = (Unit unit) =>
{
    unit.Health -= 10;
    unit.ShowInfo();
};
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










