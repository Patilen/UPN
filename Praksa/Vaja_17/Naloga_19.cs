/*•	Ustvarite štiri spremenljivke tipa celo število z imeni x1, x2, x3, x4. Uporabnik naj vpiše števila.
•	Poiščite najmanjše število in ga shrani v spremenljivko min. 
•	Poiščite največje število in ga shrani v spremenljivko max.
•	Števila, ki so shranjena v spremenljivkah x1 .. x4 uredite po vrsti tako, da bo najmanjše število shranjeno v x1, drugo v x2 in tako dalje do x4. Pomagate si lahko samo s spremenljivko z, ki je tudi celo število.
•	Na koncu izpišite najmanjše število, največje število in števila v spremenljivkah od x1 do x4, ki so sedaj v pravilnem vrstnem redu.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga19
{
    class Program19
    {
        public static void zamenjaj(ref int a, ref int b)
        {
            int z = a;
            a = b;
            b = z;
        }
        static void Main(string[] args)
        {
            int x1 = 0, x2 = 0, x3, x4, min, max;
            Console.WriteLine("Vnesi x1: ");
            x1 = int.Parse(Console.ReadLine());
            min = x1;
            max = x1;
            Console.WriteLine("Vnesi x2: ");
            x2 = int.Parse(Console.ReadLine());
            if (x2 > max)
                max = x2;
            else if (x2 < min)
                min = x2;
            Console.WriteLine("Vnesi x3: ");
            x3 = int.Parse(Console.ReadLine());
            if (x3 > max)
                max = x3;
            else if (x3 < min)
                min = x3;
            Console.WriteLine("Vnesi x4: ");
            x4 = int.Parse(Console.ReadLine());
            if (x4 > max)
                max = x4;
            else if (x4 < min)
                min = x4;
            if (x1 > x2)
                zamenjaj(ref x1, ref x2);
            if (x3 > x4)
                zamenjaj(ref x3, ref x4);
            if (x1 > x3)
                zamenjaj(ref x1, ref x3);
            if (x2 > x4)
                zamenjaj(ref x2, ref x4);
            if (x2 > x3)
                zamenjaj(ref x2, ref x3);

            Console.Write("min:{0} max:{1}\n{2} {3} {4} {5}", min, max, x1, x2, x3, x4);
            Console.ReadKey();
        }
    }
}
