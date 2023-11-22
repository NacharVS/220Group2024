using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts;

namespace Работа
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Footman ft1 = new Footman(30, 20);
                Footman ft2 = new Footman(10, 5);
            //Peasant peasant = new Peasant();
            //Bishop churchman = new Bishop(60);
            //Archer archer1 = new Archer();
            //WatchingTower watchingTower1 = new WatchingTower();
            ////Archer archer = new Archer(2, 60);

            ft1.Methods = ft1.BaseInfo;
            ft1.Methods += ft1.BaseInfo;
            ft1.Methods += ft1.BaseInfo;
            ft1.Methods();




            //peasant.BaseInfo();

            //Console.WriteLine("ft1 наносит удар 30 peasant");
            //ft1.InflictDamage(peasant, ft1);
            //Console.WriteLine("Сhurchman помогает ft1");
            //churchman.Revival(peasant);
            //peasant.BaseInfo();
            //churchman.BaseInfo();
            //Console.WriteLine("Ну всё, бетте");

            //Console.WriteLine("Пошли дальше, ft2 бьет 10 ft1");
            //ft2.InflictDamage(ft1, ft2);
            //Console.WriteLine("Ну ещё раз");
            //ft2.InflictDamage(ft1, ft2);
            //Console.WriteLine("И ещё");
            //ft2.InflictDamage(ft1, ft2);
            //Console.WriteLine("И ещё");
            //ft2.InflictDamage(ft1, ft2);
            //Console.WriteLine("На последок сила увеличиться");
            //ft2.InflictDamage(ft1, ft2);


            //watchingTower1.AddArcher(archer1);
            //churchman.Revival(peasant);
            //peasant.BaseInfo();
            //churchman.BaseInfo();

        }
    }
}
