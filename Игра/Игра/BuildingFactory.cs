using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
    internal class BuildingFactory
    {
        public static Barracs CreateBarracs()
        { 
            return new Barracs();
        }
    }
}
