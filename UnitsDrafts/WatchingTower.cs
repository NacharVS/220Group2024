
namespace UnitsDrafts
{
    internal class WatchingTower
    {
        List<Unit> UnitsInTower = new List<Unit>();

        public Archer AddArcher()
        {
            if (UnitsInTower.Count < 3)
            {
                UnitsInTower.Add(new Archer());
                return new Archer();
                Statistics.ArchersCount++;
            }
            else
            {
                return null;
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
