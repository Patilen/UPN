/*Včasih se zgodi, da ne moreš zaspati, štetje ovčk pa te samo še bolj razbudi, ker se pri tem štetju nenehno motiš.
Napiši del programa program, ki vam bo štel ovčke namesto tebe. Da pa ne bo program po nepotrebnem štel predolgo,
naj te ob vsaki stoti prešteti ovčki vpraša, če želiš nadaljevati s štetjem ali pa naj prekine.
Napiši več verzij, tako ki bo uporabila:
	eno samo zanko
	zanko v zanki
	neskončno zanko in break
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga14
{
    class Program14
    {
        static void Main(string[] args)
        {
            string nad = "";
            int i = 0;
            while (nad.ToUpper() != "DA")
            {
                i++;
                if (i % 100 == 0)
                {
                    Console.WriteLine("Želiš nadaljevati s štetjem?");
                    nad = Console.ReadLine();
                }
            }

            while (nad.ToUpper() != "DA")
            {
                for (int n = 0; n <= 100; n++)
                {

                }
                Console.WriteLine("Želiš nadaljevati s štetjem?");
                nad = Console.ReadLine();
            }
            i = 0;
            while (true)
            {
                i++;
                if (i % 100 == 0)
                {
                    Console.WriteLine("Želiš nadaljevati s štetjem?");
                    nad = Console.ReadLine();
                    if (nad.ToUpper() == "DA")
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
