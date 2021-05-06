using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_08
{
    class Naloga_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi prvo število");
            double stevilo_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vnesi drugo število");
            double stevilo_2 = Convert.ToDouble(Console.ReadLine());
            double rezultat;

            rezultat = (double)stevilo_1 / (double)stevilo_2; // (Double) zaradi manjše napakice pri izračunih

            Console.WriteLine("Količnik števila je " + (double)rezultat);

            Console.ReadKey(true);

        }
    }
}
