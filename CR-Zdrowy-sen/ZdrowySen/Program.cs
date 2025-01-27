using System;

public class Program
{
    /// <summary>
    /// Główna metoda programu, która ocenia, czy wartość H mieści się w zadanym zakresie.
    /// Na podstawie wczytanych danych wejściowych (A, B, H), program wypisuje odpowiedni komunikat:
    /// - "Normalny", jeśli H mieści się w przedziale [A, B],
    /// - "Niedobór", jeśli H jest mniejsze niż A,
    /// - "Nadmiar", jeśli H jest większe niż B.
    /// </summary>
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int H = int.Parse(input[2]);

        if (H >= A && H <= B)
        {
            Console.Write("Normalny");
        }
        else if (H < A)
        {
            Console.Write("Niedobór");
        }
        else
        {
            Console.Write("Nadmiar");
        }
    }
}