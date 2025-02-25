namespace Team10
{
    internal class Program
    {
        static int age = 32;
        static double height = 1.70;
        static double weight = 59.5;
        static char initial = 'M';
        static string name = "Mia";
        static bool isStudent = true;
        static int fahrenheit = 0;
        static int celsius = 0;
        static double radius = 0.00;
        private static double resultArea;

        static void Main(string[] args)
        {
            // Opgave 1
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Initial: {initial}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Is Student: {isStudent}");

            // Opgave 2
            ConvertDegrees();

            // Opgave 3
            CalculateBMI();

            // Opgave 4
            CalculateResults();

            // Opgave 5
            CalculateCircle();

            // Opgave 6

            
        }

        static void ConvertDegrees()
        {
            Console.WriteLine("Vælg en temperatur der skal konverteres (Fahrenheit (skriv F) eller celsius (skriv C))");
            string degreeType = Console.ReadLine();
            if (degreeType != "C" && degreeType != "F")
            {
                Console.WriteLine("Vælg en korrekt temperaturtype");
            }
            if (degreeType == "C")
            {
                Console.WriteLine("Vælg en temperatur i Celsius der skal omregnes til fahrenheit: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double resultToFahrenheit = celsius * (9.0 / 5.0) + 32;
                Console.WriteLine($"Temperaturen {celsius}°C er omregnet til {resultToFahrenheit}°F");
            }
            else if (degreeType == "F")
            {
                Console.WriteLine("Vælg en temperatur i Fahrenheit der skal omregnes til Celsius: ");
                int fahrenheit = Convert.ToInt32(Console.ReadLine());
                int resultToCelsius = ((fahrenheit - 32) * 5 / 9);
                Console.WriteLine($"Temperaturen {fahrenheit}°F er omregnet til {resultToCelsius}°C");
            }

        }

        static void CalculateBMI()
        {
            Console.WriteLine("Indtast vægt: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast højde: ");
            height = Convert.ToDouble(Console.ReadLine());

            double resultBMI = weight / (height*height);

            Console.WriteLine($"Din BMi er: {resultBMI:F2}");
        }

        static void CalculateResults()
        {
            Console.WriteLine("Indtast et nummer:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast et nummer");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number + number2;
            int result2 = number - number2;
            int result3 = number * number2;
            int result4 = number / number2;
            int result5 = number2 % number2;

            Console.WriteLine($"Sum: {result} Difference: {result2} Product: {result3} Quotient: {result4} Remainder: {result5}");
        }

        static void CalculateCircle()
        {
            Console.WriteLine("Indtast en radius til udregning af areal og omkreds: ");
            radius = Convert.ToDouble(Console.ReadLine());
            double resultArea = radius * Math.PI;
            double resultCircum = 2 * Math.PI * radius;
            Console.WriteLine($"Area: {resultArea}, Circumference: {resultCircum}");
        }

        //Opgave 6
        //static void CompareResults()
        //{
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    int number2 = Convert.ToInt32(Console.ReadLine());
        //    int result = number + number2;
        //    switch (number)
        //    {
        //        case 1:
        //            if(number == number2)
        //            {
        //                Console.WriteLine("The number is equal");
        //            }
        //            break;
        //        case 2:
        //            if(number != number2) 
        //            {
        //                Console.WriteLine("The number is not equal");
        //            }
        //            break;

        //    }
        //}

        static void LeapYear()
        {

        }

    }
}
