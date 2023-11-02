using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class BuildingFactory
    {
        private string _name;
        private double _health;
        private int _maxHealth;
        private double _defence;
        public BuildingFactory(string name, double health, int maxHealth, double defence)
        {
            _name = name;
            _health = health;
            _maxHealth = maxHealth;
            _defence = defence;
        }

        public static void CreateBarracs()
        {
            Barracs barracs = new Barracs();
            Console.WriteLine("Казарма создана");
        }

        public static void CreateTownHall() 
        {
            //Townhall th = new Townhall();
            //Console.WriteLine("Ратуша создана");
        }

        public static void CreateWatchingTower() 
        {
            WatchingTower wt = new WatchingTower();
            Console.WriteLine("Смотровая башня создана");
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
                else
                    _defence = value;
            }
        }
        public double Health
        {
            get { return _health; }
            set
            {

                if (value >= _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if (value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value;


            }
        }
        public string Name => _name;
        public int MaxHealth => _maxHealth;
        
    }
}
