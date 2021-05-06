using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datumRojstva;

            Console.WriteLine("Vpiši datum rojstva (leto mesec dan):");
            datumRojstva = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Dan na katerega sem se rodil, {0:dd. MMMM yyy}, je bil {1:dddd}.", datumRojstva, datumRojstva);

            Console.ReadKey();









        }
    }
}
