using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vnesi število:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število:");
            float e = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("{0:f3} {1:f3} {2:f3} {3:f3} {4:f3}", a, b, c, d, e);
            Console.ReadLine();









        }
    }
}
