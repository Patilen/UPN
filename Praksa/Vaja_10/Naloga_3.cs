// Napiši program, ki prebere celo število in izpiše, kakšen šolski uspeh predstavlja (1 - nezadosten, 2 – zadosten, 3 – dober, 4 – prav dober 5 – odličen, karkoli drugega – napaka pri vnosu).Nalogo reši z uporabo switch-case.  //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_3
{
    class Program3
    {
        static void Main(string[] args) // By Jon-Nik Gorenak, R-2.b
        {
            Console.WriteLine("Vnesi oceno:");
            int ocena = Convert.ToInt32(Console.ReadLine());

            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Nezadosten");
                    break;
                case 2:
                    Console.WriteLine("Zadosten");
                    break;
                case 3:
                    Console.WriteLine("Dober");
                    break;
                case 4:
                    Console.WriteLine("Prav dober");
                    break;
                case 5:
                    Console.WriteLine("Odličen");
                    break;
                default:
                    Console.WriteLine("Napaka pri vnosu!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
