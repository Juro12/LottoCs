using System;
using System.Threading;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            losowanie los = new losowanie();

            los.liczba = new int[6];
            los.strzal = new int[6];

            Random generator = new Random();

            Console.WriteLine("Witaj w kolejnym losowaniu lotto!");
            Thread.Sleep(2000);
            Console.WriteLine("Dzis do wygrania jest: ");
            los.kumulacja = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 5; i++) {
                los.liczba[i] = generator.Next(1,50);

                for (int j = i - 1; j >= 0; j--)
                {
                    if (los.liczba[j] == los.liczba[i])
                    {
                        i--;
                    }
                }
            }
            Console.WriteLine("Podaj swoje typy! Liczby w przedziale od 1 do 49.");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Podaj "+(i+1)+" liczbe:");
                los.strzal[i] = int.Parse(Console.ReadLine());

                if (los.strzal[i] <= 0 || los.strzal[i] >= 50)
                {
                    Console.WriteLine("Nie morzesz skreślić podanej liczby! Znajduje się ona za pzedziałem 1-49!");
                    Console.WriteLine("Podaj liczbę "+(i+1)+" ponownie.");
                    i--;
                }

                for (int j = i-1; j >= 0; j--)
                {
                    if (los.strzal[j] == los.strzal[i])
                    {
                        Console.WriteLine("Juz skresliles ta liczbe skresl inna!");
                        i--;
                    }
                }
            }

            for (int i = 0; i <= 5; i++) {
                for (int j = 0; j <= 5; j++) {
                    if (los.liczba[i] == los.strzal[j]) {
                        los.wynik++;
                    }
                }
            }

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Zachwile nastąpi zwolnienie blokady!");
            Thread.Sleep(2000);
            Console.WriteLine("Wylosowane liczby to: " + los.liczba[0] + ", " + los.liczba[1] + ", " + los.liczba[2] + ", " + los.liczba[3] + ", " + los.liczba[4] + ", " + los.liczba[5]);
            Thread.Sleep(1000);
            Console.WriteLine("Twoje typy to: " + los.strzal[0] + ", " + los.strzal[1] + ", " + los.strzal[2] + ", " + los.strzal[3] + ", " + los.strzal[4] + ", " + los.strzal[5]);
            Thread.Sleep(1000);
            los.licz_wynik();
            Thread.Sleep(1000);
            los.licz_wygrana();
        }
    }
}
