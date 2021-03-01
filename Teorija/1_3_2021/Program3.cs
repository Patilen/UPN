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
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(rnd.Next());
            }
            Console.ReadLine();
        }
    }
}
