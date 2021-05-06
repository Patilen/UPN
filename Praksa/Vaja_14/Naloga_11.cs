using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga11
{
    class Program11
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi prvo število: ");
            int prvo = int.Parse(Console.ReadLine());

            Console.Write("Vnesi drugo število: ");
            int drugo = int.Parse(Console.ReadLine());

            int vsota = 0;
            int vsota2 = 0;
            for (int i = 1; i < prvo; i++)
            {
                if (prvo % i == 0)
                {
                    vsota += i;
                }
            }
            for (int j = 1; j < drugo; j++)
            {
                if (drugo % j == 0)
                {
                    vsota2 += j;
                }
            }
            if (vsota == drugo && vsota2 == prvo)
            {
                Console.WriteLine("Števili {0} in {1} sta si prijateljski", vsota2, vsota);
            }

            vsota = 0;
            vsota2 = 0;
            int k = 1;
            int l = 1;
            while (k < prvo)
            {
                if (prvo % k == 0)
                {
                    vsota += k;
                }
                k++;
            }
            while (l < drugo)
            {
                if (drugo % l == 0)
                {
                    vsota2 += l;
                }
                l++;
            }
            if (vsota == drugo && vsota2 == prvo)
            {
                Console.WriteLine("Števili {0} in {1} sta si prijateljski", vsota2, vsota);
            }

            vsota = 0;
            vsota2 = 0;
            int m = 1;
            int n = 1;
            do
            {
                if (prvo % m == 0)
                {
                    vsota += m;
                }
                m++;
            } while (m < prvo);
            do
            {
                if (drugo % n == 0)
                {
                    vsota2 += n;
                }
                n++;
            } while (n < drugo);
            if (vsota == drugo && vsota2 == prvo)
            {
                Console.WriteLine("Števili {0} in {1} sta si prijateljski", vsota2, vsota);
            }
            Console.ReadLine();
        }
    }
}
