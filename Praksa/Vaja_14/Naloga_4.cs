using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga4
{
    class Program4
    {
        static void Main(string[] args)
        {
            int vsota = 0;
            for (int i = 1; i <= 10; i++)
            {
                vsota += i;
            }
            Console.WriteLine(vsota);

            int j = 1;
            vsota = 0;
            while (j <= 10)
            {
                vsota += j;
                j++;
            }
            Console.WriteLine(vsota);

            int k = 1;
            vsota = 0;
            do
            {
                vsota += k;
                k++;
            } while (k <= 10);
            Console.WriteLine(vsota);
            Console.ReadLine();
        }
    }
}
