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
            float rezultatpoz = 0;
            float rezultatneg = 0;

            int i = 0;
            while (i < 20)
            {
                Console.Write("Vnesi število: ");
                float x = float.Parse(Console.ReadLine());

                if (x > 0)
                {
                    rezultatpoz += x;
                }
                else
                {
                    rezultatneg += x;
                }
                i++;
            }
            Console.WriteLine("Vsota pozitivnih števil je {0} , vsota negativnih števil je {1}", rezultatpoz, rezultatneg);
            Console.ReadLine();
        }
    }
}
