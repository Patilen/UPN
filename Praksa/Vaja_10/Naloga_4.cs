// Napiši program, ki glede na vpisan znak izpiše spol (m,M - moski, z,Z - zenski, za vse ostale pa "vpisali ste napacen spol"). Nalogo reši z uporabo switch-case.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    class Program4
    {
        static void Main(string[] args) // By Jon-Nik Gorenak, R-2.b
        {
            Console.Write("Vnesi spol: ");
            char spol = Convert.ToChar(Console.ReadLine());
            
            spol = Char.ToLower(spol);

            switch (spol)
            {
                case 'm':
                    Console.WriteLine("Moski");
                    break;
                case 'z':
                    Console.WriteLine("Zenski");
                    break;
                default:
                    Console.WriteLine("Vpisali ste napačen spol");
                    break;
            }
            Console.ReadLine();
        }
    }
}
