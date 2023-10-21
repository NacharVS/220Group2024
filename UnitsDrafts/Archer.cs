using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        private double _damage;
        private double _defence;

        public Archer(double damage, double defence) : base("Archer", 40, 11, 4)
        {
            _defence = defence;
            _damage = damage;
        }
        public double Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        
        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }
    }
}
