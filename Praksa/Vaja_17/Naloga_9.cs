/*Napiši program, ki prebere celo število in izpiše, kakšen šolski uspeh to število predstavlja
(1 - nezadosten, 2 – zadosten, 3 – dober, 4 – prav dober 5 – odličen, karkoli drugega – napaka pri vnosu).
Nalogo reši z uporabo switch-case.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga09
{
    class Program9
    {
        static void Main(string[] args)
        {
            int ocena;
            Console.WriteLine("Vnesi število: ");
            ocena = int.Parse(Console.ReadLine());
            switch (ocena)
            {
                case 1:
                    Console.WriteLine("nezadosten");
                    break;
                case 2:
                    Console.WriteLine("zadosten");
                    break;
                case 3:
                    Console.WriteLine("dober");
                    break;
                case 4:
                    Console.WriteLine("prav dober");
                    break;
                case 5:
                    Console.WriteLine("odličen");
                    break;
                default:
                    Console.WriteLine("napaka pri vnosu");
                    break;
            }
            Console.ReadKey();
        }
    }
}
