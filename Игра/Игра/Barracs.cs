using game.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
    internal class Barracs
    {
        Random random = new Random();
        public Pudge CreatePudge()
        {
            
            Statistics.PudgeCount++;
            return new Pudge("Name", random.Next(50, 60), random.Next(5, 10), random.Next(10, 20), random.Next(10, 30));
        }

        public Archer CreateArcher()
        {
            Statistics.ArchersCount++;
            return new Archer(random.Next(15,30));
        }
    }
}
