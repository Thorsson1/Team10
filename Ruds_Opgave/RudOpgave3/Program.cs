namespace RudOpgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Ruds Opgave 3! Lad os beregne din BMI. " +
                "\nHusk bare at BMI har utroligt mange faldgrupper og lad den ikke doemme din vaerdi som individ " +
                "- you are beautifull no matter what<3");
            Console.Write("Hvad er din højde i meter? (skriv det paa foelgene maade: 1.50) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            double height = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("\nHvad er din vaegt i kg? \n");
            Console.ForegroundColor = ConsoleColor.Green;
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("\nDin hoejde er: " + height + "m. og du vejer: " + weight + "kg.");

            double bmi = weight / ((height / 100.0) * (height / 100.0));
            Console.WriteLine("\nDette betyder at din BMI er: " + bmi);
            if (bmi <= 18.5)
            {
                Console.WriteLine($"Med en BMI på {Math.Ceiling(bmi)} betyder det at dit BMI tal er i kategorien undervaegtig");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine($"Med en BMI på {Math.Ceiling(bmi)} betyder det at dit BMI tal er i kategorien normalvaegtig");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine($"Med en BMI på {Math.Ceiling(bmi)} betyder det at dit BMI tal er i kategorien overvaegtig");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine($"Med en BMI på {Math.Ceiling(bmi)} betyder det at dit BMI tal er i kategorien fedme");
            }
            else
            {
                Console.WriteLine("En fejl er opstaaet. Proev igen");
            }
            Console.ReadKey();
        }
    }
}
