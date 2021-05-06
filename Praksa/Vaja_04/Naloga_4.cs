using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi število:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("{0:x} {1:x} {2:x} {3:x} {4:x}", a, b, c, d, e);
            Console.ReadKey();








        }
    }
}
