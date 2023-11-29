namespace UnitsDrafts
{
    internal class WatchingTower
    {
        List<Unit> UnitsInTower = new List<Unit>();
        int TowerArcherCount = 0;
        public void AddArcher(Archer archer)
        {
            if (UnitsInTower.Count < 3)
            {
                UnitsInTower.Add(archer);
                Statistics.ArchersCount++;
            }
            else
            {
                Console.WriteLine("Недостаточно места");
            }
        }

        public void ArcherList() 
        {
            foreach (var unit in UnitsInTower) { Console.WriteLine(unit.Name); }
        }
        public void UnitsCount()
        {
            Console.WriteLine($"В башне {UnitsInTower.Count}");
            Console.WriteLine($"Свободных мест {3 - UnitsInTower.Count}");
        }
    }
}