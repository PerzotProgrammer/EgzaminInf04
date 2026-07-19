namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool firstPass = true;
            int n;
            do
            {
                if (!firstPass) Console.WriteLine("NIEPRAWIDŁOWA LICZBA");
                else firstPass = false;

                Console.Write("Ile wygenerować losowań?: ");

            } while (!int.TryParse(Console.ReadLine(), out n) && n < 0);

            Console.WriteLine("Zestawy wylosowanych liczb");

            DescribeArray(GenerateArray(n));
        }


        /*
         **********************************************
         nazwa funkcji: GenerateArray
         opis funkcji: Generuje tablice dwuwymiarową o n rzędach i 6 kolumnach
         parametry: int n - liczba rzędów (liczba całkowita, powinna być większa od 0)
         zwracany typ i opis: int[][] - tablica dwuwymiarowa o n rzędach i 6 kolumnach 
            z liczbami losowymi z zakresu 1, 49
         autor: 00000000000
         ***********************************************
         */
        static int[][] GenerateArray(int n)
        {
            Random random = new Random();
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++) arr[i] = new int[6];

            foreach (int[] row in arr)
                for (int j = 0; j < row.Length; j++) row[j] = random.Next(1, 50);

            return arr;
        }

        static void DescribeArray(int[][] arr)
        {
            int[] occurences = new int[50];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Losowanie {i + 1}: ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                    occurences[arr[i][j]]++;
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 50; i++)
                Console.WriteLine($"Wystąpienia liczby {i}: {occurences[i]}");
        }
    }
}
