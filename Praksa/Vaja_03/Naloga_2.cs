using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_3
{
    class Naloga_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bool");
            bool var_bool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Char");
            char var_char = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Sbyte");
            sbyte var_sbyte = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Byte");
            byte var_byte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Short");
            short var_short = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ushort");
            ushort var_ushort = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Int");
            int var_int = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uint");
            uint var_uint = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Float");
            float var_float = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Double");
            double var_dauble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Decimal");
            decimal var_decimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("String");
            string var_string = Convert.ToString(Console.ReadLine());

            Console.WriteLine("var_bool = " + var_bool);
            Console.WriteLine("var_char  = " + var_char);
            Console.WriteLine("var_sbyte  = " + var_sbyte);
            Console.WriteLine("var_byte  = " + var_byte);
            Console.WriteLine("var_short  = " + var_short);
            Console.WriteLine("var_ushort  = " + var_ushort);
            Console.WriteLine("var_int  = " + var_int);
            Console.WriteLine("var_uint  = " + var_uint);
            Console.WriteLine("var_float  = " + var_float);
            Console.WriteLine("var_double  = " + var_dauble);
            Console.WriteLine("var_decimal  = " + var_decimal);
            Console.WriteLine("var_string  = " + var_string);

            Console.ReadKey(true);
        }
    }
}
