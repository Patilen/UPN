using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i = 0;
            string ime = "";
            do
            {
                Console.Write("Vnesi ime: ");
                ime = Console.ReadLine();

                if (ime != "KONEC")
                {
                    i++;
                }
            } while (ime != "KONEC");
            Console.WriteLine("Vnešeno število imen: {0}", i);
            Console.ReadLine();
        }
    }
}
