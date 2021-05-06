//Tabeliraj linearno funkcijo f(x) = 4x + 3 na intervalu [-5 , 5] s korakom 0,5! 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga16
{
    class Program16
    {
        static void Main(string[] args)
        {
            double funkcija = 0;
            for (double i = -5; i <= 5; i += 0.5)
            {
                funkcija = 4 * i + 3;
                Console.WriteLine("Vrednost funkcije f(x) = 4x + 3 pri x:{0} je {1}.", i, funkcija);
            }
            Console.ReadKey();
        }
    }
}
