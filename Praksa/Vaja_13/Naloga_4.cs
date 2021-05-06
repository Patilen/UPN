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
            Console.Write("Vpiši prvo število: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vpiši drugo število: ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 300; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
