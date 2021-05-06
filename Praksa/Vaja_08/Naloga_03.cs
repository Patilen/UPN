using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_08
{
    class Naloga_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi prvo število");
            int stevilo_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vnesi drugo število");
            int stevilo_2 = Convert.ToInt32(Console.ReadLine());
            double rezultat;

            rezultat = Convert.ToDouble((int)stevilo_1 / (int)stevilo_2);

            Console.WriteLine("{0, -20 }", "Količnik števila je " + (double)rezultat) ;

            Console.ReadKey(true);

        }
    }
}
