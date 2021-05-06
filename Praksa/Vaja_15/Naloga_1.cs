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
            int i = 0;
            int j = 0;
            while (i < 7)
            {
                while (j < 4)
                {
                    Console.Write("Tilen ");
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }
            Console.ReadLine();
        }
    }
}
