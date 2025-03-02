namespace RudOpgave10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvilken dag på ugen er det?");
            string day = Console.ReadLine();

            switch (day)
            {
                case "1":
                    Console.WriteLine("Det betyder, at det er mandag!");
                    break;
                case "2":
                    Console.WriteLine("Det betyder, at det er tirsdag!");
                    break;
                case "3":
                    Console.WriteLine("Det betyder, at det er onsdag!");
                    break;
                case "4":
                    Console.WriteLine("Det betyder, at det er torsdag!");
                    break;
                case "5":
                    Console.WriteLine("Det betyder, at det er fredag!");
                    break;
                case "6":
                    Console.WriteLine("Det betyder, at det er lørdag!");
                    break;
                case "7":
                    Console.WriteLine("Det betyder, at det er søndag");
                    break;
            }
            Console.ReadKey();
        }
    }
}
