using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class WatchingTower
    {
        private List<Archer> units = new List<Archer> { };
        private int _damage = 0;
        public int freeplaces;
        public int level;
        private int _health = 20;
        public int _maxhealth = 20;
        public WatchingTower(List<Archer> Units, int Level)
        {
            if (Level == 1 ||  Level == 2) 
            {
                level = Level;
            }
            else
            {
                level = 1;
            }
            int unitsCount = 0;
            foreach (Archer creatures in Units)
            { 
                if (creatures != null)
                { 
                    unitsCount++;
                }
            }
            if (unitsCount > 1)
            {
                unitsCount = 1;
            }
            for (int i = 0; i < unitsCount; i++)
            {
                units.Add(Units[i]);
                _damage += Units[i].Damage;
            }
            freeplaces = level - unitsCount;
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int Health
        { 
            get { return _health; }
            set {  _health = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Уровень башни - {level}");
            Console.WriteLine($"урон башни - {Damage}");
            Console.WriteLine("Персонажи в башне:");
            foreach (Archer unit in units)
            {
                Console.WriteLine(unit.Name);
            }
            Console.WriteLine($"Свободных мест в башне - {freeplaces}");
        }
        public void InflictDamage(Unit unit)
        {
            unit.Health -= (_damage - unit.Defense);
        }
    }

}
