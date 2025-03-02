namespace RudOpgave15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                sum += i;
            }
            Console.WriteLine("Summen af de første fem tal er: " + sum);
            sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Den totale sum er: " + sum);
        

        Console.ReadKey();
        }

          
        
    }

}
