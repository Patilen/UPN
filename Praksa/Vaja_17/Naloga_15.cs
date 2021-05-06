/*Napiši program, kjer uporabnik vpiše koordinate pravokotnika (višino, širino).
Program nato izriše pravokotnik iz znakov "x".*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga15
{
    class Program15
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Vnesi višino pravokotnika: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi širino pravokotnika: ");
            b = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("x");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
