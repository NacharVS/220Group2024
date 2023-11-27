using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class UnitEventArg
    {
        public UnitEventArg(string message, int healthDifferce)
        {
            Message = message;
            HealthDifferce = healthDifferce;
        }

        public string Message { get; set; }
        public int HealthDifferce { get; set; }
    }
}

