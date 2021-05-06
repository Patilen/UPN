using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga7
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.Write("Vpiši začetek intervala: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vpiši konec intervala: ");
            int y = int.Parse(Console.ReadLine());

            int rezultat = 0;
            do
            {
                rezultat += x;
                x++;
            } while (x <= y);
            Console.WriteLine("Vsota vseh števil v tem intervalu je {0}", rezultat);
            Console.ReadLine();
        }
    }
}
