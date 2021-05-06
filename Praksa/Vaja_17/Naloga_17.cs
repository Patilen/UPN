//Seštej n členov vrste: vrsta = 1 + 1/2+ 1/3 +1/4 + .. +1/n
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga17
{
    class Program17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi število:");
            int n = int.Parse(Console.ReadLine());
            double vsota = 0;
            for (int i = 1; i <= n; i++)
            {
                vsota += 1 / (double)i;
            }
            Console.WriteLine(vsota);
            Console.ReadKey();
        }
    }
}
