namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        public delegate void InflictDamageDelegate(Unit unit);
        public InflictDamageDelegate infDamage;
        private int _damage;
        private int _defence;

        public override int Health
        {
            get => base.Health;
            set => base.Health = value;
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }


        public Footman(string name, int maxHealth, int speed, int damage, int defence)
            : base(name, maxHealth, speed)
        {
            _damage = damage;
            _defence = defence;
        }

        public Footman() : base("Footman", 60, 10)
        {
            _damage = 13;
            _defence = 2;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public void InflictDamage(Unit unit)
        {
            infDamage(unit);
         
        }

        public void Method1(Unit unit)
        {
            unit.Health = unit.Health - _damage;
            Console.WriteLine("Took damage");
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }

    }
}
