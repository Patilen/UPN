using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga1
{
    class Program1
    {
        static void Main(string[] args)
        {
            // a)
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // b)
            for (int j = 11; j <= 27; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            // c)
            for (int k = 1; k <= 11; k += 2)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            // d)
            for (int l = 0; l <= 1000; l += 10)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();
            // e)
            for (int m = 10; m >= 1; m--)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
            // f)
            for (int n = 100; n >= -100; n -= 6)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}
