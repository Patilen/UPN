using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_09
{
    class Naloga_09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesite število prevoženih kilometrov");
            int st_prevoz_km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vnesite število natočenih litrov goriva");
            int st_litrov = Convert.ToInt32(Console.ReadLine());

            float poraba = (float)st_litrov * 100 / (float)st_prevoz_km;

            Console.WriteLine("Vaša poraba na 100km je " + poraba);

            Console.ReadKey(true);
        }
    }
}
