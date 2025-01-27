using System;

namespace RetirementCalculatorExtended
{
    /// <summary>
    /// Program "Emerytura 3" analizuje jedną linię danych wejściowych zawierającą
    /// nazwisko, wiek oraz wiek emerytalny, oddzielone spacjami, i wypisuje odpowiednie komunikaty.
    /// Uwzględnia gramatykę języka polskiego w komunikatach o brakujących latach.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Główna metoda programu.
        /// Wczytuje jedną linię danych wejściowych, przetwarza dane i wypisuje odpowiedni komunikat.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Podaj dane wejściowe w formacie: nazwisko wiek wiek_emerytalny");
            string input = Console.ReadLine();

            string[] dane = input.Split(' ');

            if (dane.Length != 3)
            {
                Console.WriteLine("Błędne dane wejściowe!");
                return;
            }

            string nazwisko = dane[0];

            if (!int.TryParse(dane[1], out int wiek) || !int.TryParse(dane[2], out int wiekEmerytalny))
            {
                Console.WriteLine("Błędne dane wejściowe!");
                return;
            }

            if (wiek < 0 || wiekEmerytalny < 0)
            {
                Console.WriteLine("Wiek nie może być ujemny!");
            }
            else if (wiek < wiekEmerytalny)
            {
                int x = wiekEmerytalny - wiek;
                string forma = OkreslFormaLiczbyLat(x);
                Console.WriteLine($"Witaj {nazwisko}! Do emerytury brakuje Ci {x} {forma}!");
            }
            else
            {
                Console.WriteLine($"Witaj emerycie {nazwisko}!");
            }
        }

        /// <summary>
        /// Określa poprawną formę słowa "rok/lata/lat" w zależności od liczby lat.
        /// </summary>
        /// <param name="x">Liczba lat do emerytury.</param>
        /// <returns>Poprawna forma gramatyczna liczby lat (rok, lata, lat).</returns>
        static string OkreslFormaLiczbyLat(int x)
        {
            if (x % 10 == 1 && x % 100 != 11)
            {
                return "rok";
            }
            else if (x % 10 >= 2 && x % 10 <= 4 && (x % 100 < 12 || x % 100 > 14))
            {
                return "lata";
            }
            else
            {
                return "lat";
            }
        }
    }
}
