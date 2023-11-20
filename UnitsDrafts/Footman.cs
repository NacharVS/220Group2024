﻿namespace UnitsDrafts
{
    internal class Footman : Unit
    {
     public Action action;
        public delegate void InflictDamageDelegate(Unit unit);
        public InflictDamageDelegate infDamage;
        private int _defence;
        private Weapon _weapon;

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


        public Footman(string name, int maxHealth, int speed, int damage, int defence) : base(name, maxHealth, speed)
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
            if (Health <= 0.4 * MaxHealth)
            {
                unit.Health = Convert.ToInt32(unit.Health - _damage * 1.5);
            }
            unit.Health = unit.Health - _damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }

    }
}
