using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPN_TEORIJA_22_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Napiši program ki prebere dve števili A in B prvo število izpiše tolikokrat kot je vrednost drugega števila */

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine(a);
                i++;
            }
            while (i <= b);

            Console.ReadKey(true);

        }
    }
}

