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
            Console.Write("Koliko vrstic želiš izpisati: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Koliko stolpcev želiš izpisati: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Iz katerih znakov naj bo lik: ");
            char z = char.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(z);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
