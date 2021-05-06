using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga05
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vnesi število: ");
            int y = int.Parse(Console.ReadLine());

            // int e1 = (x - y++) * x;
            int e2 = (x - ++y) * x;
            Console.WriteLine(e2);
            Console.ReadLine();
            // pri enačbi e1 je y++, kar pomeni, da se ++ bo še le v naslednjem koraku izvedel
            // pri enačbi e2 je ++y, kar pomeni, da se prvo izvede ++ in nato se odšteje
        }
    }
}
