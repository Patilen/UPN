using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga5
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Vpiši prvo število: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vpiši drugo število: ");
            int y = int.Parse(Console.ReadLine());

            for (; x <= y; x++)
            {
                if (x % 7 != 0 && x % 12 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
