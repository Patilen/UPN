using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operacija deljenja ki bo sprejel operaciji M in N in izračuna deljenje z odštevanjem.
            Console.WriteLine("Vnesi številko");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vnesi številko");
            int n = Convert.ToInt32(Console.ReadLine());

            int deljenec = m;
            int deljitelj = n;
            int faktor= 0;
            while (m >= n)
            {
                m = m - n;
                faktor++;

            }

            int ostanek = m;
            Console.WriteLine(deljenec + " / " + deljitelj + " = " + faktor + ", ostanek " + ostanek);
            Console.ReadKey(true);

        }
    }
}
