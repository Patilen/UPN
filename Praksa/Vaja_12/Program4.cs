using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vnesi število: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                do
                {
                    y++;
                    Console.WriteLine(y);
                } while (y < x - 1);
            }
            else
            {
                do
                {
                    x++;
                    Console.WriteLine(x);
                } while (y - 1 > x);
            }
            Console.ReadLine();
        }
    }
}
