using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga6
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            int i = 1;
            for (; i <= x;)
            {
                Console.Write((i * 7) + " ");
                i++;
            }
            Console.ReadLine();
        }
    }
}
