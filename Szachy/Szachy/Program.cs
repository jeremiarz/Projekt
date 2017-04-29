using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Program
    {
        internal class Pozycja
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

        }
        
        static void Main(string[] args)
        {
            string zdanie, imie;

            Pionek figura1 = new Pionek("pionek", "bialy", 2, 2);
            imie = figura1.ToString();
            Console.WriteLine(imie);
            
            Krol figura2 = new Krol("krol", "bialy", 2, 2);
            imie = figura2.ToString();
            Console.WriteLine(imie);
            
            Wieza figura3 = new Wieza("wieza", "bialy", 2, 2);
            imie = figura3.ToString();
            Console.WriteLine(imie);
            
            Krolowa figura4 = new Krolowa("krolowa", "bialy", 2, 2);
            imie = figura4.ToString();
            Console.WriteLine(imie);

            do
            {
                zdanie = Console.ReadLine();
                if (zdanie == "KONIEC") break;
                figura4.Przesun(zdanie);

            } while (zdanie != "KONIEC");

            Console.WriteLine("SZACHOWNICA");
            Console.WriteLine(imie);
            Szachownica szach1 = new Szachownica();
            szach1.szachownica[0, 0] = figura1;
            imie = szach1.szachownica[0, 0].ToString();
            Console.WriteLine(imie);
            Console.ReadKey();

        }
    }
}

//KONWERTER ZNAKOW NA LICZBY
/*int x;
string zdanie = "ABCDEFGH";
for (int i = 0; i < 8; i++)
{
    x = (int)zdanie[i] - 64;
    // zdanie - 64
    Console.WriteLine(x);
}*/