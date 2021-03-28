using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorija_UPN_vaja_metode
{
    class Program
    {
        static void Main(string[] args)
        {
             char BeriZacetnico()
            {
                Console.WriteLine("Vnesi začetnico");
                string ime = Console.ReadLine();
                char inicialka  = ime[0];
                return Char.ToUpper(inicialka);
            }

            char inicialka1 = BeriZacetnico();
            char inicialka2 = BeriZacetnico();
            Console.WriteLine(inicialka1 + ". + " + inicialka2 + ". to je lepi par.");
            Console.ReadKey();
        }
    }
}
