namespace UnitsDrafts
{
    internal class BuildingFactory
    {
        public BuildingFactory(string name, double health)
        {
        }

        public static void CreateBarracs()
        {
            Barracs barracs = new Barracs();
            Console.WriteLine("Казарма создана");
        }

        public static void CreateTownHall() 
        {
            Townhall th = new Townhall();
            Console.WriteLine("Ратуша создана");
        }

        public static void CreateWatchingTower() 
        {
            WatchingTower wt = new WatchingTower();
            Console.WriteLine("Смотровая башня создана");
        }
    }
}
