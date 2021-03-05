using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga7
{
    class Program7
    {
        static void Main(string[] args)
        {
            float rezultat = 0;
            while (rezultat < 1000)
            { 
                Console.Write("Vnesi število: ");
                float x = float.Parse(Console.ReadLine());

                rezultat += x;
            }
            Console.WriteLine("Vsota vpisanih vrednosti je {0}", rezultat);
            Console.ReadLine();
        }
    }
}
