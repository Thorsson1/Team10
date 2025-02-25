namespace RudOpgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til! Lad os omregne Celsius og Fahrenheit");
            Console.Write("Bruger du A) Celsius eller B) Fahrenheit? ");
            string warmType = Console.ReadLine().ToLower();

            if (warmType == "a")
            {
                Console.WriteLine("Du goer brug af Celsius");
                Console.Write("Hvor mange grader er der? ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("\nHvis der er " + celsius + "C, så betyder det, at der er " + fahrenheit + "F.");
            }
            else if (warmType == "b")
            {
                Console.WriteLine("Du goer brug af Fahrenheit");
                Console.Write("Hvor mange grader er der? ");
                double fahrenheit2 = Convert.ToDouble(Console.ReadLine());
                double celsius2 = (fahrenheit2 - 32) * 5 / 9;
                Console.WriteLine($"\nHvis der er {Math.Ceiling(fahrenheit2)} F, så betyder det, er der er {Math.Ceiling(celsius2)} C.");
            }
            else
            {
                Console.WriteLine("Ugyldigt svar. Proev igen");
            }
            Console.ReadKey();
        }
    }
}