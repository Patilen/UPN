using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Na mestih, kjer si v prejšnji vaji preverjal vrednost spremenljivk z razhroščevalnikom, sedaj spremenljivke izpiši.
*/

namespace Naloga2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaracija
            int xI;
            xI = 7;

            //Inicilizacija 
            int yI = 12;
            int vsota = xI + yI;

            // Definira string IME
            string ime = "Janez Novak";

            //IZPIS SPREMENLJIVK 
            Console.WriteLine(xI);
            Console.WriteLine(yI);
            Console.WriteLine(vsota);
            Console.WriteLine(ime);

            // OHRANI OKNO ODPRTO (Drugače se avtomatsko zapre) 
            Console.ReadKey(true);


        }
    }
}