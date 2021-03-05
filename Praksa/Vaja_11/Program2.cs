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
            Console.Write("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            int i = 0;
            while (i < x)
            {
                Console.WriteLine("**********");
                i++;
            }
            Console.ReadLine();
        }
    }
}
