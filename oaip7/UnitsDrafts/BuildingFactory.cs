namespace UnitsDrafts
{
    internal static class BuildingFactory
    {
        public static Barracs CreateBarracs()
        {
            return new Barracs();
        }

        public static Townhall CreateTownhall()
        {
            return new Townhall();
        }
        public static WatchingTower CreateWatchingTower()
        {
            return new WatchingTower();
        }
    }
}
