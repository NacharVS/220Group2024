using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;

        public Footman(int damage, int defense) : base("Footman", 60, 60, 9, 7)
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
            unit.Health -= (_damage - unit.Defense);
           
        }
        public override void BaseInfo()
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
