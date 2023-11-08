namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public Archer() : base("Archer", 40, 40, 15, 10, 3)
        {
        }
        public void InflictDamage(Unit unit)
        {
            if (Alive)
            {
                unit.Health -= (Damage - unit.Defense);
            }
        }
    }
}
