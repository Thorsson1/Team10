namespace RudOpgave11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hvilken horoskobs måned er du født i? \nFind ud af det, ved at indtaste hvilken måned er du født i! (skriv måned i tal mellem 1-12):\n");
            Console.ForegroundColor = ConsoleColor.Green;
            string astrology = Console.ReadLine();
            Console.ResetColor();

            switch (astrology)
            {
                case "1":
                    Console.WriteLine("Du er født i stenbukkens måned");
                    break;
                case "2":
                    Console.WriteLine("Du er født i vandmandens måned");
                    break;
                case "3":
                    Console.WriteLine("Du er født i fiskens måned");
                    break;
                case "4":
                    Console.WriteLine("Du er født i vædderens måned");
                    break;
                case "5":
                    Console.WriteLine("Du er født i tyrens måned");
                    break;
                case "6":
                    Console.WriteLine("Du er født i tvillingens måned");
                    break;
                case "7":
                    Console.WriteLine("Du er født i krebsens måned");
                    break;
                case "8":
                    Console.WriteLine("Du er født i løvens måned");
                    break;
                case "9":
                    Console.WriteLine("Du er født i jomfruens måned");
                    break;
                case "10":
                    Console.WriteLine("Du er født i vægtens måned");
                    break;
                case "11":
                    Console.WriteLine("Du er født i skorpionens måned");
                    break;
                case "12":
                    Console.WriteLine("Du er født i skyttens måned");
                    break;
            }

            Console.ReadKey();
        }
    }
}
