namespace UnitsDrafts
{
    internal static class BuildingFactory
    {
        public static Barracs CreateBarracs()
        {
            return new Barracs();
        }

        public static Tower CreateTower()
        {
            return new Tower();
        }
    }
}
