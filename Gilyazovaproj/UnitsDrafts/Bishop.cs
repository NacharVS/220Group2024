namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;

        public Bishop(int mana) : base("Medic", 30, 30, "Church")
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
                {
                    _mana = value;
                }
            }
        } 
        public void Healing(Unit unit)
        {
            unit.Health += 2;
            Mana -= 1;
        }
        public override void BaseInfo()
        {
            Console.WriteLine($"Имя: {Name} Состояние здоровья: {Health} Количество маны: {Mana}");
        }
    }
}