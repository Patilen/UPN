// Napiši program, ki glede na vpisan znak izpiše barvo (r,R - rdeča, m,M - modra, z,Z - zelena, b,B - bela, za vse ostale pa črna).Nalogo reši z uporabo switch-case. //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_2
{
    class Program2
    {
        static void Main(string[] args)  // By Jon-Nik Gorenak, R-2.b
        {
            Console.WriteLine("Vnesi ime barve:");
            char barva = Convert.ToChar(Console.ReadLine());

            switch (barva)
            {
                case 'r':
                    Console.WriteLine("Rdeča");
                    break;
                case 'm':
                    Console.WriteLine("Modra");
                    break;
                case 'z':
                    Console.WriteLine("Zelena");
                    break;
                case 'b':
                    Console.WriteLine("Bela");
                    break;
                default:
                    Console.WriteLine("Črna");
                    break;
            }
            Console.ReadLine();
        }
    }
}
