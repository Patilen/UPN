using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga8
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesite število: ");
            int stevilo = int.Parse(Console.ReadLine());

            int delitelj = 0;
            for (int i = 1; i <= stevilo; i++)
            {
                if (stevilo % i == 0)
                {
                    delitelj++;
                }
            }
            if (delitelj == 2)
            {
                Console.WriteLine("Število {0} je praštevilo", stevilo);
            }

            int j = 1;
            delitelj = 0;
            while (j <= stevilo)
            {
                if (stevilo % j == 0)
                {
                    delitelj++;
                }
                j++;
            }
            if (delitelj == 2)
            {
                Console.WriteLine("Število {0} je praštevilo", stevilo);
            }

            int k = 1;
            delitelj = 0;
            do
            {
                if (stevilo % k == 0)
                {
                    delitelj++;
                }
                k++;
            } while (k <= stevilo);
            if (delitelj == 2)
            {
                Console.WriteLine("Število {0} je praštevilo", stevilo);
            }
            // Program se upočasni pri velikih številih kot so: 104729
            // saj mora program tolikokrat izvesti
            Console.ReadLine();
        }
    }
}
