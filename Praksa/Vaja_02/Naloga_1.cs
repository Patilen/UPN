using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_2
{
    class Naloga_1
    {
        static void Main(string[] args)
        {
            /* Pozove uporabnika k vnosu podatkov 
             * @string ime   -> Uporabnik mora vnesti IME
             * @string priimek -> Uporabnik mora vnesti PRIIMEK
             */

            Console.WriteLine("Vnesi ime");
            string ime = Console.ReadLine();
            Console.WriteLine("Vnesi priimek");
            string priimek = Console.ReadLine();

            // Vneseni podatki se izpišejo v konzolnem oknu
            Console.WriteLine(ime + " " + priimek);

            // Ohrani okno odprto (uporabnik ga mora ročno zapreti)
            Console.ReadKey(true);
        }
    }
}
