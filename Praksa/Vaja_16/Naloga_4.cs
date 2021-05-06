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
            int vsota = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Vnesi število: ");
                int x = int.Parse(Console.ReadLine());

                if (x < 0) continue;
                vsota += x;
            }
            Console.WriteLine("Vsota pozitivnih števil je: {0}", vsota);
            Console.ReadLine();
        }
    }
}
