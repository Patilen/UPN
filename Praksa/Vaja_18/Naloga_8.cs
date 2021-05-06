/*Napiši metodo z imenom Sestej1. Metoda ime tri vhodne parametre,  ki so realna števila, vrača pa vsoto vhodnih parametrov.

V glavnem programu uporabi funkcijo Sestej1. Seštej števila 3.2, -999 in 22.32.

Nato naj še uporabnik vpiše tri števila (v glavnem programu). Uporabi metodo Sestej1 s števili, ki jih je vnesel uporabnik in izpiši v glavnem programu.

Nato še dvakrat uporabi metodo Seštej1, in shrani rezultat vseh treh seštevanj uporabnikovih števil v neko spremenljivko ter izpiši skupno vsoto.

Napiši še metodo Sestej2, ki se bo od Sestej1 razlikovala po tem, da bo že sama metoda izpisala rezultat, vračala pa ne bo ničesar.  Z novo metodo poskusi narediti vse stvari, ki si jih s prejšnjo. Primerjaj obe metodi, napiši prednosti in slabosti!

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga08
{
    class Program8
    {
        static double Sestej1(double a, double b, double c)
        {
            double vsota = a + b + c;
            return vsota;
        }

        static void Sestej2(double a, double b, double c)
        {
            double vsota = a + b + c;
            Console.WriteLine(vsota);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši število:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši število:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši število:");
            double c = double.Parse(Console.ReadLine());
            double skupnaVsota = 0;
            for (int i = 0; i < 3; i++)
            {
                skupnaVsota += Sestej1(a, b, c);
            }
            Console.WriteLine("Skupna vsota je {0}.", skupnaVsota);
            Console.ReadKey();
            // metodo Sestej1 je veliko lažje uporabiti, saj vrača vsoto, ki jo lahko brez težav shranimo v spremenljivko ali pa jo direktno uporabimo v glavnem programu.
        }
    }
}
