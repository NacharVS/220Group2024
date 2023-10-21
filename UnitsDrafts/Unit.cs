namespace UnitsDrafts
{
    internal class Unit
    {
        private readonly string _name;
        private int _health;
        private int _maxHealth;
        private double _defence;
        private double _damage;

        public Unit(string name, int health, int maxHealth, int defence)
        {
            _name = name;
            _health = health;
            _maxHealth = maxHealth;
            _defence = defence;
        }

        public string Name => _name;       
        public int MaxHealth => _maxHealth;

        

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

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth}" );
        }

    }
}
