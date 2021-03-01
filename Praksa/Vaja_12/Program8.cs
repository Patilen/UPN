using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga8
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("Vpiši začetek intervala: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vpiši konec intervala: ");
            int y = int.Parse(Console.ReadLine());

            int vsota = 0;
            do
            {
                if (x % 7 != 0)
                {
                    vsota += x;
                }
                x++;
            } while (x <= y);
            Console.WriteLine("Vsota vseh števil, ki niso deljiva s 7 v tem intervalu je {0}", vsota);
            Console.ReadLine();
        }
    }
}
