using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject
{
    internal class GenericArray <K>
    {
        K[] mass = new K[10];
        public void AddProducts(K obj)
        {

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] != null)
                {

                }
                else
                {
                    mass[i] = obj;
                }
            }

        }

        public K[] GetArray()
        {
            return mass;
        }
    }
}

