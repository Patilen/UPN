using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga5
{
    class Program5
    {
        static void Main(string[] args)
        {
            int i = 100;
            do
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 300);
            Console.ReadLine();
        }
    }
}
