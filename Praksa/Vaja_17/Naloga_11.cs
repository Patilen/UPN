//Napiši program, ki izpiše 10 naključnih števil. Med števili naj bo presledek.
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
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(r.Next(1000) + " ");
            }
            Console.ReadKey();
        }
    }
}
