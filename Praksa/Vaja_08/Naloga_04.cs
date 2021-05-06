using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_04
{
    class Naloga_04
    {
        static void Main(string[] args)
        {

            int stevilo_1 = Convert.ToInt32(Console.ReadLine());
            int stevilo_2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nRezultat celoštevilskega deljenja je: " + stevilo_1 / stevilo_2 + " \nostanek pri deljenju je " + stevilo_1 % stevilo_2 );

            float matematicni_izracun = (float)stevilo_1 / (float)stevilo_2;

            Console.WriteLine("Rezultat matematično pravilnega izračuna je: " + matematicni_izracun);

            Console.ReadKey(true);
        }
    }
}
