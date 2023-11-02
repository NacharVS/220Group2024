using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Townhall : BuildingFactory
    {
        private double _damage;
        private static int ThDefence;
        private string _name;
        private double _health;

        public Townhall(string name, double health) : base("TownHall", 100, 100, 50)
        {
            _name = name;
            _health = health;
        }
        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        
        public static void TownHallDamage(Unit unit)
        {
            CreateTownHall();
            Console.WriteLine("Введите количество крестьян в ратуше(до 5)");
            int Peasants = Convert.ToInt32(Console.ReadLine());
            List<Peasant> peasants = new List<Peasant>(5);
            if ( Peasants == 1)
            {
                peasants.Add(new Peasant());
            }
            //e
            else if ( Peasants == 2)
            {
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
            }
            if ( Peasants == 3)
            {
                peasants.Add(new Peasant()); 
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
            }
            else if( Peasants == 4)
            {
                peasants.Add(new Peasant()); 
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
            }
            if( Peasants == 5)
            {
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
                peasants.Add(new Peasant());
            }
            else if( Peasants > 5)
            {
                Console.WriteLine("Ратуша расчитана только на 5 крестьян");
            }


            if (peasants.Exists(x => x.Name == "Peasant"))
            {
                ThDefence = 0;
                for (int i = 0; i < peasants.Count; i++)
                {
                    //ThDefence += (int)peasants[i].Damage;
                    ThDefence -= (int)peasants[i].Damage;
                    Console.WriteLine($"Ратуша получила  {ThDefence} урон(-a) от {unit.Name} -а");
                }
            }
        }
    }
}
