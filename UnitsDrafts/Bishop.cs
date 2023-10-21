using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana = 0;
        private int _maxMana = 60;

        public Bishop(int mana) : base("Bishop", 0, 30, 0)
        {
            _mana = mana;
        }

        public int mana
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

            unit.Health += 2;

            mana -= 1;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Mana: {mana}");
        }
    }
}
