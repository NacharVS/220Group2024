namespace UnitsDrafts
{
    internal class Archer : Unit
    {

        public Archer() : base("Archer", 50, 50, "Tower")
        {
            
        }
        public override  void GoToService()
        {
            Console.WriteLine($"{Name} пошел на службу в {Service}");
        }

    }
}