using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * LABORATORIUM 2
 * Klasa Szachownica.
 * Możliwość pobrania i zapisania figury na wybranym polu.
 */

namespace Szachy
{
    public class Szachownica
    {
        public int ilosc_pionkow;
        public Figura[,] szachownica;

        public void Przesun(string start, string meta)
        {
            //dekodowanie pozycji start:
            int xs, ys;
            xs = (int)start[0] - 64 - 1;
            ys = Int32.Parse(start.Substring(1)) - 1;
            ys = 7 - ys;

            //dekodowanie pozycji meta:
            int xm, ym;
            xm = (int)meta[0] - 64 - 1;
            ym = Int32.Parse(meta.Substring(1)) - 1;
            ym = 7 - ym;

            if (szachownica[xs, ys].Przesun(meta))
            { 
                szachownica[xm, ym] = szachownica[xs, ys];
                szachownica[xs, ys] = null;
                szachownica[xm, ym].pozycja_x = xm;
                szachownica[xm, ym].pozycja_y = ym;
            }
            else
                Console.WriteLine("BLAD");
        }
        
        public void DodajPionek(string nazwa, string kolor, string pozycja)
        {
            //dekodowanie pozycji, uzyskane dane sluza do poprawnej reprezentacji figur w tablicy:
            int x1, y1;
            x1 = (int)pozycja[0] - 64 - 1;
            y1 = Int32.Parse(pozycja.Substring(1)) - 1;
            y1 = 7 - y1;

            //stworzenie w polu tablicy obiektu pionka
            switch (nazwa)
            {
                case "Pionek":
                    szachownica[x1, y1] = new Pionek(kolor, x1, y1);
                    ilosc_pionkow++;
                    break;
                case "Krol":
                    szachownica[x1, y1] = new Krol(kolor, x1, y1);
                    ilosc_pionkow++;
                    break;
                case "Wieza":
                    szachownica[x1, y1] = new Wieza(kolor, x1, y1);
                    ilosc_pionkow++;
                    break;
                case "Krolowa":
                    szachownica[x1, y1] = new Krolowa(kolor, x1, y1);
                    ilosc_pionkow++;
                    break;
            }
        }
        public void UstawPionki()
        {
            DodajPionek("Pionek", "bialy", "A2");
            DodajPionek("Pionek", "bialy", "B2");
            DodajPionek("Pionek", "bialy", "C2");
            DodajPionek("Pionek", "bialy", "D2");
            DodajPionek("Pionek", "bialy", "E2");
            DodajPionek("Pionek", "bialy", "F2");
            DodajPionek("Wieza", "bialy", "A1");
            DodajPionek("Wieza", "bialy", "H1");
            DodajPionek("Krol", "bialy", "D1");
            DodajPionek("Krolowa", "bialy", "E1");

        }

        public void NarysujSzachownice()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (szachownica[j, i] == null)
                        Console.Write("[\t]");
                    else
                    {
                        Console.Write("[" + szachownica[j, i].ToString());
                        Console.Write("\t]");
                    }
                }
                Console.Write("\n");
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

        public void IloscPionkow()
        {
            Console.WriteLine("Ilosc pionkow na szachownicy to: " + ilosc_pionkow);
        }

        public Szachownica()
        {
            //tworzenie tablicy szachownicy
            szachownica = new Figura[8, 8];
            ilosc_pionkow = 0;
        }

    }
}
