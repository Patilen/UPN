using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_3
{
    class Naloga_6
    {
        static void Main(string[] args)
        {
            string niz1 = Convert.ToString(Console.ReadLine());
            string niz2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Primerjava z ==");
            if (niz1 == niz2)
            {
                Console.WriteLine("Besedili sta enaki");
            }
            else
            {
                Console.WriteLine("Besedili nista enaki");
            }

            Console.WriteLine("Primerjava z !=");
            if (niz1 != niz2)
            {
                Console.WriteLine("Besedili nista enaki");
            }
            else
            {
                Console.WriteLine("Besedili sta enaki");
            }

            Console.WriteLine("Primerjava s String.Compare()");

            if (String.Compare(niz1, niz2) == 1)
            {
                Console.WriteLine("Besedili nista enaki");
            }
            else
            {
                Console.WriteLine("Besedili sta enaki");
            }

            Console.WriteLine("Primerjava s String.Compare() z ignoranco velikosti črk");
            if (String.Compare(niz1, niz2, StringComparison.OrdinalIgnoreCase) == 1)
            {
                Console.WriteLine("Besedili nista enaki");
            }
            else
            {
                Console.WriteLine("Besedili sta enaki");
            }

            Console.WriteLine("Primerjava z CompareTo()");
            if (niz2.CompareTo(niz1) == 1)
            {
                Console.WriteLine("Besedili sta enaki");
            }
            else
            {
                Console.WriteLine("Besedili nista enaki");
            }
            Console.ReadKey(true);
        }
    }
}
