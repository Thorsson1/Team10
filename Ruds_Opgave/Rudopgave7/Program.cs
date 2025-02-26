namespace Rudopgave7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lad os tjekke, om du er født i et skudår! \nIndtast i tal, hvad år du er født i: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int year = int.Parse(Console.ReadLine());
            Console.ResetColor();

            if ((year % 4 == 0 && year % 400 == 0) || (year % 4 == 0 && !(year % 100 == 0)))
            {
                Console.WriteLine(year + " er ikke et skudår.");
            }
            else
                Console.WriteLine(year + " er ikke et skudår.");

            Console.ReadKey();
        }
    }
}
