namespace UnitsDrafts
{
    internal class Unit
    {
        private readonly string _name;
        private int _health;
        private int _maxHealth;
        private int _speed;

        public string Name => _name;
        public int HealthI => _health;

        public Unit(string name, int health, int maxHealth, int speed)
        {
            _name = name;
            _health = health;
            _maxHealth = maxHealth;
            _speed = speed;
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }


        public virtual int Health
        {
            get { return _health; }
            set 
            { 
                if(value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value; 
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
        }

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {_name} CurrentHealth: {_health}" );
        }

    }
}
