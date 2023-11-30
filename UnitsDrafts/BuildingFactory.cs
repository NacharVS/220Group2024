namespace UnitsDrafts
{
    internal class BuildingFactory
    {
        public static Barracs CreateBarracs()
        {
            return new Barracs();
        }
         public static TownHall CreateTownHall()
         {
            return new TownHall();
         }
        public static WatchingTower CreateWatchingTower()
        {
            return new WatchingTower();
        }

    }
}
