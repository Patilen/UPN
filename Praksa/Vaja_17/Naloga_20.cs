/*Napiši, katera polja napada trdnjava, če jo postavimo na šahovnico. Vhodni podatek so koordinate x,y.
Napiši še program, ki izpiše enako za kraljico.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga20
{
    class Program20
    {
        public static char XOs(int a)
        {
            char c = ' ';
            switch (a)
            {
                case 1:
                    c = 'a';
                    break;
                case 2:
                    c = 'b';
                    break;
                case 3:
                    c = 'c';
                    break;
                case 4:
                    c = 'd';
                    break;
                case 5:
                    c = 'e';
                    break;
                case 6:
                    c = 'f';
                    break;
                case 7:
                    c = 'g';
                    break;
                case 8:
                    c = 'h';
                    break;
            }
            return c;
        }


        public static void nav(int x, int y)
        {
            Console.Write("|\t");
            for (int n = 1; n <= 8; n++)
            {
                if (n != y)
                    Console.Write(XOs(x).ToString() + n + " ");
            }
            Console.Write("\n");
        }
        public static void horiz(int x, int y)
        {
            Console.Write("--\t");
            for (int n = 1; n <= 8; n++)
            {
                if (n != x)
                    Console.Write(XOs(n).ToString() + y + " ");
            }
            Console.Write("\n");
        }
        public static void diag(int x, int y)
        {
            Console.Write("/\t");
            for (int n = x, m = y; n > 0 && m > 0; n--, m--)
            {
                if ((n - 1) > 0 && (m - 1) > 0)
                    Console.Write(XOs(n - 1).ToString() + (m - 1) + " ");
            }
            for (int n = x, m = y; n < 9 && m < 9; n++, m++)
            {

                if ((n + 1) < 9 && (m + 1) < 9)
                    Console.Write(XOs(n + 1).ToString() + (m + 1) + " ");
            }
            Console.Write("\n");
            Console.Write("\\\t");
            for (int n = x, m = y; n < 9 && m > 0; n++, m--)
            {

                if ((m - 1) > 0 && (n + 1) < 9)
                    Console.Write(XOs(n + 1).ToString() + (m - 1) + " ");
            }
            for (int n = x, m = y; n > 0 && m < 9; n--, m++)
            {
                if ((n - 1) > 0 && (m + 1) < 9)
                    Console.Write(XOs(n - 1).ToString() + (m + 1) + " ");
            }

        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Vnesi x koordinato trdnjave:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi y koordinato trdnjave:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Trdnjava napada naslednja polja: ");
            nav(x, y);
            horiz(x, y);
            Console.WriteLine();
            Console.WriteLine("Vnesi x koordinato kraljice:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi y koordinato kraljice:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Kraljica napada naslednja polja: ");
            nav(x, y);
            horiz(x, y);
            diag(x, y);
            Console.ReadKey();
        }
    }
}
