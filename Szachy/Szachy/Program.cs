using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Program
    {
        static void Main(string[] args)
        {
            //string zdanie, nazwa;
            /*
            Pionek figura1 = new Pionek("bialy", 2, 2);
            nazwa = figura1.ToString();
            Console.WriteLine(nazwa);
            
            Krol figura2 = new Krol("bialy", 2, 2);
            nazwa = figura2.ToString();
            Console.WriteLine(nazwa);
            
            Wieza figura3 = new Wieza("bialy", 2, 2);
            nazwa = figura3.ToString();
            Console.WriteLine(nazwa);
            
            Krolowa figura4 = new Krolowa("bialy", 2, 2);
            nazwa = figura4.ToString();
            Console.WriteLine(nazwa);
            */

            /*
            do
            {
                Console.WriteLine("Wybrany pionek to {0}", figura4.ToString());
                //wpisz pole, do ktorego ma sie udac wybrany pionek, np. A3
                zdanie = Console.ReadLine();
                if (zdanie == "KONIEC") break;
                figura4.Przesun(zdanie);

            } while (zdanie != "KONIEC");
            */

            /*
            Console.WriteLine("SZACHOWNICA");
            Console.WriteLine(nazwa);
            Szachownica szach1 = new Szachownica();
            szach1.szachownica[0, 0] = figura1;
            nazwa = szach1.szachownica[0, 0].ToString();
            Console.WriteLine(nazwa);
            Console.ReadKey();
            */

            Console.WriteLine("SZACHOWNICA");
            Szachownica szach = new Szachownica();
            szach.DodajPionek("Pionek", "bialy", "A2");
            szach.DodajPionek("Pionek", "bialy", "B2");
            szach.DodajPionek("Pionek", "bialy", "C2");
            szach.DodajPionek("Pionek", "bialy", "D2");
            szach.DodajPionek("Pionek", "bialy", "E2");
            szach.DodajPionek("Pionek", "bialy", "F2");
            szach.DodajPionek("Wieza", "bialy", "A1");
            szach.DodajPionek("Wieza", "bialy", "H1");
            szach.DodajPionek("Krol", "bialy", "D1");
            szach.DodajPionek("Krolowa", "bialy", "E1");
            /*szach.CoNaPolu("A2");
            szach.CoNaPolu("A1");
            szach.CoNaPolu("H1");
            szach.CoNaPolu("D1");
            szach.CoNaPolu("E1");*/

            Console.Write("\n");
            szach.NarysujSzachownice();

            Console.ReadKey();

        }
    }
}

//WSPOLRZEDNE SZACHOWNICY
//   0  1  3  4 ... 7
// 0[ ][ ][ ][ ]...[ ]
// 1[ ][ ][ ][ ]...[ ]
// 2[ ][ ][ ][ ]...[ ]
//   :  :  :  : ::: :
// 7[ ][ ][ ][ ]...[ ]

//KONWERTER ZNAKOW NA LICZBY
/*int x;
string zdanie = "ABCDEFGH";
for (int i = 0; i < 8; i++)
{
    x = (int)zdanie[i] - 64;
    // zdanie - 64
    Console.WriteLine(x);
}*/

/*internal class Pozycja
{
    int x;
    int y;
    string pole;

    public string Pole
    {
        get
        {
            return pole;
        }

        set
        {
            pole = value;
            x = PrzeliczX(pole);
            y = PrzeliczY(pole);
        }
    }

    public int X
    {
        get
        {
            return x;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }
    }

    internal static int PrzeliczX(string pole)
    {
        return pole[0] - 'A' + 1;
    }
    internal static int PrzeliczY(string pole)
    {
        return Int32.Parse(pole.Substring(1));
    }

    public Pozycja()
    {
        pole = null;
        x = 0;
        y = 0;
    }
    public Pozycja(string pole)
    {
        this.Pole = pole;

    }

*/