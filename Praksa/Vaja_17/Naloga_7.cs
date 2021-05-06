//Naslednji diagram poteka pretvori v programski jezik C#.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga07
{
    class Program7
    {
        static void Main(string[] args)
        {
            int vsota = 0;
            int k = 10;
            do
            {
                vsota += k;
                k--;
            } while (k >= 1);
            Console.WriteLine(vsota);
            Console.ReadKey();
        }
    }
}
