using UnitsDrafts;
Footman ft1 = new Footman();
Footman ft2 = new Footman();
Bishop bish1 = new Bishop();
ft2.action = () =>
    Console.WriteLine("fff");

ft1.infDamage = (Unit unit) => 
{
    unit.Health -= 10;
    unit.ShowInfo();
};

ft1.infDamage(ft2);




ft1.infDamage = ft1.Method1;
ft1.InflictDamage(bish1);

bish1.HealDelegate = bish1.HealMethod1;
bish1.HealSomebody(ft1);

//static void Method1(Unit unit)
//{
//    Console.WriteLine($"{unit.Name} took headshot");
//}

//static void Method2(Unit unit)
//{
//    if (unit.Health < unit.MaxHealth / 2)
//        Console.WriteLine($"{unit.Name} took armBraker");
//}



















