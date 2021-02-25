using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_2
{
    class Naloga_4
    {
        static void Main(string[] args)
        {
            /* Pozove uporabnika k vnosu podatkov 
             * @int x -> Uporabnik vnese prvo celo število 
             * @int y -> Uporabnik vnese drugo celo število 
             */
            int x  = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            // Izpiše vneseni števili 
            Console.WriteLine("Vnesli ste števili " + x + " in " + y);

            // Izpiše vsoto vnesenih števil
            Console.WriteLine(x + y);

            // Izpiše produkt vnesenih števil
            Console.WriteLine(x * y);

            // Pusti okno odprto
            Console.ReadKey(true);
        }
    }
}
