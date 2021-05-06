/*Napiši program, ki bo uporabnika povprašal po imenu in teži za dva človeka in potem izpisal, koliko tehtata skupaj na dve decimalni mesti natančno. 
(Če je prvi človek Janko, ki tehta 75,5 kg in drugi Metka, ki tehta 55 kg, program izpiše: 
Janko in Metka skupaj tehtata 130,50 kg.)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga02
{
    class Program2
    {
        static void Main(string[] args)
        {

            string ime1, ime2;
            double teza1, teza2;
            Console.WriteLine("Vnesi prvo ime: ");
            ime1 = Console.ReadLine();
            Console.WriteLine("Vnesi težo prve osebe: ");
            teza1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi drugo ime: ");
            ime2 = Console.ReadLine();
            Console.WriteLine("Vnesi težo druge osebe: ");
            teza2 = double.Parse(Console.ReadLine());

            double skupaj = teza1 + teza2;
            Console.WriteLine(ime1 + " in " + ime2 + " skupaj tehtata " + string.Format("{0:N2}", skupaj) + " kg");
            Console.ReadKey();
        }
    }
}
