namespace UnitsDrafts
{
    internal class Barracs
    {
        internal class Barracs
        {
            Random random = new Random();
            public Pudge CreatePudge()
            {

                Statistics.PudgeCount++;
                return new Pudge("Name", random.Next(50, 60), random.Next(5, 10), random.Next(10, 20), random.Next(10, 30));
            }

            public Archer CreateArcher()
            {
                Statistics.ArchersCount++;
                return new Archer(random.Next(15, 30));
            }
        }
    }
}