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
            Console.Write("Vnesi števec: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Vnesi imenovalec: ");
            float y = float.Parse(Console.ReadLine());

            float rezultat = x / y;

            if (y != 0)
            {
                Console.WriteLine("števec / imenovalec = {0:f4}", rezultat);
            }else
            {
                Console.WriteLine("števec / imenovalec = neskončno");
            }
            Console.ReadLine();
        }
    }
}
