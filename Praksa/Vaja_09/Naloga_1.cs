using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja9
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vnesi število: ");
            int y = int.Parse(Console.ReadLine());

            if(x < y)
            {
                Console.WriteLine(y);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
