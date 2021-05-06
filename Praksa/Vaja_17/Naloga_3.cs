/*Napiši program, kjer uporabnik vnese znak + ali – in nato še dve celi števili.
Če je vpisan znak +, program sešteje dve vpisani števili in izpiše rezultat,
če je  vpisan znak minus, program vpisani števili odšteje in izpiše rezultat.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga03
{
    class Program3
    {
        static void Main(string[] args)
        {
            char znak;
            int st1, st2;
            int rez = 0;
            Console.WriteLine("Vnesi + ali - ");
            znak = char.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi prvo število: ");
            st1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi drugo število: ");
            st2 = int.Parse(Console.ReadLine());
            if (znak == '+')
                rez = st1 + st2;
            else if (znak == '-')
                rez = st1 - st2;
            Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}
