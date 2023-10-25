using System;
using System.Collections.Generic;
using System.Linq;
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
            Pudge pudge = new Pudge();

            if (units.Exists(x => x.Name == "Pudge"))
            {
                var a = units.Find(x => x.Name == "Pudge");
                
            }
            WatchingTower.WatchingTowerDamage(pudge);
            pudge.BaseInfo();
            













        }
    }
}