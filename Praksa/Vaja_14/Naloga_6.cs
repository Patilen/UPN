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
            int vsotaplus = 0;
            int vsotamin = 0;
            int vsotaab = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int x = rnd.Next(-200, 200);
                Console.WriteLine(i + ". število: " + x);
                
                if (x < 0)
                {
                    vsotamin += x;
                    x = -x;
                    vsotaab += x;
                }
                else if (x > 0)
                {
                    vsotaplus += x;
                    vsotaab += x;
                }
            }
            Console.WriteLine("Vsota pozitivnih števil je " + vsotaplus + ", vsota negativnih števil je " + vsotamin + ", vsota absolutnih vrednosti pa " + vsotaab);
            Console.WriteLine();
            vsotaplus = 0;
            vsotamin = 0;
            vsotaab = 0;
            int j = 1;

            while (j <= 10)
            {
                int x = rnd.Next(-200, 200);
                Console.WriteLine(j + ". število: " + x);

                if (x < 0)
                {
                    vsotamin += x;
                    x = -x;
                    vsotaab += x;
                }
                else if (x > 0)
                {
                    vsotaplus += x;
                    vsotaab += x;
                }
                j++;
            }
            Console.WriteLine("Vsota pozitivnih števil je " + vsotaplus + ", vsota negativnih števil je " + vsotamin + ", vsota absolutnih vrednosti pa " + vsotaab);
            Console.WriteLine();
            vsotaab = 0;
            vsotamin = 0;
            vsotaplus = 0;
            int k = 1;

            while (k <= 10)
            {
                int x = rnd.Next(-200, 200);
                Console.WriteLine(k + ". število: " + x);

                if (x < 0)
                {
                    vsotamin += x;
                    x = -x;
                    vsotaab += x;
                }
                else if (x > 0)
                {
                    vsotaplus += x;
                    vsotaab += x;
                }
                k++;
            }
            Console.WriteLine("Vsota pozitivnih števil je " + vsotaplus + ", vsota negativnih števil je " + vsotamin + ", vsota absolutnih vrednosti pa " + vsotaab);
            Console.ReadLine();
        }
    }
}
