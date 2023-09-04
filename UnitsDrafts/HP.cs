namespace UnitsDrafts
{
    class HP
    {
        static void Main(string[] args)
        {
            Cleric cleric = new Cleric(30, 20);
            Archer archer = new Archer();

            Unit[] units = new Unit[] { cleric, archer };

            int[] healthValues = new int[units.Length];

            for (int i = 0; i < units.Length; i++)
            {
                healthValues[i] = units[i].Health;
            }

            Array.Sort(healthValues);

            Console.WriteLine("Health values in ascending order:");
            foreach (int value in healthValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
