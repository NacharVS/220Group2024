using UnitsDrafts.Items;

namespace UnitsDrafts
{
    internal class Barracs
    {
        public delegate void StatisticsDelegate(int count);
        public Footman CreateFootman()
        {
            Random random = new Random();
            Statistics.FootmansCount++;
            StatisticsFootmanEvent?.Invoke(Statistics.FootmansCount);
            return new Footman("Name", random.Next(50, 60), random.Next(5, 10), random.Next(5, 15), random.Next(1, 4));
        }

        public Archer CreateArcher()
        {
            Statistics.ArchersCount++;
            StatisticsArcherEvent?.Invoke(Statistics.ArchersCount);
            return new Archer();
        }

        public event StatisticsDelegate StatisticsArcherEvent; 
        public event StatisticsDelegate StatisticsFootmanEvent;
    }
}
