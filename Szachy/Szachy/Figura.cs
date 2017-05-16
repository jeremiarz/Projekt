using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    public class Figura
    {
        public string nazwa;
        public string kolor;
        public int pozycja_x;
        public int pozycja_y;

        public override string ToString()
        {
            return nazwa;
        }
    }

    public class Pionek : Figura
    {
        public void Przesun(string cel)
        {
            int x1, y1;
            x1 = (int)cel[0] - 64;
            y1 = Int32.Parse(cel.Substring(1));
            Console.WriteLine("Obecna pozycja {0} {1}", this.pozycja_x, this.pozycja_y);
            Console.WriteLine("Przesuwanie na pole {0} {1}", x1, y1);
            if (x1 != this.pozycja_x || (y1 - this.pozycja_y) > 2)
                Console.WriteLine("OPERACJA NIEDOZWOLONA");
        }

        public Pionek(string kolor, int pozycja_x, int pozycja_y)
        {
            this.nazwa = "Pio";
            this.kolor = kolor;
            this.pozycja_x = pozycja_x;
            this.pozycja_y = pozycja_y;
        }
    }

    public class Krol : Figura
    {
        public void Przesun(string cel)
        {
            int x1, y1;
            x1 = (int)cel[0] - 64;
            y1 = Int32.Parse(cel.Substring(1));
            Console.WriteLine("Obecna pozycja {0} {1}", this.pozycja_x, this.pozycja_y);
            Console.WriteLine("Przesuwanie na pole {0} {1}", x1, y1);
            if ((-1 <= (x1 - this.pozycja_x) && (x1 - this.pozycja_x) <= 1) && (-1 <= (y1 - this.pozycja_y) && (y1 - this.pozycja_y) <= 1))
                Console.WriteLine("OK");
            else
                Console.WriteLine("OPERACJA NIEDOZWOLONA");
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
        public void Przesun(string cel)
        {
            int x1, y1;
            x1 = (int)cel[0] - 64;
            y1 = Int32.Parse(cel.Substring(1));
            Console.WriteLine("Obecna pozycja {0} {1}", this.pozycja_x, this.pozycja_y);
            Console.WriteLine("Przesuwanie na pole {0} {1}", x1, y1);
            if ((x1 == this.pozycja_x)||(y1 == this.pozycja_y))
                Console.WriteLine("OK");
            else
                Console.WriteLine("OPERACJA NIEDOZWOLONA");
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
        public void Przesun(string cel)
        {
            int x1, y1, roznica_x, roznica_y;
            x1 = (int)cel[0] - 64;
            y1 = Int32.Parse(cel.Substring(1));
            Console.WriteLine("Obecna pozycja {0} {1}", this.pozycja_x, this.pozycja_y);
            Console.WriteLine("Przesuwanie na pole {0} {1}", x1, y1);

            roznica_x = x1 - this.pozycja_x;
            if (roznica_x<0) roznica_x*=(-1);
            roznica_y = y1 - this.pozycja_y;
            if (roznica_y<0) roznica_y*=(-1);

            if ((x1 == this.pozycja_x) || (y1 == this.pozycja_y))
                Console.WriteLine("OK");
            else if(roznica_x == roznica_y)
                Console.WriteLine("OK");
            else
                Console.WriteLine("OPERACJA NIEDOZWOLONA");
        }

        public Krolowa(string kolor, int pozycja_x, int pozycja_y)
        {
            this.nazwa = "Krola";
            this.kolor = kolor;
            this.pozycja_x = pozycja_x;
            this.pozycja_y = pozycja_y;
        }
    }

}
