using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * LABORATORIUM 3
 * Obsługa zdarzeń w postaci Delegaty, który informuje
 * o wystąpieniu zdarzenia przesunięcia figury.
 * Metoda zwracająca ilość figur na szachownicy.
 */

namespace Szachy
{
    public delegate void Delegata (string start, string meta);

    class Program
    {
        static void Main(string[] args)
        {

            //inicjalizacja szachownicy
            Szachownica szachownica = new Szachownica();
            //ustawienie pionkow
            szachownica.UstawPionki();

            //DELEGATA
            Delegata przesuwanie = new Delegata(szachownica.Przesun);
            przesuwanie += RuchNaPlanszy;

            szachownica.NarysujSzachownice();
            przesuwanie("A2", "A4");
            szachownica.NarysujSzachownice();

            Console.WriteLine();
            szachownica.IloscPionkow();
            Console.ReadKey();

        }
        static void RuchNaPlanszy(string start, string meta)
        {
            Console.WriteLine("Ruch pionka z pola {0} na pole {1}", start, meta);
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