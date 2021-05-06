using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi velikost: ");
            int velikost = int.Parse(Console.ReadLine());

            int presledki = 1;
            if (velikost >= 3)
            {
                for (int i = 0; i < velikost; i++)
                {
                    for (int j = 0; j < velikost - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");

                    if (i == (velikost / 2))
                    {
                        for (int j = 0; j < presledki + 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        presledki += 2;
                    }
                    else
                    {
                        for (int j = 0; j < presledki; j++)
                        {
                            Console.Write(" ");
                        }
                        if (i != 0)
                        {
                            Console.Write("*");
                            presledki += 2;
                        }
                        Console.WriteLine();
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Trikotnika ni mogoče narisati!");
            }
            Console.ReadLine();
        }
    }
}
