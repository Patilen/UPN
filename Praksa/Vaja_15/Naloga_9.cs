using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga9
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi velikost lika: ");
            int velikost = int.Parse(Console.ReadLine());

            Console.Write("Vnesi znak: ");
            char znak = char.Parse(Console.ReadLine());

            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
