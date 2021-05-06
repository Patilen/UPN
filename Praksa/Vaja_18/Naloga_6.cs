/*Napiši metodo PreberiIme. Metoda naj vpraša uporabnika po imenu, ime prebere in ga vrne (metoda sama ne izpisuje ničesar).
Uporabi metodo in v glavnem programu izpiši ime, ki ga je vpisal uporabnik.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga06
{
    class Program6
    {
        static string PreberiIme()
        {
            Console.WriteLine("Vpiši svoje ime:");
            string ime = Console.ReadLine();
            return ime;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PreberiIme());
            Console.ReadKey();
        }
    }
}
