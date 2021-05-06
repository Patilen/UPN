using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga7
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi znak / ali * : ");
            char x = char.Parse(Console.ReadLine());

            if (x == '*')
            {
                Console.Write("Vnesi prvo celo število: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Vnesi drugo celo število: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Zmnožek teh dve števil je: " + (a * b));
            }else if (x == '/')
            {
                Console.Write("Vnesi prvo število: ");
                float c = float.Parse(Console.ReadLine());

                Console.Write("Vnesi drugo število: ");
                float d = float.Parse(Console.ReadLine());

                if (d == 0)
                {
                    Console.WriteLine("Deljenje z nič ni mogoče.");
                }
                else
                {
                    float rezultat = c / d;
                    Console.WriteLine("Rezultat deljenja je: " + rezultat);
                }
            }
            else
            {
                Console.WriteLine("Napaka pri vnosu.");
            }
            Console.ReadLine();
        }
    }
}
