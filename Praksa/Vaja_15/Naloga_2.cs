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
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // opazim da se je iz 7 vrstic, prišlo na 2 vrstici
        }
    }
}
