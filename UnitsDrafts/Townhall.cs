﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts;

namespace UnitsDrafts
{
    internal class Townhall
    {
        public Peasant CreatePeasant()
        {
            return new Peasant();
            Statistics.PeasantCount++;
        }
    }
}
