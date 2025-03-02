namespace RudOpgave8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ud fra det danske 12-tals system, kan du her beregne, om din karakter betyder bestået" +
                "eller ikke-bestået");
            Console.Write("Hvilken karakter fik du? (-03, 00, 02, 04, 07, 10 eller 12:) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            int character = int.Parse(Console.ReadLine());
            Console.ResetColor();

            if (character == -03 || character == 00)
            {
                Console.WriteLine("Din karakter betyder, du ikke har bestået");
            }
            else if (character == 02 || character == 04 || character == 07 || character == 10 || character == 12)
            {
                Console.WriteLine("Din karakter betyder, at du er bestået");
            }
            else
            {
                Console.WriteLine("Ugyldig karakter, prøv igen");
            }

            Console.ReadKey();

        }
    }
}
