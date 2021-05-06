using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2
{
    class Program2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tilen");
            }
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("Tilen");
                j++;
            }
            int k = 0;
            do
            {
                Console.WriteLine("Tilen");
                k++;
            } while (k < 10);
            Console.ReadLine();
        }
    }
}
