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
            Console.Write("Vnesi število a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Vnesi število b: ");
            int b = int.Parse(Console.ReadLine());

            for (; b >= a; a++,b--)
            {
                Console.Write(a + " " + b);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
