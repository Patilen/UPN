using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string beseda = "";
            do
            {
                Console.Write("Vnesi znak: ");
                char x = char.Parse(Console.ReadLine());

                if (x == '0') break;

                beseda += x;
                Console.WriteLine("trenutna beseda: {0}", beseda);
            } while (true);
            Console.WriteLine("Končna beseda je: {0}", beseda);
            Console.ReadLine();
        }
    }
}
