using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana = 0;

        public Bishop(int mana) : base("Bishop", 30, 30, 0)
        {
            _mana = mana;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Defence: {Defence} Mana: {Mana}/{MaxMana}");
        }

    }
}
