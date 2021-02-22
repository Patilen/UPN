using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napiši program, ki prebira vrednosti katere vnaša uporabnik, dokler ne vnese vrednosti 0 
            // Program naj nato izpiše vsoto vnesenih vrednosti

            Console.WriteLine("Vnesi število");
            int vnos = Convert.ToInt32(Console.ReadLine());
            int vsota = 0;

            while (vnos != 0) 
            {
                vsota += vnos;
                Console.WriteLine("Vnesi število");
                vnos = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(vsota);
            Console.ReadKey(true);
        }
    }
}
