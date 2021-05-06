using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_08
{
    class Naloga_08
    {
        static void Main(string[] args)
        {
            int st = Convert.ToInt32(Console.ReadLine());

            int enice = (st % 10);
            int desetice = (st % 100) / 10;
            int stotice = (st % 1000) / 100;
            int tisocice = (st % 10000) / 1000;

            Console.WriteLine("\nEnice: " +enice + "\nDesetice: "+ desetice + "\nStotice: "+ stotice + "\nTisočice: " + tisocice);

            Console.ReadKey(true);
        }
    }
}
