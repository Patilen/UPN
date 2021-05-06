using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x != 0)
            {
                Console.Write("Vpiši število: ");
                x = int.Parse(Console.ReadLine());

                if (x != 0)
                {
                    Console.WriteLine("Koda za {0} je {1}", x, (char)x);
                }
            }
            Console.WriteLine("KONEC!");
            Console.ReadLine();
        }
    }
}
