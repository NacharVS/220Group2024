namespace UnitsDrafts
{
    internal class Unit
    {
        private readonly string _name;
        private int _health;
        public int _maxHealth;
        private int _speed;
        private int _defense;
        public string Name => _name;

        public Unit(string name, int health, int maxHealth, int speed, int defense)
        {
            _name = name;
            _health = health;
            _maxHealth = maxHealth;
            _speed = speed;
            _defense = defense;
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
        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void BaseInfo()
        {
            Console.WriteLine($"Name:{_name} CurrentHealth: {_health}" );
            if ( this.Health <= 0 )
            {

            }
        }
        public void rage(Footman ft)
        {
            Console.WriteLine("Footman in Rage!!!");
            int dmgup = ft.Damage / 2;
            ft.Damage = ft.Damage + dmgup;
        }
        
    }
}
