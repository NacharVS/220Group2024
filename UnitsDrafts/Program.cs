﻿using UnitsDrafts;

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
            Archer ar = new Archer();
            Footman f1 = new Footman();
            Bishop bs = new Bishop(20);

            if (units.Exists(x => x.Name == "Pudge"))
            {
                var a = units.Find(x => x.Name == "Pudge");

            }


            //WatchingTower.WatchingTowerDamage(footman);
            //footman.ShowInfo();


            Townhall.TownHallDamage(footman);
            footman.ShowInfo();



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

        }
    }
}













