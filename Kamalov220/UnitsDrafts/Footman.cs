using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;
        private int _maxdamage;
        private int _defence = 5;

        public Footman(int damage) : base("Footman", 60, 60, 9)
        {
            _damage = damage;
            _maxdamage = damage;
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public override int Health { 
            get => base.Health;
            set {
                if (HealthI != 0)
                {
                    Random random = new Random();
                    base.Health = value + random.Next(0, _defence);
                    if (base.Health > base.MaxHealth) base.Health = base.MaxHealth;
                    Rage();
                    if (base.Health == 0) Console.WriteLine($"Name: {Name} Dead");
                }
                else { Console.WriteLine($"Name: {Name} Died and there is no point in inflicting damage on him"); }
            }
        }

        public void Rage()
        {
            if(HealthI < MaxHealth*0.4 && _maxdamage == _damage)
            {
                _damage = Convert.ToInt32(_damage*1.5);
                Console.WriteLine($"Name: {Name} Health is less than 40%, damage increased by 50% and amounted to {_damage}");
            }
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} CurrentHealth: {HealthI} Damage: {_damage} Defence: {_defence}");
        }
    }
}
