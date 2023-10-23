using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        private double _damage;
        private double _defence;

        public Archer(double damage, double defence) : base("Archer", 40, 40, 10)
        {
            _defence = defence;
            _damage = damage;
        }
        new public double Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        new public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public void ArcherDamage(Unit unit)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Archer ударил {unit.Name} и снёс {this.Damage}");
            Console.WriteLine("-------------------------------");
            unit.Health = unit.Health - _damage;
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }
    }
}
