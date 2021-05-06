using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga09
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi št. prevoženih kilometrov: ");
            int st_prevoz_km = int.Parse(Console.ReadLine());

            Console.Write("Vnesi št. litrov, ki smo jih vnesli: ");
            int st_litrov = int.Parse(Console.ReadLine());

            Console.Write("Poraba na 100km: ");
            int poraba = int.Parse(Console.ReadLine());

            float poraba_skupaj = (float)st_litrov * 100 / st_prevoz_km;

            Console.WriteLine("Poraba je {0:f} litrov", poraba);
            Console.ReadLine();
        }
    }
}
