using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_05
{
    class Naloga_05
    {
        static void Main(string[] args)
        {

            float x = Convert.ToInt32(Console.ReadLine());
            float y = Convert.ToInt32(Console.ReadLine());

            // ENAČNA 1
            float e1 = (x - y++) * x; // y se prišteje po koncu izračuna 

            // ENAČBA 2
            float e2 = (x - ++y) * x; // y se prišteje pred začetkom izračuna  in je za dvakratnik manjši razlog zaradi prišteja po koncu izračuna in nato se prišteje še pred izračunom

            Console.WriteLine("Rezultat prve enačbe je " + e1); 
            Console.WriteLine("\nRezultat druge enačbe je " + e2);

            Console.ReadKey(true);
        }
    }
}
