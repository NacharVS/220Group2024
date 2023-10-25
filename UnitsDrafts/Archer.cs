using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public Archer(double damage, double defence) : base("Archer", 40, 40, 10)
        {
            Defence = defence;
            Damage = damage;
        }
        public Archer() : base("Archer", 40, 40, 10)
        {
            Damage = 10;
            Defence = 15;
        }
    }
}
