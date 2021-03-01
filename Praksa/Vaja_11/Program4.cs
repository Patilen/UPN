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
            int rezultat = 0;
            int i = 0;

            while (i < 10)
            {
                Console.Write("Vnesi število: ");
                int x = int.Parse(Console.ReadLine());

                rezultat += x;
                i++;
            }
            Console.WriteLine("Vsota vpisanih števil je: {0}", rezultat);
            Console.ReadLine();
        }
    }
}
