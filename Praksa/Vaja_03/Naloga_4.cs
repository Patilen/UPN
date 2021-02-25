using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_3
{
    class Naloga_4
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Velikost bool v bytih: {0}", sizeof(bool));

            Console.WriteLine("Velikost char v bytih: {0}", sizeof(char));
            Console.WriteLine("Vrednosti od {0} do {1}\n", char.MinValue, char.MaxValue);

            Console.WriteLine("Velikost sbyte v bytih: {0}", sizeof(sbyte));
            Console.WriteLine("Vrednosti od {0} do {1}\n", sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine("Velikost byte v bytih: {0}", sizeof(byte));
            Console.WriteLine("Vrednosti od {0} do {1}\n", byte.MinValue, byte.MaxValue);

            Console.WriteLine("Velikost short v bytih: {0}", sizeof(short));
            Console.WriteLine("Vrednosti od {0} do {1}\n", short.MinValue, short.MaxValue);

            Console.WriteLine("Velikost ushort v bytih: {0}", sizeof(ushort));
            Console.WriteLine("Vrednosti od {0} do {1}\n", ushort.MinValue, ushort.MaxValue);

            Console.WriteLine("Velikost int v bytih: {0}", sizeof(int));
            Console.WriteLine("Vrednosti od {0} do {1}\n", int.MinValue, int.MaxValue);

            Console.WriteLine("Velikost uint v bytih: {0}", sizeof(uint));
            Console.WriteLine("Vrednosti od {0} do {1}\n", uint.MinValue, uint.MaxValue);

            Console.WriteLine("Velikost float v bytih: {0}", sizeof(float));
            Console.WriteLine("Vrednosti od {0} do {1}\n", float.MinValue, float.MaxValue);

            Console.WriteLine("Velikost double v bytih: {0}", sizeof(double));
            Console.WriteLine("Vrednosti od {0} do {1}\n", double.MinValue, double.MaxValue);

            Console.WriteLine("Velikost decimal v bytih: {0}", sizeof(decimal));
            Console.WriteLine("Vrednosti od {0} do {1}\n", decimal.MinValue, decimal.MaxValue);




            Console.ReadKey(true);

        }
    }
}
