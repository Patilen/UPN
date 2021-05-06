using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga06
{
    class Program6
    {
        static void Main(string[] args)
        {
            int x = 5, y = 7;
            double a = 4.5;

            y += (int)(++x % (y-- - 2) + a--);
            Console.Write(y);
            Console.ReadLine();
        }
    }
}
