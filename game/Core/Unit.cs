using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Core
{
    abstract class Unit
    {
        private string _name;
        private double _health;
        private int _speed;
        private int _maxHealth;
        private double _damage;
        private double _defence;
        public Unit(string name, int health, int maxHealth, int speed) { 
            _name = name;
            _health = health;
            _speed = speed;
            _maxHealth = maxHealth;
            _defence = 0;
    }

        public double Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public double Damage
        {
            get { return (double)_damage; }
            set { _damage = value;} 
        }

        public virtual double Health
        {
            get { return _health; }
            set
            {

                    if (value < 0)
                    {
                        _health = 0;
                        Console.WriteLine(_name + " упал и умер :)");
                    }
                    else
                    {
                   
                        _health = value;
                    }
                    if (value > _maxHealth)
                    {
                        _health = _maxHealth;
                    }
            }
   
        }

        public double Rage()
        {
             return _damage *= 1.5;        
        }

        public void BaseInfo()
        {
            Console.WriteLine("---------");
            Console.WriteLine("Имя:" + Name);
            Console.WriteLine("ХП:" + Health);
            Console.WriteLine("Щит:" + Defence);
            Console.WriteLine("---------");
        }
        public void TakeDamage(Unit unit)
        {
            Console.WriteLine(this.Name + " вшатал по " + unit.Name + "-у");
            if(Health < _maxHealth / 3)
            {
                Rage(); 
            }
            if(unit.Defence > 0)
            {
                double ostatok_defenca = unit.Defence;
                if(ostatok_defenca >= this.Damage)
                {
                    unit.Defence -= this.Damage;
                    unit.Health -= this.Damage * 0.25;
                }
                else
                {
                    
                    unit.Defence = 0;
                    unit.Health -= (this.Damage - ostatok_defenca) + (ostatok_defenca*0.25);
                }
            }
            else
            {
                unit.Health -= this.Damage;
            }
        }

 

        
    }
}
