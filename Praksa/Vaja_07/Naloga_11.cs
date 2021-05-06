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
            Console.WriteLine("Vnesi čas v milisekundah: ");
            uint cas_mili = uint.Parse(Console.ReadLine());

            int sekunde = (int)cas_mili / 1000;
            float minute = (float)sekunde / 60;
            float ure = minute / 60;
            float dni = ure / 24;
            Console.WriteLine("{0} milisekund je {1} sekund, {2} minut, {3} ur in {4} dni.", cas_mili, sekunde, minute, ure, dni);
            Console.ReadLine();

        }
    }
}
