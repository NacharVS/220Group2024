using static UnitsDrafts.Footman;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        public delegate void InflictDamageDelegate(Unit unit);
        public InflictDamageDelegate infDamage;
        private double _damage;
        private double _defence;
        private double _health;


        public Footman(string name, int health, int maxHealth, int speed, int damage, int defence) : base(name, health, maxHealth, defence)
        {
            _damage = damage;
            _defence = defence;
            _health = health;
        }

        public Footman() : base("Footman", 60, 60, 20)
        {
            Damage = 15;
            Defence = 30;
        }
        public void InflictDamage(Unit unit)
        {
            infDamage(unit);
        }
    }
}
