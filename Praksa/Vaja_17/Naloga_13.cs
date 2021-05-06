/*Napiši program, ki generira 1000 naključnih števil med 1 in 100, ki so deljiva s 3 ali 19.
Izpiše naj, koliko jih je bilo med 1 in 50 in koliko med 51 in 100.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga13
{
    class Program13
    {
        static void Main(string[] args)
        {
            int rnd = 0, vec = 0, manj = 0;
            Random r = new Random();
            for (int i = 0; i < 1000;)
            {
                rnd = r.Next(1, 100);
                if (rnd % 3 == 0 || rnd % 19 == 0)
                {
                    if (rnd < 51)
                        manj++;
                    else
                        vec++;
                    i++;
                }
            }
            Console.WriteLine("Med 1 in 50 je bilo {0} števil, med 51 in 100 pa {1} števil.", manj, vec);
            Console.ReadKey();
        }
    }
}
