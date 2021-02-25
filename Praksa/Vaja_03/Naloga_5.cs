using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_3
{
    class Naloga_5
    {
        static void Main(string[] args)
        {
            char crka = Convert.ToChar(Console.ReadLine());
            char velika_crka = char.ToUpper(crka);

            if (crka > velika_crka)
            {
                Console.WriteLine(crka);
            }
            else
            {
                Console.WriteLine(velika_crka);
            }
            Console.ReadKey(true);
        }
    }
}
