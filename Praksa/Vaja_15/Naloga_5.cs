using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga5
{
    class Program5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("{0} + {1} = {2}", i, j, (j + i));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
