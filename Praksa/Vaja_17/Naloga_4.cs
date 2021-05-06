/*Napiši program, ki izpiše števila od 150 do 50, vključno z njima, v koraku po dva.
Primer: 
150, 148, 146, 144 .... ,52, 50 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga04
{
    class Program4
    {
        static void Main(string[] args)
        {
            for (int i = 150; i >= 50; i -= 2)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
