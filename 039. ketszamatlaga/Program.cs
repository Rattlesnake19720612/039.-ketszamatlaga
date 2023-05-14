using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039.ketszamatlaga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            int atlag = (szam1 + szam2) / 2;

            Console.WriteLine("A számok átlaga: " + atlag);

            Console.ReadKey();
        }
    }
}

/*Két számot kér be a felhasználótól, majd kiszámolja azok átlagát és kiírja az eredményt a konzolra. A Main() függvény vezérli a program futását. Első lépésként kiírja a "Kérek egy számot!" szöveget a konzolra, majd beolvassa a felhasználó által megadott számot a szam1 változóba. Majd a felhasználótól kapott, stringet (szöveges változót) a ConvertToInt32 metódussal átalakítja integer (int) egész számos változóvá, hogy matematikai műveleteket tudjunk vele végezni. Ezt követően ugyanezt teszi a "Kérek még egy számot!" szöveggel és a második számmal (szam2) is.

Az atlag változóba beállítjuk az szam1 és szam2 összege osztva 2-vel kapott átlagát. Végül a program kiírja az átlagot a "A számok átlaga:" szöveggel együtt a konzolra. A Console.ReadKey() függvény segítségével várunk egy billentyűlenyomást, mielőtt a program véget érne és kilép.*/
