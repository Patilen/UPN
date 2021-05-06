using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga04
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vnesi število: ");
            int y = int.Parse(Console.ReadLine());

            int rezultat = x / y;
            int ostanek = x % y;
            float pravilni = (float)x / y;
            Console.WriteLine("rezultat celoštevilskega deljenja je {0}, ostanek je {1}, pravilni rezultat pa je {2} in brez decimalnih mest: {2:f0}", rezultat, ostanek, pravilni);
            Console.ReadLine();
        }
    }
}
