/*Napiši metodo Jaz, ki trikrat izpiše tvoje ime. Ime loči s presledki.
V glavnem programu uporabi metodo tako, da bo trikrat izpisala vaše ime.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga03
{
    class Program3
    {
        static void Jaz(string a)
        {
            for(int i = 0;i<3;i++)
            {
                Console.Write(a + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši svoje ime:");
            string a = Console.ReadLine();
            Jaz(a);
            Console.ReadKey();
        }
    }
}
