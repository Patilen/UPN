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
            Console.Write("Vnesi letnico: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 100 != 0 || x / 4 == 0)
            {
                Console.WriteLine("Leto je prestopno.");
            }
            else if(x % 1000 == 0 && x % 4 == 0)
            {
                Console.WriteLine("Leto je prestopno.");
            }
            Console.ReadLine();
        }
    }
}
