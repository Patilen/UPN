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
            Random rnd = new Random();
            int rnd2;
            int rezultat = 0;
            int rezultat2 = 0;

            for (int i = 0; i < 1000; i++)
            {
                rnd2 = rnd.Next(1, 10);
                Console.WriteLine(rnd2);

                if (rnd2 <= 5)
                {
                    rezultat += 1;
                }
                else
                {
                    rezultat2 += 1;
                }
            }
            Console.WriteLine("Tukaj je {0} števil, ki je manjših ali enkaih 5 in {1} števil, ki je večjih od 5", rezultat, rezultat2);
            Console.ReadLine();
        }
    }
}
