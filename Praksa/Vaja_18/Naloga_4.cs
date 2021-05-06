/*Napiši metodo z imenom Jaz. Metoda naj izpiše tvoje ime. V glavnem programu pokliči metodo in preveri, če dela.
Nato napiši zanko, ki se izvede 5 krat. V zanki izpiši tvoje ime. Uporabi metodo Jaz.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga04
{
    class Program4
    {
        static void Jaz(string a)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši svoje ime:");
            string ime = Console.ReadLine();
            Jaz(ime);
            Console.ReadKey();
        }
    }
}
