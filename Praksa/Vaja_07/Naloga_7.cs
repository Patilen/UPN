using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga07
{
    class Program7
    {
        static void Main(string[] args)
        {
            int x = 9, y = 4;
            float a = 2.5f;

            a += x++ - (float)y-- / ++a;

            Console.WriteLine("x je {0}, Y = {1} in A je {2}", x, y, a);
            Console.ReadLine();

       }
    }
}
