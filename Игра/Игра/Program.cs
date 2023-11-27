using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using game.Core;
using Игра;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Pudge());
            units.Add(new Archer());
            Archer archer = new Archer();
            WatchingTower tower1 = new WatchingTower();
            Pudge pudge = new Pudge();
            Barracs barracs = BuildingFactory.CreateBarracs();
            barracs.CreateArcher();
            


            if (units.Exists(x => x.Name == "Pudge"))
            {
                var a = units.Find(x => x.Name == "Pudge");
                
            }
            tower1.WatchingTowerDamage(pudge);
            pudge.BaseInfo();

            Pudge pudge1 = new Pudge();
        }
    }
}