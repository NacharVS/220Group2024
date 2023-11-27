using UnitsDrafts;
//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<Unit> units = new List<Unit>();
//        units.Add(new Pudge());
//        units.Add(new Archer());
//        Archer archer = new Archer();
//        WatchingTower tower1 = new WatchingTower();
//        Pudge pudge = new Pudge();

//        if (units.Exists(x => x.Name == "Pudge"))
//        {
//            var a = units.Find(x => x.Name == "Pudge");

//        }
//        tower1.WatchingTowerDamage(pudge);
//        pudge.BaseInfo();
//    }
//}
Footman ft1 = new Footman();
Footman ft2 = new Footman();
//Bishop bishop = new Bishop();

//ft1.infDamage = Method1;
//ft1.infDamage += Method2;
//ft1.infDamage += bishop.Healing;
ft1.InflictDamage(ft2);

//static void Method1(Unit unit)
//{
//    Console.WriteLine($"{unit.Name} took headshot");
//}

//static void Method2(Unit unit)
//{
//    if (unit.Health < unit.MaxHealth / 2)
//        Console.WriteLine($"{unit.Name} took armBraker");
//}

ft2.action = () => Console.WriteLine("Invoked action delegate!");

ft2.HealthDecreasedEvent += (Unit sender, UnitEventArg e) =>
{
    Console.WriteLine($"{sender.Name} {e.Message} {e.HealthDifferce} current health: {sender.Health}");
};

ft2.HealthIncreasedEvent += (Unit sender, UnitEventArg e) =>
{
    Console.WriteLine($"{sender.Name} {e.Message} {e.HealthDifferce}");
};
ft1.infDamage = (Unit unit) =>
{
    unit.Health -= 10;
    unit.Health -= 10;
    unit.Health -= 10;
};

