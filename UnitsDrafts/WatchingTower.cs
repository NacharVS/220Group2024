using UnitsDrafts;

namespace UnitsDrafts
{
    internal class WatchingTower : WatchingTowerBase
    {
        private static int TowerDamage = 0;
        Random random = new Random();
        public WatchingTower() : base("WatchingTower", 50)
        {

        }

        public static void WatchingTowerDamage(Unit unit)
        {
            int Count = 0;
            Console.WriteLine("Введите количество лучников на башне");
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
                    for (Count = Archers; archers.Count > 0; Count--)
                    {
                        TowerDamage += (int)archer.Damage;

                    }
                    unit.Health -= TowerDamage;
                    Console.WriteLine($"Башня нанесла {unit.Name} {TowerDamage} урона");
                }
            }
        }
    }
}