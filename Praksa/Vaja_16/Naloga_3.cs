using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3
{
    class Program3
    {
        static void Main(string[] args)
        {
            float rezultat = 0;
            int i = 0;
            while (true)
            {
                Console.Write("Vnesi število: ");
                float x = float.Parse(Console.ReadLine());

                if (x == 0)
                {
                    break;
                }
                else
                {
                    i++;
                    rezultat += x;
                    Console.WriteLine("Vsota je {0}", rezultat);
                }
            }
            Console.WriteLine("Povprečje je {0}", (rezultat / i));
            Console.ReadLine();
        }
    }
}
