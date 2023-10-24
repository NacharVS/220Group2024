namespace UnitsDrafts
{
    internal static class BuildingFactory
    {
        public static Barracs CreateBarracs()
        {
            return new Barracs();
        }

        public static WathingTower CreateTowers()
        {
            return new WathingTower();
        }
    }
}
