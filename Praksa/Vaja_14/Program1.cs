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
            int i = 20;
            while (i <= 202)
            {
                Console.Write(i + ", ");
                i += 2;
            }
            Console.WriteLine();
            for (int j = 0; j <= 202; j += 2)
            {
                Console.Write(j + ", ");
            }
            Console.WriteLine();
            int k = 20;

            do
            {
                Console.Write(k + ", ");
                k += 2;
            } while (k <= 202);
            Console.ReadLine();
        }
    }
}
