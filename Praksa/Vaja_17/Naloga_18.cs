/*Leta 2000 je bila dolžina kapnika 3 mm, nato pa se vsakih 10 let poveča za 6 mm.
Napiši program, s katerim boš ugotovil in nato izpisal, kolikšna bo višina kapnika
leta 2020 in katerega leta bo dosegel višino 1,5 m ?*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga18
{
    class Program18
    {
        static void Main(string[] args)
        {
            int dolzina = 3, vmesna = 0;
            int leto = 2000;
            for (; dolzina <= 1500; leto += 10, dolzina += 6)
            {
                if (leto == 2020)
                    vmesna = dolzina;
            }
            Console.WriteLine("Višina kapnika leta 2020 bo {0}mm. Višino 1,5m bo dosegel leta {1}.", vmesna, leto);
            Console.ReadKey();

        }
    }
}
