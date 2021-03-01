// Napiši program, ki glede na vpisani stevili x in y izpiše (če je razlika 10 izpiše, da je razlika 10, če je razlika 100 izpiše, da je razlika 100, če nič od tega izpiše, da je razlika neznana). Nalogo reši z uporabo switch-case.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_5
{
    class Program5
    {
        static void Main(string[] args) // By Jon-Nik Gorenak, R-2.b
        {
            Console.WriteLine("Vnesi prvo številko:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Vnesi drugo številko:");
            int y = int.Parse(Console.ReadLine());

            switch (x - y)
            {
                case 10:
                    Console.WriteLine("Razlika je 10");
                    break;
                case 100:
                    Console.WriteLine("Razlika je 100");
                    break;
                default:
                    Console.WriteLine("Razlika je neznana");
                    break;
            }
            Console.ReadLine();
        }
    }
}
