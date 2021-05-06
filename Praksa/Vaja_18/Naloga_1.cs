/*Spodnje metode kopirajte v vaš projekt in z njihovo pomočjo naredite glavni program. Metod ne spreminjajte!
a)	Narišete tri črte dolžine 40 (med vsako črto naj bo prosta vrstica). Uporabite metodo NarisiCrto40.
b)	Nato izračunajte vsoto števil 10 in 20 in rezultat izpiši v obliki: "Vsota števil 10 in 20 je ..". Uporabi metodo SestejStevili1.
c)	Nato izračunajte vsoto števil 10 in 20 in rezultat izpiši v obliki: "Vsota števil 10 in 20 je ..". Uporabi metodo SestejStevili2.
d)	Nato naredi prosto vrstico.
e)	Nato nariše črto z dolžino 30. Uporabi metodo NarisiCrto.
f)	Nato uporabnik vnese dve celi števili in izračuna vsoto teh dveh števil. Program dobljeno vsoto izpiše v  obliki: "Vsota števil x in y je vsota". Uporabi metodo SestejStevili2.
g)	Nato uporabnik vnese še dve celi števili in izračuna vsoto teh dveh števil. Rezultat shrani v spremenljivko z imenom vsota. Uporabi metodo SestejStevili1.
h)	Dobljeno vsoto nato deli z 10 in rezultat shrani v spremenljivko (realno število) z imenom kolicnik. Količnik nato izpiši izpiši v obliki :" Količnik števil .. in 10 je ..".
i)	Kopirajte kodo, ki ste jo naredili v koraku g. Namesto SestejStevili1 uporabite metodo SestejStevili2. Kaj ugotovite? Ugotovitev zapišite kot komentar v program.
j)	Narišite črto z dolžino 80. Uporabi metodo NarisiCrto40.


Metode:
        static void NarisiCrto40()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void NarisiCrto( int dolzina )
        {
            for (int i = 0; i < dolzina ; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static int SestejStevili1( int a, int b )
        {
            int vsota;
            vsota = a + b;
            return (vsota);
        }

        static void SestejStevili2( int a, int b )
        {
            int vsota;
            vsota = a + b;
            Console.Write(vsota);
        }

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga01
{
    class Program1
    {
        static void NarisiCrto40()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void NarisiCrto(int dolzina)
        {
            for (int i = 0; i < dolzina; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static int SestejStevili1(int a, int b)
        {
            int vsota;
            vsota = a + b;
            return (vsota);
        }

        static void SestejStevili2(int a, int b)
        {
            int vsota;
            vsota = a + b;
            Console.Write(vsota);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                NarisiCrto40();
            }
            Console.WriteLine("Vsota števil 10 in 20 je {0}.", SestejStevili1(10, 20));
            Console.Write("Vsota števil 10 in 20 je ");
            SestejStevili2(10, 20);
            Console.WriteLine(" ");
            NarisiCrto(30);
            Console.WriteLine("Vpiši prvo število:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši drugo število:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Vsota števil {0} in {1} je ", a, b);
            SestejStevili2(a, b);
            Console.WriteLine();
            Console.WriteLine("Vpiši prvo število:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši drugo število:");
            int d = int.Parse(Console.ReadLine());
            int vsota = SestejStevili1(c, d);
            double kolicnik = vsota / 10;
            Console.WriteLine("Količnik števil {0} in 10 je {1}.", vsota, kolicnik);
            for (int j = 0; j<2;j++)
            {
                NarisiCrto40();
            }
            Console.ReadKey();
            // pri i primeru rezultata ni mogoče shraniti v spremenljivko, ker je metoda void in ne podatkovni tip, ki bi kaj vračal
        }
    }
}