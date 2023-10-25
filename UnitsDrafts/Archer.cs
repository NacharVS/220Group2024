namespace UnitsDrafts
{
    internal class Archer : Unit
    {

        public Archer(double damage) : base("Archer", 50, 50, 12)
        {
            Damage = damage;
        }
        public Archer() : base("Archer", 50, 50, 12)
        {
            Damage = 20;
        }


    }
}