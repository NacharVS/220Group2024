using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Cleric : Unit
    {
 
            private int _mana;

            public Cleric(int health, int mana): base ("Cleric", 10, 10, 5, 5, 5)
            {
                _mana = mana;
            }

            public void Heal(Unit unit)
            {
            if (Alive)
            {
                int maxHealing = _mana * 2;
                if (_mana > 0 && unit.Health < unit._maxHealth)
                {
                    int actualHealing = Math.Min(maxHealing, unit._maxHealth - unit.Health);
                    unit.Health += actualHealing;
                    _mana -= actualHealing / 2;
                    Console.WriteLine($"Cleric healed {unit} for {actualHealing} HP. Mana left: {_mana}");
                }
                else
                {
                    Console.WriteLine($"Cleric can't heal {unit.Name} right now.");
                }
            }
        }
    }
}
