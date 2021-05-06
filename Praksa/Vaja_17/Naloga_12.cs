//Napiši program, ki izpiše 10 naključnih števil med 10 in 20002 deljivih z 12. Med števili naj bo presledek.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga12
{
    class Program12
    {
        static void Main(string[] args)
        {
            int rnd = 0;
            Random r = new Random();
            for (int i = 0; i < 10;)
            {
                rnd = r.Next(10, 20002);
                if (rnd % 12 == 0)
                {
                    Console.Write(rnd + " ");
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
