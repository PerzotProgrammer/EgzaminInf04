namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TablicoweOperacje tablicoweOperacje = new(50);

            tablicoweOperacje.WyswietlElementy();

            int szukana;
            Console.Write("Szukany element: ");
            while (!int.TryParse(Console.ReadLine(), out szukana))
            {
                Console.WriteLine("Niepoprawna liczba!");
                Console.Write("Szukany element: ");
            }

            int indeks = tablicoweOperacje.IndeksPierwszego(szukana);

            if(indeks != -1) Console.WriteLine($"Znaleziono na indeksie: {indeks}");
            
            Console.WriteLine("Liczby nieparzyste");
            int sumaNieparzystych = tablicoweOperacje.SumaNieparzystych();

            Console.WriteLine($"Suma nieparzystych: {sumaNieparzystych}");

            Console.WriteLine($"Średnia arytmetyczna elementów: {tablicoweOperacje.SredniaArytmetyczna()}");
        }
    }
}
