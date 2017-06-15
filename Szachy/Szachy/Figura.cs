using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *LABORATORIUM 1
 *Klasy figur szachowych z odpowiednimi parametrami 
 *oraz metodą sprawdzającą możliwość przesunięcia na wybrane pole.
 *Wyświetlanie obiektu w postaci tekstowej.
 */
/*
 * LABORATORIUM 2
 * Modyfikatory dostępu.
 * Modyfikator override w przypadku metody ToString().
 */
namespace Szachy
{
    public abstract class Figura
    {
        protected string nazwa;
        protected string kolor;
        public int pozycja_x;
        public int pozycja_y;

        public abstract bool Przesun(string cel);

        public override string ToString()
        {
            return nazwa;
        }
    }

    public class Pionek : Figura
    {
        public override bool Przesun(string cel)
        {
            //dekodowanie pozycji docelowej
            int x1, y1;
            x1 = (int)cel[0] - 64 - 1;
            y1 = Int32.Parse(cel.Substring(1)) - 1;
            y1 = 7 - y1;

            if (x1 != this.pozycja_x || (y1 - this.pozycja_y) > 2)
                return false;
            else
                return true;
        }

        public Pionek(string kolor, int pozycja_x, int pozycja_y)
        {
            this.nazwa = "Pion";
            this.kolor = kolor;
            this.pozycja_x = pozycja_x;
            this.pozycja_y = pozycja_y;
        }
    }

    public class Krol : Figura
    {
        public override bool Przesun(string cel)
        {
            int x1, y1;
            x1 = (int)cel[0] - 64 - 1;
            y1 = Int32.Parse(cel.Substring(1)) - 1;
            y1 = 7 - y1;

            if ((-1 <= (x1 - this.pozycja_x) && (x1 - this.pozycja_x) <= 1) && (-1 <= (y1 - this.pozycja_y) && (y1 - this.pozycja_y) <= 1))
                return true;
            else
                return false;
        }

        public Krol(string kolor, int pozycja_x, int pozycja_y)
        {
            this.nazwa = "Krol";
            this.kolor = kolor;
            this.pozycja_x = pozycja_x;
            this.pozycja_y = pozycja_y;
        }
    }

    public class Wieza : Figura
    {
        public override bool Przesun(string cel)
        {
            int x1, y1;
            x1 = (int)cel[0] - 64 - 1;
            y1 = Int32.Parse(cel.Substring(1)) - 1;
            y1 = 7 - y1;

            if ((x1 == this.pozycja_x) || (y1 == this.pozycja_y))
                return true;
            else
                return false;
        }

        public Wieza(string kolor, int pozycja_x, int pozycja_y)
        {
            this.nazwa = "Wieza";
            this.kolor = kolor;
            this.pozycja_x = pozycja_x;
            this.pozycja_y = pozycja_y;
        }
    }

    public class Krolowa : Figura
    {
        public override bool Przesun(string cel)
        {
            int x1, y1, roznica_x, roznica_y;
            x1 = (int)cel[0] - 64 - 1;
            y1 = Int32.Parse(cel.Substring(1)) - 1;
            y1 = 7 - y1;

            roznica_x = x1 - this.pozycja_x;
            if (roznica_x<0) roznica_x*=(-1);
            roznica_y = y1 - this.pozycja_y;
            if (roznica_y<0) roznica_y*=(-1);

            if ((x1 == this.pozycja_x) || (y1 == this.pozycja_y))
                return true;
            else if (roznica_x == roznica_y)
                return true;
            else
                return false;
        }

        public Krolowa(string kolor, int pozycja_x, int pozycja_y)
        {
            this.nazwa = "Hetma";
            this.kolor = kolor;
            this.pozycja_x = pozycja_x;
            this.pozycja_y = pozycja_y;
        }
    }

}
