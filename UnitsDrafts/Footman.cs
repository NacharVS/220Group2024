using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;
        public Footman(string name, int health, int maxHealth, int damage, int speed, int defense, bool _alive = true) : base("Footman", 60, 60, 10, 9, 7, true)
        {
            _damage = damage;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public void InflictDamage(Unit unit)
        {
            if (Alive == true)
            {
                unit.Health -= (Damage - unit.Defense);
            }
        }
        public override void BaseInfo()
        {
            if (Alive == true)
            {
                double ragehealth = this._maxHealth * 0.4;
                if (this.Health < ragehealth)
                {
                    rage(this);
                }
                Console.WriteLine($"Name:{Name} CurrentHealth: {Health}/{_maxHealth} Damage: {Damage} Defense: {Defense}");
            }
        }

    }
}
