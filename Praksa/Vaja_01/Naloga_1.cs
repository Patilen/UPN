using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
•	Deklariraj spremenljivko za cela števila z imenom xI.
•	Spremenljivki xI priredi vrednost 7. Preveri (z razhroščevalnikom), če je v spremenljivki res vpisana vrednost 7! Naredi "print screen" in označi, kje se to vidi.
•	Sedaj spremenljivki xI priredi vaše ime (npr. :"Tine"). Preveri, če deluje! Zakaj ne deluje?
•	Deklariraj še dve spremenljivki za cela števila z imenoma yI in vsotaI. Spremenljivki yI priredi vrednost 12. Preveri, če je res vpisana vrednost 12.
•	V spremenljivko vsotaI priredi vrednost vsote spremenljivk xI in yI (uporabi spremenljivki in ne njuni vrednosti!!!!). Preveri rezultat.
•	Ustvari spremenljivko (ime izberi sam) za hranjenje niza znakov. Priredi ji neko lastno ime. Preveri, če je ime res vpisano v spremenljivki.
*/

namespace Naloga1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaracija
            int xI;
            xI = 7;

            //Inicilizacija 
            int yI = 12;
            int vsota = xI + yI;

            string ime = "Janez Novak";

        }
    }
}