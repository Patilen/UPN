/*Napišite program, ki bo uporabnika povprašal po dveh znakih in enem celem številu.
Če je vpisano število pozitivno, bo izpisal najprej prvi znak in takoj za njim drugega, drugače pa ravno obratno.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga01
{
    class Program1
    {
        static void Main(string[] args)
        {
            char znak1, znak2;
            int stevilo;
            Console.WriteLine("Vnesi prvi znak: ");
            znak1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi drug znak: ");
            znak2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število: ");
            stevilo = int.Parse(Console.ReadLine());

            if (stevilo > 0)
                Console.WriteLine(znak1 + " " + znak2);
            else
                Console.WriteLine(znak2 + " " + znak1);
            Console.ReadKey();
        }
    }
}
