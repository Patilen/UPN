using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga10
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi porabo na 100km: ");
            double poraba_km = float.Parse(Console.ReadLine());

            double poraba_mg = (1 / 1.609344) / (1 / 3.7854);

            double poraba = poraba_km * poraba_mg;
            Console.WriteLine("Poraba {0} km / 1 je {1:f} mpg.", poraba_km, poraba);
            Console.ReadLine();

        }
    }
}
