/*Napiši program, ki prebere celo število in ugotovi, ali je število liho. Če je, izpiše: "Število je liho!". V nasprotnem izpiše: "Število ni liho".

Primer 1:
Vpiši število:7
Število je liho!

Primer 2:
Vpiši število:24
Število ni liho.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga05
{
    class Program5
    {
        static void Main(string[] args)
        {
            int stevilo;
            Console.WriteLine("Vnesi število: ");
            stevilo = int.Parse(Console.ReadLine());
            if (stevilo % 2 == 0)
                Console.WriteLine("Število ni liho.");
            else
                Console.WriteLine("Število je liho.");
            Console.ReadKey();
        }
    }
}
