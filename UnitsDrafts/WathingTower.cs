namespace UnitsDrafts
{
    internal class WathingTower
    {
        List<Unit> archers = new List<Unit>();
        public WathingTower()
        {
   
        }

        public void AddArcher(Archer archer)
        {
            if(archers.Count > 3)
                Console.WriteLine("Overflow");
            else
                archers.Add(archer);
        }

    }

    
}
