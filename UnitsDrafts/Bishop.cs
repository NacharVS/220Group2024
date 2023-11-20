namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        public delegate void HealSomebodyDelegate(Unit unit);
        public HealSomebodyDelegate HealDelegate;
        private int _mana;

        public Bishop() : base("Bishop", 40, 7)
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
            HealDelegate(unit);
        }
        public void HealMethod1(Unit unit)
        {
            Console.WriteLine("Heal somebody");
        }

        public void HealMethod2(Unit unit)
        {
            Console.WriteLine("Heal archer");
        }




    }
}
