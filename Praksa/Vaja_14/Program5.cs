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
            int vsota = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Vpiši " + i + ". število: ");
                int x = int.Parse(Console.ReadLine());

                vsota += x;
            }
            Console.WriteLine("Vsota desetih števil je " + vsota);

            vsota = 0;
            int j = 1;
            while (j <= 10)
            {
                Console.Write("Vpiši " + j + ". število: ");
                int y = int.Parse(Console.ReadLine());

                vsota += y;
                j++;
            }
            Console.WriteLine("Vsota desetih števil je " + vsota);

            vsota = 0;
            int k = 1;
            do
            {
                Console.Write("Vpiši " + k + ". število: ");
                int z = int.Parse(Console.ReadLine());

                vsota += z;
                k++;
            } while (k <= 10);
            Console.WriteLine("Vsota desetih števil je " + vsota);
            Console.ReadLine();
        }
    }
}
