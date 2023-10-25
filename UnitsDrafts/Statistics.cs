namespace UnitsDrafts
{
    internal static class Statistics
    {
        public static int PudgeCount { get; set; } = 0;
        public static int ArchersCount { get; set; } = 0;

        public static void ShowStatistics()
        {
            Console.WriteLine($"{PudgeCount} {ArchersCount}");
        }
    }
}
