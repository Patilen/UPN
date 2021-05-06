using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga08
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi število: ");
            int x = int.Parse(Console.ReadLine());

            int enice = x % 10;
            x = x / 10;
            int desetice = x % 10;
            x = x / 10;
            int stotice = x % 10;
            x = x / 10;
            int tisocice = x % 10;

            Console.WriteLine(enice + "e " + desetice + "d " + stotice + "s " + tisocice + "t ");
            Console.ReadLine();
        }
    }
}
