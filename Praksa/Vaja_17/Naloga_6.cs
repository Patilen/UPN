/*Napiši program, ki prebere dve realni števili in ugotovi, ali je njun produkt večji od njune vsote.
Če je, izpiše ("Produkt je večji od vsote!").*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga06
{
    class Program6
    {
        static void Main(string[] args)
        {
            double st1, st2;
            Console.WriteLine("Vnesi prvo število: ");
            st1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi drugo število: ");
            st2 = double.Parse(Console.ReadLine());
            if (st1 * st2 > st1 + st2)
                Console.WriteLine("Produkt je večji od vsote!");
            Console.ReadKey();
        }
    }
}
