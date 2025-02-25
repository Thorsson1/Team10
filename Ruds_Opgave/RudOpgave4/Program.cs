namespace RudOpgave4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcommen til Ruds Opgave 4! " +
                "\n\nVi skal i gang med at udforske de Aritmetiske operatoerer");
            Console.Write("Start med at skrive et tal: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int numberOne = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Skriv endnu et tal: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int numberTwo = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine("Du har skrevet det foerste tal til at vaere: " + numberOne +
                "\nOg det andet tal til at vaere: " + numberTwo);

            int addition = numberOne + numberTwo;
            int subtraktion = numberOne - numberTwo;
            int multiplikation = numberOne * numberTwo;
            int division = numberOne / numberTwo;
            int modulus = numberOne % numberTwo;

            Console.WriteLine("\nSummen af de to tal er: " + addition +
                "\nDifferencen af de to tal er: " + subtraktion +
                "\nProduktet af de to tal er: " + multiplikation +
                "\nQuotient af de to tal er: " + division +
                "\nRemainder af de to tal er: " + modulus);

            Console.ReadKey();
        }
    }
}