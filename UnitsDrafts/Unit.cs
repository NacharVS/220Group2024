using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа
{
    internal class Unit
    {
        public delegate void MethodsDelegate(Unit unit);
        public MethodsDelegate Methods;
        private string _name;
        private double _health;
        private double _maxHealth;
        private int _speed;
        private string _service;

        public Unit(string name, double maxHealth, int speed, string service)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
            _service = service;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }


        public virtual double Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }


                else if (value > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                    _health = value;

            }
        }
        public double MaxHealth
        {
            get { return _maxHealth; }

        }

        public virtual void GoToService()
        {
            Console.WriteLine($"{Name} пошел на службу в {Service}");
        }


        public void Moving()
        {
            Console.WriteLine($"У {_name} скорость: {_speed}");
        }

        public virtual void BaseInfo(Unit unit)
        {
            Console.WriteLine($"Имя:{_name} Состояние здоровья: {_health}");
        }

        public void Death()
        {
            if (_health == 0)
            {
                Console.WriteLine("Герой умер, атаковать нельзя");
            }
        }

        public void Mehtod(Unit unit)
        {
            Methods(unit);
        }
    }
}