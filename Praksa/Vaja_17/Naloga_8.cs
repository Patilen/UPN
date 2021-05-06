//Napiši program, ki v zanki bere cela števila tako dolgo, dokler ne vpišemo števila 10. Na koncu izpiše "KONEC".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga08
{
    class Program8
    {
        static void Main(string[] args)
        {
            int stevilo = 0;
            while (stevilo != 10)
            {
                Console.WriteLine("Vnesi število: ");
                stevilo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("KONEC");
            Console.ReadKey();
        }
    }
}
