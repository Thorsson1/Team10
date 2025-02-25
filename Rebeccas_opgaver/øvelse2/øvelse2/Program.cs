namespace øvelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg en mulighed:");
            Console.WriteLine("1: Celsius til Fahrenheit");
            Console.WriteLine("2: Fahrenheit til Celsius");

            int choice;
            bool isValid = int.TryParse(Console.ReadLine(), out choice);

            if (!isValid || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Ugyldigt valg.");
                return;
            }

            Console.Write("Indtast temperatur: ");
            double temperature;
            isValid = double.TryParse(Console.ReadLine(), out temperature);

            if (!isValid)
            {
                Console.WriteLine("Ugyldig temperatur.");
                return;
            }

            if (choice == 1)
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"Celsius: {temperature}°C = Fahrenheit: {fahrenheit:F2}°F");// F2 viser resultatet med 2 decimaler
            }
            else
            {
                double celsius = (temperature - 32) * 5 / 9;

            }
        }
    }
}

    

