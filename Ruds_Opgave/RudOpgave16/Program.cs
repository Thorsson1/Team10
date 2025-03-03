namespace RudOpgave16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Skriv et tal her: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= n; x++)
            {
                fact *= x;
            }
            Console.WriteLine("\nFakulteten af tallet du har skrevet er: " + fact);

            Console.ReadKey();
        }
    }
}
