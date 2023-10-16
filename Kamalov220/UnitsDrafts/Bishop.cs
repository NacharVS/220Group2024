using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        public int _mana = 60;
        public Bishop() : base("Bishop", 20, 20, 8) { }
        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }
        public void Heal(Unit unit)
        {
            int needHeal = unit.MaxHealth - unit.Health;
            if ((needHeal / 2 + needHeal % 2) > _mana) { unit.Health += _mana * 2; needHeal = _mana * 2; _mana = 0; }
            else { unit.Health += needHeal; _mana -= needHeal / 2 + needHeal % 2; }
            Console.WriteLine($"{Name} recovered {needHeal} HP, he had {_mana} mana left");
        }
    }
}
