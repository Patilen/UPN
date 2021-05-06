/*Napiši program, ki prebere celo število in izpiše, kakšen šolski uspeh to število predstavlja
(1 - nezadosten, 2 – zadosten, 3 – dober, 4 – prav dober 5 – odličen, karkoli drugega – napaka pri vnosu).
Nalogo reši BREZ uporabe switch-case.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga10
{
    class Program10
    {
        static void Main(string[] args)
        {
            int ocena;
            Console.WriteLine("Vnesi število: ");
            ocena = int.Parse(Console.ReadLine());

            if (ocena == 1)
                Console.WriteLine("nezadosten");
            else if (ocena == 2)
                Console.WriteLine("zadosten");
            else if (ocena == 3)
                Console.WriteLine("dober");
            else if (ocena == 4)
                Console.WriteLine("prav dober");
            else if (ocena == 5)
                Console.WriteLine("odličen");
            else
                Console.WriteLine("napaka pri vnosu");

            Console.ReadKey();
        }
    }
}
