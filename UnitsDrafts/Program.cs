using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft2 = new Footman();
ft2.action = () => Console.WriteLine("Invoked action delegate!");

ft2.HealthDecreasedEvent += (int health, int diff) =>
{
    Console.WriteLine($"Unit took {diff} damage, current health {health}");
};

ft2.HealthIncreasedEvent += (int health, int diff) =>
{
    Console.WriteLine($"Unit took {diff} healing, current health {health}");
};
ft1.infDamage = (Unit unit) =>
{
    unit.Health -= 10;
    unit.Health -= 10;
    unit.Health -= 10;
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










