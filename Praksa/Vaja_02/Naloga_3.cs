using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_2
{
    class Naloga_3
    {
        static void Main(string[] args)
        {
            /* Pozove uporabnika k vnosu podatkov 
             * @string ime   -> Uporabnik mora vnesti IME
             * @string priimek -> Uporabnik mora vnesti PRIIMEK
             * @string naslov -> Uporabnik mora vnesti NASLOV
             */

            Console.WriteLine("Vnesi ime");
            string ime = Console.ReadLine();
            Console.WriteLine("Vnesi priimek");
            string priimek = Console.ReadLine();
            Console.WriteLine("Vnesi naslov");
            string naslov = Console.ReadLine();

            // Vneseni podatki se izpišejo v konzolnem oknu
            Console.WriteLine(); // Prazna vrstica zaradi estetike
            Console.WriteLine(ime + " " + priimek);
            Console.WriteLine(naslov);

            // Ohrani okno odprto (uporabnik ga mora ročno zapreti)
            Console.ReadKey(true);
        }
    }
}
