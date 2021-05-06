using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga02
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi dve števili");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Vnesi dve števili");
            float y = float.Parse(Console.ReadLine());

            float kolicnik = x / y;
            Console.WriteLine(kolicnik);
            Console.ReadLine();
        }
    }
}
