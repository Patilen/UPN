/*Napiši metodo z imenom IzpisiIme. Metoda ima en parameter tipa string. Metoda izpiše ime,  ki vstopi v metodo kot parameter.

V glavnem programu uporabi metodo IzpisiIme. Uporabi tvoje ime kot vhodni podatek.

Nato, prav tako v glavnem programu, uporabnika povprašaj po imenu in njegovo ime shrani v spremenljivko. To ime (spremenljivka) naj bo vhod v metodo IzpisiIme. Za branje imena uporabi metodo PreberiIme, ki jo kopiraj iz prejšnje naloge, za izpis imena pa metodo IzpisiIme. Pred izpisom povprašaj uporabnika, kolikokrat želi izpisati svoje ime in ga s pomočjo metode IzpisiIme  tolikorat izpiši.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga07
{
    class Program7
    {
        static string PreberiIme()
        {
            Console.WriteLine("Vpiši svoje ime:");
            string ime = Console.ReadLine();
            return ime;
        }
        static void IzpisiIme(string a)
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            string ime = PreberiIme();
            Console.WriteLine("Kolikokrat želiš izpisati svoje ime?");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                IzpisiIme(ime);
            }
            Console.ReadKey();
        }
    }
}
