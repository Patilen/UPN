using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_07
{
    class Naloga_07
    {
        static void Main(string[] args)
        {
            int x = 9, y = 4;
            double a = 2.5;
            a += x++ - (float)y-- / ++a;


            Console.WriteLine("x = " + x + " y = " + y + " a = " + a);

            Console.ReadKey(true);
        }
    }
}
