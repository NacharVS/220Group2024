using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Townhall : TownHallBase
    {
        private static int ThDamage = 0;
        Random random = new Random();
        public Townhall() : base("TownHall", 100)
        {

        }
        public static void TownHallDamage(Unit unit)
        {
            int Count = 0;
            Console.WriteLine("Введите количество лучников крестьян в ратуше(до 5)");
            int Peasants = Convert.ToInt32(Console.ReadLine());
            List<Peasant> peasants = new List<Peasant>(5);
            if ( Peasants == 1)
            {
                peasants.Add(new Peasant());
            }
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
                foreach (var archer in peasants)
                {
                    for (Count = Peasants; peasants.Count > 0; Count--)
                    {
                        ThDamage += (int)archer.Damage;

                    }
                    unit.Health -= ThDamage;
                    Console.WriteLine($"Башня нанесла {unit.Name} {ThDamage} урона");
                }
            }
        }
    }
}
