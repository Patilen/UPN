using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vnesi število: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Leva poravnava");
            Console.WriteLine("1. število je:" + a);
            Console.WriteLine("2. število je:" + b);
            Console.WriteLine("3. število je:" + c);
            Console.WriteLine("4. število je:" + d);
            Console.WriteLine("5. število je:" + e);

            Console.WriteLine("Desna poravnava");
            Console.WriteLine("1. število je:" + "{0,10}", a);
            
            Console.WriteLine("2. število je:" + "{0,10}", b);

            Console.WriteLine("3. število je:" + "{0,10}", c);

            Console.WriteLine("4. število je:" + "{0,10}", d);

            Console.WriteLine("5. število je:" + "{0,10}", e);
            Console.ReadLine();











        }
    }
}
