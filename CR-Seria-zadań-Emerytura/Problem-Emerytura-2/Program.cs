using System;

namespace RetirementCalculatorEnhanced
{
    /// <summary>
    /// Program "Emerytura 2" oblicza różnicę między wiekiem użytkownika a wiekiem emerytalnym
    /// oraz poprawnie formułuje komunikat w języku polskim, uwzględniając gramatykę liczebników.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Główna metoda programu.
        /// Wczytuje dane wejściowe od użytkownika (nazwisko, wiek, wiek emerytalny),
        /// analizuje dane i wypisuje odpowiednie komunikaty.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Podaj swoje nazwisko:");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj swój wiek:");
            string wiek = Console.ReadLine();
            int intWiek = Convert.ToInt32(wiek);

            Console.WriteLine("Podaj wiek emerytalny:");
            string wiekEmerytalny = Console.ReadLine();
            int intWiekEmerytalny = Convert.ToInt32(wiekEmerytalny);

            Console.WriteLine($"Witaj, {nazwisko}!");

            if (intWiek < 0 || intWiekEmerytalny < 0)
            {
                Console.WriteLine("Wiek nie może być ujemny!");
            }
            else if (intWiek < intWiekEmerytalny)
            {
                int x = intWiekEmerytalny - intWiek;
                string forma = OkreslFormeLiczbyLat(x);
                Console.WriteLine($"Do emerytury brakuje Ci {x} {forma}!");
            }
            else
            {
                Console.WriteLine("Jesteś emerytem!");
            }
        }

        /// <summary>
        /// Określa poprawną formę słowa "rok/lata/lat" w zależności od liczby lat.
        /// </summary>
        /// <param name="x">Liczba lat do emerytury.</param>
        /// <returns>Poprawna forma gramatyczna liczby lat (rok, lata, lat).</returns>
        static string OkreslFormeLiczbyLat(int x)
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
