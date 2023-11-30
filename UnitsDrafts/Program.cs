using UnitsDrafts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game;

Footman ft1 = new Footman(); Footman ft2 = new Footman();
Bishop bishop = new Bishop();
ft1.infDamage = Method1; ft1.infDamage = Method2;
ft1.infDamage += bishop.HealSomebody; ft1.InflictDamage(ft2);
static void Method1(Unit unit)
{
    Console.WriteLine($"{unit.Name} took headshot");
}
static void Method2(Unit unit)
{
    if (unit.Health < unit.MaxHealth / 2) Console.WriteLine($"{unit.Name} took armBraker");
}
//namespace game
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Unit> units = new List<Unit>();
//            units.Add(new Footman());
//            units.Add(new Archer());
//            Archer archer = new Archer();
//            Footman footman = new Footman();
//            Archer ar = new Archer();
//            Footman f1 = new Footman();
//            Bishop bs = new Bishop(20);
//            WatchingTower wt = new WatchingTower();

//            if (units.Exists(x => x.Name == "Pudge"))
//            {
//                var a = units.Find(x => x.Name == "Pudge");

//            }


            


//            Townhall.TownHallDamage(footman);
//            footman.ShowInfo();

//            WatchingTower.WatchingTowerDamage(footman);



//            //bs.ShowInfo();
//            //ar.ShowInfo();
//            //f1.ShowInfo();

//            //ar.TakeDamage(f1);
//            //f1.ShowInfo();


//            //bs.HealSomebody(f1);
//            //f1.ShowInfo();
//            //bs.ShowInfo();
//            //bs.HealSomebody(f1);
//            //f1.ShowInfo();
//            //bs.HealSomebody(f1);
//            //f1.ShowInfo();
//            //bs.ShowInfo();

//        }
//    }
//}













