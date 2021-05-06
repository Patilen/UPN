using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_08
{
    class Naloga_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi prvo število");
            int stevilo_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vnesi drugo število");
            int stevilo_2 = Convert.ToInt32(Console.ReadLine());
            float rezultat;

            rezultat = stevilo_1 / stevilo_2;

            Console.WriteLine("Količnik števila je " + rezultat);

            Console.ReadKey(true);

            /********************************************************************************************
             * Ugootovitev                                                                              *
             * V primeru, da število ni celoštevilsko deljivo izpiše 0 (3/4)                            *
             * V primeru, da je število deljivo celoštevilsko pa izpiše rezultat (4/2)                  *
             *******************************************************************************************/
        }
    }
}
