using System;
using Работа;

namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman CreateFootman()
        {
            Random random = new Random();
            Statistics.FootmansCount++;
            return new Footman(random.Next(5, 15), random.Next(1, 4));
        }

        public Archer CreateArcher()
        {
            Statistics.ArchersCount++;
            return new Archer();
        }
    }
}