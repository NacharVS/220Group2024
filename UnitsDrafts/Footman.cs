using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        public delegate void FootmanDelegate(double damage, double defence);
        public FootmanDelegate footmanDelegate;
        private double _damage;
        private double _defence;
        private double _maxDefence;

        public Footman(double damage, double defence) : base("Footman", 60, 9, "War")
        {
            _damage = damage;
            _defence = defence;
        }

        public Footman() : base("Footman", 60, 9, "War")
        {
            _damage = 13;
            _defence = 2;
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


                else if (value > _defence)
                {
                    _defence = _maxDefence;
                }
                else
                    _defence = value;

            }
        }


        public void Rage()
        {
            if (Health < MaxHealth * 0.4)
            {
                Damage += Damage * 0.5;
            }
            else
                Damage = Damage;

        }
        public override void BaseInfo()
        {
            Console.WriteLine($"Имя:{Name} Состояние здоровья: {Health}/{MaxHealth}  Урон: {Damage} Защита: {Defence}");
        }

        public void InflictDamage(Unit unit, Footman footman)
        {
            Rage();
            if (footman.Defence > 0)
            {
                footman.Defence--;

            }
            else

                footman.Health -= Damage;
            unit.BaseInfo();
            unit.Death();
        }
        public void FootmanMethod(double damage, double defence)
        {
            footmanDelegate(damage, defence);
        }

    }
}