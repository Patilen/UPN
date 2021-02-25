using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_2
{
    class Naloga_7
    {
        static void Main(string[] args)
        {
            /* Pozove uporabnika k vnosu 
             * @string ime -> Uporabnik vnese ime 
             * @string priimek -> Uporabnik vnese priimek
             * @string naslov -> Uporabnik vnese naslov
             * @string kraj -> Uporabnik vnese kraj
             * @int stevilka -> Uporabnik vnese hišno številko 
             * @int posta -> Uporabnik vnese poštno številko
             */

            Console.WriteLine("Vnesi ime");
            string ime = Console.ReadLine();
            Console.WriteLine("Vnesi priimek");
            string priimek = Console.ReadLine();
            Console.WriteLine("Vnesi ulico");
            string ulica = Console.ReadLine();
            Console.WriteLine("Vnesi hišno številko");
            int stevilka = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi poštno število");
            int posta = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi pošto");
            string kraj = Console.ReadLine();


            /* Izpis v formatu 
             * Ime priimek
             * Naslov hišna_številka
             * Poštna_številka pošta
             * 
             * Podatki v izpisu so iz vnesenih podatkov
             */

            Console.WriteLine();
            Console.WriteLine(ime + " " + priimek);
            Console.WriteLine(ulica + " " + stevilka);
            Console.WriteLine(posta + " " + kraj);

            Console.ReadKey(true);
        }
    }
}
