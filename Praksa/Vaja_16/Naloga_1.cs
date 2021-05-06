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
            for (; ; )
            {
                Console.Write("Vnesi število: ");
                int x = int.Parse(Console.ReadLine());

                if (x == 0) break;
            }
            Console.WriteLine("KONEC");
            Console.ReadLine();
        }
    }
}
