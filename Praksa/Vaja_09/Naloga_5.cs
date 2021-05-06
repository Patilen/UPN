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
            Console.Write("Vnesi ime: ");
            string ime = Console.ReadLine();

            Console.Write("Vnesi ime: ");
            string ime2 = Console.ReadLine();

            if (ime == ime2)
            {
                Console.WriteLine("Imeni sta enaki.");
            }else if(String.Compare(ime, ime2) < 0)
            {
                Console.WriteLine("Manjši po abecedi je: " + ime);
            }
            else
            {
                Console.WriteLine("Manjši po abecedi je: " + ime2);
            }
            Console.ReadLine();
        }
    }
}
