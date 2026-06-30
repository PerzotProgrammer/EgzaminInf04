namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj a:");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Podaj b:");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"NWD {a} i {b} to {Util.Nwd(a, b)}");
        }
    }
}
