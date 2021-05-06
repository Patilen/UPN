/*Napišite definiciji metod:
a)	1. metoda
o	ime metode: Razlika
o	vhodni podatki: dve celi števili
o	izhodni podatki: celo število
o	kaj dela metoda: izračuna razliko
b)	2. metoda
o	ime metode: Kolicnik
o	vhodni podatki: dve celi števili
o	izhodni podatki: realno število
o	kaj dela metoda: izračuna količnik
c)	3. metoda
o	ime metode: IzpisCelo
o	vhodni podatki: eno celo število
o	izhodni podatki: ni
o	kaj dela metoda: izpiše število
d)	4. metoda
o	ime metode: IzpisRealno
o	vhodni podatki: eno realno število
o	izhodni podatki: ni
o	kaj dela metoda: izpiše število


V glavnem naj uporabnik vnese dve celi števili. Nato z metodami izračunaj razliko in količnik teh dveh števil in ju shrani v spremenljivki. Razliko v celo število, količnik v realno število. Oba rezultata izpiši.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga02
{
    class Program2
    {
        static int Razlika(int a, int b)
        {
            int razlika = a - b;
            return razlika;
        }
        static double Kolicnik(int a, int b)
        {
            double kolicnik = a / b;
            return kolicnik;
        }
        static void IzpisCelo(int a)
        {
            Console.WriteLine("Razlika vpisanih števil je {0}.", a);
        }
        static void IzpisRealno(double a)
        {
            Console.WriteLine("Količnik vpisanih števil je {0}.", a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši prvo število:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši drugo število:");
            int y = int.Parse(Console.ReadLine());
            IzpisCelo(Razlika(x,y));
            IzpisRealno(Kolicnik(x, y));
            Console.ReadKey();
        }
    }
}
