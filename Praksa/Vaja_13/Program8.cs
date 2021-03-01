using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga8
{
    class Program8
    {
        static void Main(string[] args)
        {
            float vsota = 0;
            for (;vsota <= 1000;)
            {
                Console.Write("Vnesi število: ");
                float x = float.Parse(Console.ReadLine());
                
                if (x == -999)
                {
                    break;
                }
                else
                {
                    vsota += x;
                    Console.WriteLine("Vsota je: {0,10:F5}", vsota);
                }
            }
            Console.WriteLine("Presegli ste vsoto števil 1000 ali pa vnesli število -999");
            Console.ReadLine();
        }
    }
}
