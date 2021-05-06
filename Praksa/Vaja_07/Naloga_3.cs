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
            Console.Write("Vnesi število: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vnesi število: ");
            int y = Convert.ToInt32(Console.ReadLine());

            float kolicnik = (float)x / y;
            Console.WriteLine("{0,10:f}", kolicnik);
            Console.ReadLine();
        }
    }
}
