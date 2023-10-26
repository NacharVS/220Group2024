using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Работа
{
    internal class Bishop : Unit
    {
        private int _mana;

        public Bishop(int mana) : base("Churchman", 60, 9, "Church")
        {
            _mana = mana;
        }

        public int Mana
        {
            get { return _mana; }

            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                    _mana = value;
            }
        }

        public void Revival(Unit unit)
        {
            unit.Health += 2;
            Mana -= 1;
        }

        public override void BaseInfo()
        {
            Console.WriteLine($"Имя:{Name} Состояние здоровья: {Health} Количество маны: {Mana}");
        }
    }
}
