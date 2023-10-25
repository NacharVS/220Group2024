using System;

namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman CreateFootman()
        {
            Random random = new Random();
            Statistics.FootmansCount++;
            return new Footman("Name", random.Next(50, 60), random.Next(5, 10), random.Next(5, 15), random.Next(10, 20), random.Next(10, 30));
        }

        public Archer CreateArcher()
        {
            Random random = new Random();
            Statistics.ArchersCount++;
            return new Archer(random.Next(5, 10), random.Next(5, 15));
        }
    }
}
