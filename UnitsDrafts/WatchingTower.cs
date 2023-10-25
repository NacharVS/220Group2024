using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class WatchingTower : WatchingTowerBase
    {
        private int TowerDamage = 0;
        Random random = new Random();
        public WatchingTower() : base("WatchingTower", 50)
        {
        }

        public void WatchingTowerDamage(Unit unit)
        {

            Console.WriteLine("Введите количество лучников на башне:");
            int Archers = Convert.ToInt32(Console.ReadLine());
            List<Archer> archers = new List<Archer>(3);
            if (Archers == 2)
            {
                archers.Add(new Archer());
                archers.Add(new Archer());

            }
            if (Archers == 3)
            {
                archers.Add(new Archer());
                archers.Add(new Archer());
                archers.Add(new Archer());

            }
            else if (Archers == 1)
            {
                archers.Add(new Archer());

            }
            else if (Archers > 3)
            {
                Console.WriteLine("Башня расчитана только на 3 лучников, введите меньшее количество");

            }




            if (archers.Exists(x => x.Name == "Archer"))
            {
                foreach (var archer in archers)
                {
                    unit.Health -= archer.Damage;
                    Console.WriteLine($"Башня нанесла {unit.Name} {archer.Damage} урона");


                }

            }
        }
    }
}
