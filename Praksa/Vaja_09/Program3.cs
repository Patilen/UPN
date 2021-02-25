using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Vnos: ");
            char x = char.Parse(Console.ReadLine());

            if (char.IsNumber(x))
            {
                Console.WriteLine("Vnos je število.");
            }else if (char.IsLetter(x))
            {
                Console.WriteLine("Vnos je znak.");
            }

            else
            {
                Console.WriteLine("Vnos je nekaj drugega.");
            }
            Console.ReadLine();
        }
    }
}
