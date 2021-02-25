using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Ustvari pa eno spremenljivko vseh enostavnih tipov (bool, char, sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal) in tipa string. Vsaki spremenljivki priredi neko vrednost, nato pa izpiši vse vrednosti, vsako v svoji vrstici (uporabi Console.WriteLine).
 */


namespace Naloga3
{
    class Naloga3
    {
        static void Main(string[] args)
        {
            //SPREMENLJIVKE
            bool spremnljivka1 = false;
            char spremnljivka2 = 'x';
            sbyte spremnljivka3 = 10;
            byte spremnljivka4 = 26;
            short spremnljivka5 =  -32;
            ushort spremnljivka6 = 'f';
            int spremnljivka7 = 43 ;
            uint spremnljivka8 = 4;
            long spremnljivka9 = -342053202333 ;
            ulong spremnljivka10 = 1111111111111 ;
            float spremnljivka11 = 3.55F ;
            double spremnljivka12 = 0.43886345e3F;
            decimal spremnljivka13 = 33.555M;
            string spremnljivka14 = "Te vaje so res fajne";


            // IZPIS SPREMENLJIVK 
            Console.WriteLine(spremnljivka1);
            Console.WriteLine(spremnljivka2);
            Console.WriteLine(spremnljivka3);
            Console.WriteLine(spremnljivka4);
            Console.WriteLine(spremnljivka5);
            Console.WriteLine(spremnljivka6);
            Console.WriteLine(spremnljivka7);
            Console.WriteLine(spremnljivka8);
            Console.WriteLine(spremnljivka9);
            Console.WriteLine(spremnljivka10);
            Console.WriteLine(spremnljivka11);
            Console.WriteLine(spremnljivka12);
            Console.WriteLine(spremnljivka13);
            Console.WriteLine(spremnljivka14);

            // OHRANI OKNO ODPRTO (Drugače se avtomatsko zapre) 
            Console.ReadKey(true);
        }
    }
}
