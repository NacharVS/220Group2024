using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Работа;

namespace UnitsDrafts
{
    internal class WatchingTower
    {
        List<Unit> ArchersInTower = new List<Unit>();
        int TowerArcherCount = 0;
        public void AddArcher(Archer archer)
        {
            if (ArchersInTower.Count <= 3)
            {
                ArchersInTower.Add(archer);
                Statistics.ArchersCount++;
            }
            else
            {
                Console.WriteLine("Башня заполнена");
            }
        }

        public void ArcherListName()
        {
            foreach (var archer in ArchersInTower)
                Console.WriteLine(archer.Name);
        }
        public void UnitsCount()
        {
            Console.WriteLine($"В башне {ArchersInTower.Count} лучников");
            Console.WriteLine($"Свободных мест {3 - ArchersInTower.Count}");
        }
    }
}
