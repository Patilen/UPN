using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_2
{
    class Naloga_5
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            double y = float.Parse(Console.ReadLine());

            // Izpiše vneseni števili 
            Console.WriteLine("Vnesli ste števili " + x + " in " + y);

            // Izpiše vsoto vnesenih števil
            Console.WriteLine(x + y);

            // Izpiše produkt vnesenih števil
            Console.WriteLine(x * y);


            // Ohrani okno odprto
            Console.ReadKey(true);
        }
    }
}
