using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vpiši telefonsko številko:");
            int tel = int.Parse(Console.ReadLine());
            if (tel.ToString().Length == 8)
                Console.WriteLine("{0:(0##)###-###}", tel);
            else
                Console.WriteLine("{0:(###)###-###}", tel);
            Console.ReadKey();









        }
    }
}
