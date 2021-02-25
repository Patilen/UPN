using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_3
{
    class Naloga_1
    {
        static void Main(string[] args)
        {
            bool var_bool = true;
            char var_char = 'n';
            sbyte var_sbyte = -19;
            byte var_byte = 211;
            short var_short = 32767;
            ushort var_ushort = 6526;
            int var_int = 12;
            uint var_uint = 5555554;
            float var_float = 12;
            double var_dauble = 23.2;
            decimal var_decimal = 334;
            string var_string = "Lep sončen dan - je bil včeraj";

            Console.WriteLine(var_bool);
            Console.WriteLine(var_char);
            Console.WriteLine(var_sbyte);
            Console.WriteLine(var_byte);
            Console.WriteLine(var_short);
            Console.WriteLine(var_ushort);
            Console.WriteLine(var_int);
            Console.WriteLine(var_uint);
            Console.WriteLine(var_float);
            Console.WriteLine(var_dauble);
            Console.WriteLine(var_decimal);
            Console.WriteLine(var_string);

            Console.ReadKey(true);
        }
    }
}
