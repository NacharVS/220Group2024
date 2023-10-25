namespace UnitsDrafts
{
    internal class Unit
    {
        private readonly string _name;
        private int _health;
        public int _maxHealth;
        private int _speed;
        private int _defense;
        private int _damage;
        public string Name => _name;
        private bool _alive = true;

        public Unit(string name, int health, int maxHealth, int damage, int speed, int defense, bool _alive = true)
        {
            _name = name;
            _health = health;
            _maxHealth = maxHealth;
            _speed = speed;
            _defense = defense;
            _damage = damage;
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }


        public virtual int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value;
            }
        }
        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        public void Moving()
        {
            if (_alive)
            {
                Console.WriteLine($"{_name} is moving with {_speed} speed");
            }
        }

        public virtual void BaseInfo()
        {
            Console.WriteLine($"Name:{_name} CurrentHealth: {Health}");
            if (this.Health <= 0)
            {
                Alive = false;
                Console.WriteLine($"{this.Name} dead!");
            }
        }
        public void rage(Unit ft)
        {
            if (_alive)
            {
                Console.WriteLine($"{ft.Name} in rage!");
                int dmgup = ft.Damage / 2;
                ft.Damage = ft.Damage + dmgup;

            }
        }

    }
}
