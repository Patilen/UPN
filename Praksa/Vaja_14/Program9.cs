using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga9
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi začetek intervala: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Vnesi konec intervala: ");
            int y = int.Parse(Console.ReadLine());


            int x1 = x;
            int x2 = x;
            int delitelj = 0;
            Console.Write("Praštevila med {0} in {1} so : ", x, y);
            for (; x <= y; x++)
            {
                delitelj = 0;
                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                    {
                        delitelj++;
                    }
                }
                if (delitelj == 2)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();

            delitelj = 0;
            Console.Write("Praštevila med {0} in {1} so : ", x1, y);
            int i = 1;
            while (x1 <= y)
            {
                delitelj = 0;
                while (i <= x1)
                {
                    if (x1 % i == 0)
                    {
                        delitelj++;
                    }
                    i++;
                }
                if (delitelj == 2)
                {
                    Console.Write(x1 + " ");
                }
                i = 1;
                x1++;
            }
            Console.WriteLine();

            delitelj = 0;
            Console.Write("Praštevila med {0} in {1} so : ", x2, y);
            int k = 1;
            do
            {
                delitelj = 0;
                while (k <= x2)
                {
                    if (x2 % k == 0)
                    {
                        delitelj++;
                    }
                    k++;
                }
                if (delitelj == 2)
                {
                    Console.Write(x2 + " ");
                }
                k = 1;
                x2++;
            } while (x2 <= y);
            Console.ReadLine();
        }
    }
}
