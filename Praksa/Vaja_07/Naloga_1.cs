using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi celo število: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vnesi celo število: ");
            int y = Convert.ToInt32(Console.ReadLine());

            float kolicnik = x / y;
            Console.WriteLine(kolicnik);
            Console.ReadLine();

            // Rezultat ni pravilen saj se števili delita kot int

        }
    }
}