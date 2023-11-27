namespace UnitsDrafts
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(Unit sender, UnitEventArg e);
        public Action action;
        private readonly string _name;
        private int _health;
        private int _maxHealth;
        private int _speed;

        public Unit(string name, int maxHealth, 
            int speed)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
        }

        public string Name => _name;       
        public int MaxHealth => _maxHealth;

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
                {
                    var diff = _health - value;
                    if (diff < 0)
                    {
                        _health = value;
                        HealthIncreasedEvent?.Invoke(_health, diff);
                    }
                    else
                    {
                        _health = value;
                        HealthDecreasedEvent?.Invoke(_health, diff);
                    }
                }
            }
        }

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth}" );
            action();
        }
        public event HealthChangedDelegate HealthDecreasedEvent;
        public event HealthChangedDelegate HealthIncreasedEvent;
    }
}
