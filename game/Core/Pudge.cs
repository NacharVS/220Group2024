    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace game.Core
    {
        internal class Pudge : Unit
        {

            public Pudge(double damage, double defence) : base("Pudge", 100, 100, 5)
            {
                Damage = damage;
                Defence = defence;
            }





        }
    }
