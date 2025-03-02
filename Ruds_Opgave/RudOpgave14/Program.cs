namespace RudOpgave14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            do
            {
                Console.WriteLine("{0}", number);
                number++;
            } while (number <= 10);


            Console.ReadKey();
        }
    }
}
