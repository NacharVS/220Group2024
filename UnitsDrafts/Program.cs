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
Bishop bishop = new Bishop();

ft1.infDamage = Method1;
ft1.infDamage += Method2;
ft1.infDamage += bishop.Healing;
ft1.InflictDamage(ft2);

static void Method1(Unit unit)
{
    Console.WriteLine($"{unit.Name} took headshot");
}

static void Method2(Unit unit)
{
    if (unit.Health < unit._maxHealth / 2)
        Console.WriteLine($"{unit.Name} took armBraker");
}
