namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private const int _healing = 10;
        private int _mana = 6;

        public Bishop() : base("Medic", 30, 30, 20) { }

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
