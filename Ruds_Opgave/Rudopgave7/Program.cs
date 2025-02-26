namespace Rudopgave7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen! Læg venligst mærke til, at dette både er opgave 7 + opgave 9");
            //Opgave 7
            Console.Write("Lad os starte med at tjekke, om et tal er positivt, negativt eller lig med 0." +
                "\nIndsæt et tal: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int number = int.Parse(Console.ReadLine());
            Console.ResetColor();

            if (number < 0)
            {
                Console.WriteLine("Tallet du har indtastet er negativt");
            }
            else if (number == 0)
            {
                Console.WriteLine("Tallet du har indtastet er lig med nul");
            }
            else if (number > 0)
            {
                Console.WriteLine("Tallet du har indtastet er positivt");
            }
            else
            {
                Console.WriteLine("Du har indtastet noget ugyldigt");
            }

            //Opgave 9
            Console.Write("\nLad os nu tjekke, om du er født i et skudår! \nIndtast i tal, hvad år du er født i: ");
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
