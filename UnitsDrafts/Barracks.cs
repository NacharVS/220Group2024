using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Barracks
    {
        Random random = new Random();
        public Footman CreateFootman()
        {
            Statistics.FootmansCount++;
            int hp = random.Next(50, 60);
            return new Footman("Name", hp, hp, random.Next(7, 12), random.Next(5, 15), random.Next(1, 4), true);
        }

        public Archer CreateArcher()
        {
            Statistics.ArchersCount++;
            return new Archer();
        }
        public Cleric CreateCleric()
        {
            return new Cleric(random.Next(45, 55), random.Next(55, 65));
        }
        public Peasant CreatePeasant()
        {
            return new Peasant();
        }
        public Bishop CreateBishop()
        {
            return new Bishop();
        }
    }
}
