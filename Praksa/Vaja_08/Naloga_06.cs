using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_06
{
    class Naloga_06
    {
        static void Main(string[] args)
        {
            int x = 5, y = 7;
            double a = 4.5;
            y += (int)(++x % (y-- - 2) + a--);

            Console.WriteLine("x = " + x + " y = "+ y + " a = "+ a);

            Console.ReadKey(true);
        }
    }
}
