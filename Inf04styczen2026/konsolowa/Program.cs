using wspodzielone;

namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kosc kosc1 = new Kosc();

            Console.Write("Podaj wartość kostki:");
            Kosc kosc2 = new Kosc(int.Parse(Console.ReadLine()!));

            Console.WriteLine($"Utworzonych kości: {Kosc.Instancje}");

            Console.WriteLine($"Kość 1 wartość {kosc1.WyrzuconaWartosc} -> {kosc1.WartoscSlownie()} plik {kosc1.Obrazy[kosc1.ObrazIndeks]}");
            Console.WriteLine($"Kość 2 wartość {kosc2.WyrzuconaWartosc} -> {kosc2.WartoscSlownie()} plik {kosc2.Obrazy[kosc2.ObrazIndeks]}");
        }
    }
}
