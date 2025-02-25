namespace RudOpgave6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Ruds Opgave 6! Hvor vi skal lege med logiske og sammenligningsoperatoerer.");
            Console.Write("Skriv et tal her: ");
            int number = int.Parse(Console.ReadLine());

            bool isEqual = (number == 10);
            bool isNotEqual = (number != 10);
            bool isGreater = (number > 10);
            bool isLess = (number < 10);
            bool isGreaterOrEqual = (number >= 10);
            bool isLessOrEqual = (number <= 10);

            Console.WriteLine("\nDit tal du har valgt er lig med 10: " + isEqual);
            Console.WriteLine("Dit tal du har valgt er ikke lig med 10: " + isNotEqual);
            Console.WriteLine("Dit tal du har valgt er stoerre end 10: " + isGreater);
            Console.WriteLine("Dit tal du har valgt er mindre end 10: " + isLess);
            Console.WriteLine("Dit tal du har valgt er stoerre eller lig med 10: " + isGreaterOrEqual);
            Console.WriteLine("Dit tal du har valgt er mindre eller lig med 10: " + isLessOrEqual);

            Console.ReadKey();
        }
    }
}
