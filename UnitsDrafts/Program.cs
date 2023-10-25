//using UnitsDrafts;

//List<Unit> units = new List<Unit>();
//units.Add(new Footman());
//units.Add(new Peasant());
//units.Add(new Archer()); 
//units.Add(new Peasant());
//units.Add(new Archer());
//units.Add(new Footman());
//units.Add(new Footman());
//units.Add(new Archer());

//if (units.Exists(x => x.Name == "Footman"))
//{
//    var founded = units.Find(x => x.Name == "Footman");
//    var index = units.FindIndex(1 , 4 , x => x.Name == "Footman");
//    founded?.ShowInfo();
//    units[1].ShowInfo();
//}


//using UnitsDrafts;


//Footman f1 = new Footman(7, 10);
//Archer ar = new Archer(4, 5);
//Bishop bs = new Bishop(20);
//bs.ShowInfo();
//ar.ShowInfo();
//f1.ShowInfo();

//ar.TakeDamage(f1);
//f1.ShowInfo();


//bs.HealSomebody(f1);
//f1.ShowInfo();
//bs.ShowInfo();
//bs.HealSomebody(f1);
//f1.ShowInfo();
//bs.HealSomebody(f1);
//f1.ShowInfo();
//bs.ShowInfo();

using UnitsDrafts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Footman());
            units.Add(new Archer());
            Archer archer = new Archer();
            Footman footman = new Footman();

            if (units.Exists(x => x.Name == "Pudge"))
            {
                var a = units.Find(x => x.Name == "Pudge");

            }
            WatchingTower.WatchingTowerDamage(footman);
            footman.ShowInfo();
        }
    }
}













