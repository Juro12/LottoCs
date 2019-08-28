using System;
using System.Collections.Generic;
using System.Text;

namespace lotto
{
    class losowanie
    {
        public int[] liczba;
        public int[] strzal;
        public int wynik = 0;
        public double wygrana = 0;
        public int skresl = 0;
        public int kumulacja = 0;

        public void licz_wynik() {
            switch (wynik)
            {
                case 6: Console.WriteLine("Trafiłeś wrzystkie 6 cyfr"); break;
                case 5: Console.WriteLine("Trafiłeś 5 cyfr"); break;
                case 4: Console.WriteLine("Trafiłeś 4 cyfry"); break;
                case 3: Console.WriteLine("Trafiłeś 3 cyfry"); break;
                case 2: Console.WriteLine("Trafiłeś 2 cyfry"); break;
                case 1: Console.WriteLine("Trafiłeś 1 cyfrę"); break;
                case 0: Console.WriteLine("Nie trafiłeś żadnej cyfry"); break;
            }
        }

        public void licz_wygrana()
        {
            switch (wynik)
            {
                case 6: wygrana = 1 * kumulacja; break;
                case 5: wygrana = 0.00084 * kumulacja; break;
                case 4: wygrana = 0.00035 * kumulacja; break;
                case 3: wygrana = 0.00002 * kumulacja; break;
                case 2: wygrana = 0.000014 * kumulacja; break;
                case 1: wygrana = 0.000012 * kumulacja; break;
                case 0: wygrana = 0 * kumulacja; break;
            }

            wygrana = Math.Round(wygrana * 100) / 100;

            if (wynik == 6) { Console.WriteLine("Wygrałeś maksymalną wygraną! Gratulacje oto twoje " + wygrana + " złotych!"); }
            else if (wynik == 0) { Console.WriteLine("Niestety nie wygrałeś nic."); }
            else { Console.WriteLine("Wygrałeś " + wygrana + " złotych!"); }
        }

    }
}
