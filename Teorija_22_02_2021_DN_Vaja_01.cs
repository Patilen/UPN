// Napiši program, ki toliko časa prebira vrednosti, ki jih vnaša uporabnik, dokler ta ne vnese vrednosti 1, ko jo uporabnik vnese, naj program izpiše največjo vrednost.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPN_Naloga
{
    class NalogaUPN
    {
        static void Main(string[] args)
        {
            int x = 0;
            int najvecje = 0;

            while (x != 1)
            {
                Console.WriteLine("Vnesite število:");
                x = int.Parse(Console.ReadLine());

                if (x > najvecje)
                {
                    najvecje = x;
                }
            }
            Console.WriteLine(najvecje);
            Console.ReadLine();
        }
    }
}
