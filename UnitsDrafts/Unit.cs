namespace UnitsDrafts
{
    internal class Unit
    {
        private readonly string _name;
        private double _health;
        private int _maxHealth;
        private double _defence;
        private double _damage;
        private int _mana = 20;
        private int _maxMana = 20;

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

        public virtual double Damage
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
            Console.WriteLine("-------------------------------");
            Console.WriteLine(this.Name + " нанёс урон по " + unit.Name + "-у");
            Console.WriteLine("-------------------------------");
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
                    unit.Health -= this.Damage * 0.5;
                }
                else
                {

                    unit.Defence = 0;
                    unit.Health -= (this.Damage - ostatok_defenca) + (ostatok_defenca * 0.5);
                }
            }
            else
            {
                unit.Health -= this.Damage;
            }
        }
        public int MaxMana
        {
            get { return _maxMana; }
            set { _maxMana = value; }
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value <= _maxMana & value > 0)
                {
                    _mana = value;
                }
            }
        }
        public void HealSomebody(Unit unit)
        {
            _mana -= 1;
            unit.Health += 2;
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Bishop захилил {unit.Name} на 2 хп.");
            Console.WriteLine($"Остаток маны: {_mana}/{MaxMana}");
            Console.WriteLine("-------------------------------");
        }
        public void WatchingTowerDamage(Unit unit)
        {
            List<Archer> archers = new List<Archer>();
            archers.Add(new Archer());
            archers.Add(new Archer());

            if (archers.Exists(x => x.Name == "Archer"))
            {


                foreach (var archer in archers)
                {
                    var TowerDamage = archer.Damage;
                    unit.Health -= TowerDamage;
                    Console.WriteLine($"Башня нанесла {unit.Name} урон");
                }

            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Defence: {Defence}");
        }

    }
}
