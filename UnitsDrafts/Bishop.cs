namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;

        public Bishop() : base("Bishop", 50, 7)
        {
        }

        public Bishop(string name, int maxHealth, int speed) : base(name, maxHealth, speed)
        {
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public void HealSomebody(Unit unit)
        {
            Console.WriteLine("Healing");
        }



    }
}
