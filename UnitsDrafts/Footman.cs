namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private double _damage;
        private double _defence;
        private double _health;
        //private Weapon _weapon;

        public override double Health 
        { 
            get => base.Health; 
            set => base.Health = value; 
        }
        //new public double Defence
        //{
        //    get { return _defence; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _defence = 0;
        //        }
        //        else
        //            _defence = value;
        //    }
        //}


        public Footman(string name, int health, int maxHealth, int speed, int damage, int defence) : base(name, health, maxHealth, defence)
        {
            _damage = damage;
            _defence = defence;
            _health = health;
        }

        public Footman(double defence, double damage) : base("Footman", 60, 60, 20)
        {
            _damage = damage;
            _defence = defence;
        }

        new public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public void FootmanDamage(Unit unit)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Footman ударил {unit.Name} и снёс {this.Damage}");
            Console.WriteLine("-------------------------------");
            unit.Health = unit.Health - _damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }
        
    }
}
