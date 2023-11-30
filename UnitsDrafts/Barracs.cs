namespace UnitsDrafts
{ 
        internal class Barracs
        {
        public delegate void CountDelegate(int count, string message);
        public Footman CreateFootman()
        {
            Random random = new Random();
            countEvent?.Invoke(Statistics.FootmansCount++, "footman");
            return new Footman(random.Next(10, 20), random.Next(2, 5));
        }
            public Archer CreateArcher()
            {
                countEvent?.Invoke(Statistics.ArchersCount++, "archer");
                return new Archer();
            }
            public event CountDelegate countEvent;
        }
}