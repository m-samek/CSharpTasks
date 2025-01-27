using System;

namespace RetirementCalculator
{
    /// <summary>
    /// Program "Emerytura 1" oblicza różnicę między wiekiem użytkownika a wiekiem emerytalnym
    /// na podstawie danych wprowadzonych przez użytkownika.
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
                Console.WriteLine($"Do emerytury brakuje Ci {x} lat!");
            }
            else
            {
                Console.WriteLine("Jesteś emerytem!");
            }
        }
    }
}
