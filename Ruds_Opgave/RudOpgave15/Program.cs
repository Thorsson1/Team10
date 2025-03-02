namespace RudOpgave15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, sum = 0, n;
            Console.Write("Skriv et tal her: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\nSummen af alle tal op til tallet du har skrevet er: " + sum);

            Console.ReadKey();
        }

          
        
    }

}
