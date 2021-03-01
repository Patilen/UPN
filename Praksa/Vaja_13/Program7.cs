using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga7
{
    class Program7
    {
        static void Main(string[] args)
        {
            char izbira = ' ';
            float x, y;
            for (; izbira != 'K';)
            {
                Console.WriteLine("(+)seštevanje\n(-)odštevanje\n(*)množenje\n(/)deljenje\n(K)konec");
                Console.Write("Vpiši izbiro: ");
                izbira = char.Parse(Console.ReadLine());

                if (izbira == '+')
                {
                    Console.Write("Vnesi število: ");
                    x = float.Parse(Console.ReadLine());

                    Console.Write("Vnesi število: ");
                    y = float.Parse(Console.ReadLine());

                    Console.WriteLine("Rezultat izbrane operacije je " + (x + y));
                }else if(izbira == '-')
                {
                    Console.Write("Vnesi število: ");
                    x = float.Parse(Console.ReadLine());

                    Console.Write("Vnesi število: ");
                    y = float.Parse(Console.ReadLine());

                    Console.WriteLine("Rezultat izbrane operacije je " + (x - y));
                }else if(izbira == '*')
                {
                    Console.Write("Vnesi število: ");
                    x = float.Parse(Console.ReadLine());

                    Console.Write("Vnesi število: ");
                    y = float.Parse(Console.ReadLine());

                    Console.WriteLine("Rezultat izbrane operacije je " + (x * y));
                }else if(izbira == '/')
                {
                    Console.Write("Vnesi število: ");
                    x = float.Parse(Console.ReadLine());

                    Console.Write("Vnesi število: ");
                    y = float.Parse(Console.ReadLine());

                    Console.WriteLine("Rezultat izbrane operacije je " + (x / y));
                }
            }
        }
    }
}
