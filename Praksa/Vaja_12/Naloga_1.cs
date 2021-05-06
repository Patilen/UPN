using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int zmnozek = 1;
            int x = 1;
            do
            {
                Console.Write("Vnesi število: ");
                x = int.Parse(Console.ReadLine());

                if (x != 0)
                    zmnozek *= x;
            } while (x != 0);
            Console.WriteLine("Zmnožek števil je {0}", zmnozek);
            Console.ReadLine();
        }
    }
}
