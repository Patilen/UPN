using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga7
{
    class Program7
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            float vecje = 0;
            float manjse = 0;
            for (int i = 0; i < 100; i++)
            {
                int x = rnd.Next(1, 100);

                if (x >= 1 && x <= 50)
                {
                    manjse += 1;
                }
                else
                {
                    vecje += 1;
                }
            }
            float procenti = (manjse / (manjse + vecje) * 100);
            float precenti2 = 100 - procenti;
            Console.WriteLine(manjse + " (" + procenti + " %)" + " je bilo števil, ki so bila med 1 in 50, " + vecje + " (" + precenti2 + " %)" + " je bilo števil, ko so bila med 51 in 100");

            // 5- 40% : 60%
            // 10 - 50% : 50%
            // 100 - 46% : 54%
            // 1000 - 52% : 48%
            // 10000 - 51,08% : 48,92%
            // 100000 - 50,255% : 49,745%
            Console.WriteLine();
            vecje = 0;
            manjse = 0;
            procenti = 0;
            precenti2 = 0;
            int j = 0;
            while (j < 100)
            {
                int x = rnd.Next(1, 100);

                if (x >= 1 && x <= 50)
                {
                    manjse += 1;
                }
                else
                {
                    vecje += 1;
                }
                j++;
            }
            procenti = (manjse / (manjse + vecje) * 100);
            precenti2 = 100 - procenti;
            Console.WriteLine(manjse + " (" + procenti + " %)" + " je bilo števil, ki so bila med 1 in 50, " + vecje + " (" + precenti2 + " %)" + " je bilo števil, ko so bila med 51 in 100");
            Console.WriteLine();

            vecje = 0;
            manjse = 0;
            procenti = 0;
            precenti2 = 0;
            int k = 0;
            do
            {
                int x = rnd.Next(1, 100);

                if (x >= 1 && x <= 50)
                {
                    manjse += 1;
                }
                else
                {
                    vecje += 1;
                }
                k++;
            } while (k < 100);
            procenti = (manjse / (manjse + vecje) * 100);
            precenti2 = 100 - procenti;
            Console.WriteLine(manjse + " (" + procenti + " %)" + " je bilo števil, ki so bila med 1 in 50, " + vecje + " (" + precenti2 + " %)" + " je bilo števil, ko so bila med 51 in 100");
            Console.ReadLine();
        }
    }
}