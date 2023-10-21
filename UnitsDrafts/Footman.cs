﻿namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;
        private int _defence;
        private int _health;

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


        public Footman(string name, int health, int maxHealth, int speed, int damage, int defence) : base(name, health, maxHealth, defence)
        {
            _damage = damage;
            _defence = defence;
            _health = health;
        }

        public Footman(double defence, double damage) : base("Footman", 60, 10, 3)
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
            unit.Health = unit.Health - _damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }
        
    }
}
