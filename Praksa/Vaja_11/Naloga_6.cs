using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga6
{
    class Program6
    {
        static void Main(string[] args)
        {
            int rezultat = 0;
            int i = 0;
            int x = 1;
            while (x != 0)
            {
                Console.Write("Vnesi število: ");
                x = int.Parse(Console.ReadLine());

                if (x != 0)
                {
                    rezultat += ((x > 0) ? x : (x - (2 * x)));
                    i++;
                }
            }
            float povprecje = (float)rezultat / (float)i;
            Console.WriteLine("Povprečna vrednost je {0}", povprecje);
            Console.ReadLine();
        }
    }
}
