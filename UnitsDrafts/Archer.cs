namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public Archer() : base("Archer", 40, 11)
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
