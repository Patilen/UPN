using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_2
{
    class Naloga_6
    {
        static void Main(string[] args)
        {
            /* Spremenljike so določene 
             * @string ime -> Definirano ime 
             * @string priimek -> Definiran priimek
             * @string naslov -> Definiran naslov
             * @string kraj -> Definiran kraj
             * @int stevilka -> Definirana hišna številka 
             * @int posta -> Definiran poštna številka
             */
            string ime = "Janez";
            string priimek = "Novak";
            string ulica = "Pod vedrim nebom";
            string kraj = "Maribor";
            int stevilka = 14;
            int posta = 2000;
            /* Izpis v formatu 
            * Ime priimek
            * Naslov hišna_številka
            * Poštna_številka pošta
            * 
            * Podatki v izpisu so iz preddefiniranih konstant
            */


            Console.WriteLine(ime +" " + priimek);
            Console.WriteLine(ulica + " " + stevilka);
            Console.WriteLine(posta +" "+ kraj);

            Console.ReadKey(true);
        }
    }
}
