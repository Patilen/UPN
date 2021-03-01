// Napiši program, ki iz vpisane dvočrkovne ali tročrkovne kratice dneva izpiše dan v tednu s celotno besedo. Nalogo reši z uporabo switch-case.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_6
{
    class Program6
    {
        static void Main(string[] args) // By Jon-Nik Gorenak, R-2.b
        {
            Console.Write("Vpiši dvočrkovno ali tročrkovno kratico: ");
            string dan = (Console.ReadLine());
            dan = dan.ToLower();

            switch (dan)
            {
                case "po":
                case "pon":
                    Console.WriteLine("Ponedeljek");
                    break;
                case "to":
                case "tor":
                    Console.WriteLine("Torek");
                    break;
                case "sr":
                case "sre":
                    Console.WriteLine("Sreda");
                    break;
                case "če":
                case "čet":
                    Console.WriteLine("Četrtek");
                    break;
                case "pe":
                case "pet":
                    Console.WriteLine("Petek");
                    break;
                case "so":
                case "sob":
                    Console.WriteLine("Sobota");
                    break;
                case "ne":
                case "ned":
                    Console.WriteLine("Nedelja");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
        }
    }
}
