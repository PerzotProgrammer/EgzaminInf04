namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj numer pesel do sprawdzenia: ");
            string pesel = Console.ReadLine()!;

            if (PeselUtils.CheckPesel(pesel))
            {
                Console.WriteLine("To jest prawidłowy numer PESEL");
                if (PeselUtils.CheckSex(pesel) == 'K') Console.WriteLine("Należy on do kobiety");
                else Console.WriteLine("Należy on do mężczyzny");
            }
            else Console.WriteLine("TO NIE JEST PRAWIDŁOWY NUMER PESEL!!!");
        }
    }
}
