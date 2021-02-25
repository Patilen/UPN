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
            Console.Write("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Nezadostno");
            } else if (x == 2)
            {
                Console.WriteLine("Zadostno");
            } else if (x == 3)
            {
                Console.WriteLine("Dobro");
            } else if (x == 4)
            {
                Console.WriteLine("Pravdobro");
            } else if (x == 5)
            {
                Console.WriteLine("Odlično");
            }
            else
            {
                Console.WriteLine("Napaka pri vnosu.");
            }
            Console.ReadLine();
        }
    }
}
