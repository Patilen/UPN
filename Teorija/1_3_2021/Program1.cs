using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi število a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Vnesi število b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Vnesi število k: ");
            int k = int.Parse(Console.ReadLine());

            for (; a <= b; a += k)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
