using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamalov220
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                    Console.ReadKey();
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine(c);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(a);
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                    Console.ReadKey();
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine(c);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(b);
                        
                    }

                }
            }
        }
    }
}
