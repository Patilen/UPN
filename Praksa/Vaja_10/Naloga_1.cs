using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_1
{
    class Program1
    {
        static void Main(string[] args)  // By Jon-Nik Gorenak, R-2.b
        {
            Console.WriteLine("Vnesi število: ");
            int obmocje = int.Parse(Console.ReadLine());

            switch (obmocje)
            {
                case 1:
                    Console.WriteLine("Vroče");
                    break;
                case 2:
                    Console.WriteLine("Toplo");
                    break;
                case 3:
                    Console.WriteLine("Mrzlo");
                    break;
                default:
                    Console.WriteLine("Izven območja!");
                    break;
            }
            Console.ReadLine();
        }
    }
}

 // Napiši program, ki v prebere temperaturno območje (1 - vroče, 2 - toplo, 3 - mrzlo, ostale vrednosti - izven območja!) in izpiše, katero območje je bilo izbrano. Nalogo reši z uporabo switch-case. //
