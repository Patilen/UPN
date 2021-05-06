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
            int j = 1;
            for(int i = 0; i < 20; i++)
            {
                Console.Write("Vnesi število: ");
                float x = float.Parse(Console.ReadLine());

                if (x < 0) continue;

                Console.WriteLine(j++ + ". pozitivno število.");
            }
            Console.ReadLine();
        }
    }
}