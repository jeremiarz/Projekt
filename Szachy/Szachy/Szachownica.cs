using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    public class Szachownica
    {
        public int ilosc_pionkow;
        public Figura[,] szachownica;

        public void DodajPionek(string nazwa, string kolor, string pozycja)
        {
            //dekodowanie pozycji:
            int x1, y1;
            x1 = (int)pozycja[0] - 64 - 1;
            y1 = Int32.Parse(pozycja.Substring(1)) - 1;
            Console.WriteLine("Odczytana pozycja to: {0} {1}", x1, y1);
            //stworzenie w polu tablicy obiektu pionka
            switch (nazwa)
            {
                case "Pionek":
                    szachownica[x1, y1] = new Pionek(kolor, x1, y1);
                    break;
                case "Krol":
                    szachownica[x1, y1] = new Krol(kolor, x1, y1);
                    break;
                case "Wieza":
                    szachownica[x1, y1] = new Wieza(kolor, x1, y1);
                    break;
                case "Krolowa":
                    szachownica[x1, y1] = new Krolowa(kolor, x1, y1);
                    break;
            }
        }

        public void CoNaPolu(string pozycja)
        {
            //metoda otrzymuje dane z zakresu A1 do H8
            //dla pozycji A1 wynik powinien zwrocic [0,0]
            int x1, y1;
            x1 = (int)pozycja[0] - 64 - 1;
            y1 = Int32.Parse(pozycja.Substring(1)) - 1;
            Console.WriteLine(szachownica[x1, y1].ToString());
        }

        public void NarysujSzachownice()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (szachownica[j, i] == null)
                        Console.Write("[O\t]");
                    else
                    {
                        Console.Write("[" + szachownica[j, i].ToString());
                        Console.Write("\t]");
                    }
                }
                Console.Write("\n");
            }
        }

        public Szachownica()
        {
            szachownica = new Figura[8, 8];
            ilosc_pionkow = 0;
        }

    }
}
