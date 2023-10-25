namespace UnitsDrafts
{
    internal static class BuildingFactory
    {
        public BuildingFactory() { }
        public WatchingTower BuildTower(List<Archer> Units, int Level)
        {
            return new WatchingTower(Units, Level);
        }
        public TownHall BuildTH()
        {
            return new TownHall();
        }
    }
}
