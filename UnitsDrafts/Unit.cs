namespace UnitsDrafts
{
    internal class Unit
    {
        private readonly string _name;
        private double _health;
        private int _maxHealth;
        private double _defence;
        private double _damage;

        public Unit(string name, double health, int maxHealth, double defence)
        {
            _name = name;
            _health = health;
            _maxHealth = maxHealth;
            _defence = defence;
        }

        public string Name => _name;       
        public int MaxHealth => _maxHealth;

        

        public virtual double Health
        {
            get { return _health; }
            set
            {

                if (value >= _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if (value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value;


            }
        }
        public double Rage()
        {
            return _damage *= 1.5;
        }

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public double Defence
        {
            get { return _defence; }
            set
            {
                if (value < 0)
                {
                    _defence = 0;
                }
                else
                    _defence = value;
            }
        }
        public void TakeDamage(Unit unit)
        {
            Console.WriteLine(this.Name + " вшатал по " + unit.Name + "-у");
            if (Health < _maxHealth / 3)
            {
                Rage();
            }
            if (unit.Defence > 0)
            {
                double ostatok_defenca = unit.Defence;
                if (ostatok_defenca >= this.Damage)
                {
                    unit.Defence -= this.Damage;
                    unit.Health -= this.Damage * 0.25;
                }
                else
                {

                    unit.Defence = 0;
                    unit.Health -= (this.Damage - ostatok_defenca) + (ostatok_defenca * 0.25);
                }
            }
            else
            {
                unit.Health -= this.Damage;
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth}" );
        }

    }
}
