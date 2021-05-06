/*Napiši metodo z imenom JazVOkvircku. Metoda naj izpiše tvoje ime in priimek, okoli njiju pa okvirček iz zvezdic.
V glavnem programu uporabi metodo v zanki, tako da po vsakem izpisu vprašaš uporabnika, ali želi še en izpis.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga05
{
    class Program5
    {
        static void JazVOkvircku(string a, string b)
        {
            int dolzina = a.Length + b.Length + 3;
            for (int i = 0; i <3; i++)
            {
                if (i == 0 || i == 2)
                {
                    for (int j = 0; j < dolzina; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else if(i==1)
                {
                    Console.WriteLine("*{0} {1}*", a, b);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši svoje ime:");
            string a = Console.ReadLine();
            Console.WriteLine("Vpiši svoj priimek:");
            string b = Console.ReadLine();
            for (string x = "da"; x == "da";)
            {
                JazVOkvircku(a, b);
                Console.WriteLine("Ali želiš ponoven izpis? (da/ne)");
                x = Console.ReadLine().ToLower();
            }
            Console.ReadKey();
        }
    }
}
