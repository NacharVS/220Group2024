using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace game.Core
{
    internal class Medic : Unit
    {
        private const int _healing = 10;
        private int _mana = 6;

        public Medic() : base("Medic", 30, 30, 20) { }

        public void Healing(Unit unit)
        {
            if (_mana >= 2)
            {
                unit.Health += _healing;
                _mana -= 2;
                Console.WriteLine(this.Name + " захилял " + unit.Name + " на " + _healing + "хп");
                Console.WriteLine("Остаток маны:" + _mana);
            }
            else
            {
                Console.WriteLine("Мана закончилась, так что иди отсюда");
            }

        }



    }
}