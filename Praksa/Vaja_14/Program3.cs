using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(rnd.Next(100));
            }

            int j = 0;
            while (j < 100)
            {
                Console.WriteLine(rnd.Next(100));
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(rnd.Next(100));
                k++;
            } while (k < 100);
            Console.ReadLine();
        }
    }
}
