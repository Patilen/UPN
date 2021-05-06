using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga6
{
    class Program6
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int skrivnoStevilo = rnd.Next(0, 100);
            Console.WriteLine("Uganite število med 0 in 100");
            int i = 1;
            for (; ;i++)
            {
                Console.Write("Vnesi število: ");
                int x = int.Parse(Console.ReadLine());

                if (x == skrivnoStevilo || i == 10)
                {
                    break;
                }
                else
                {
                    if (x > skrivnoStevilo)
                    {
                        Console.WriteLine("Skrito število je manjše");
                    }
                    else
                    {
                        Console.WriteLine("Skrito število je večje");
                    }
                }
            }
            if (i == 10)
            {
                Console.WriteLine("Poteklo vam je število poskusov");
            }
            else
            {
                Console.WriteLine("Uganili ste število");
            }
            Console.ReadLine();
        }
    }
}
