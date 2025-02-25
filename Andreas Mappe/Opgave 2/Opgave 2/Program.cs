using System;

class CarApp
{    
    static double celsius;
    static double fahrenheit;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n- Temperaturkonvertering -");
            Console.WriteLine("1. Celsius til Fahrenheit");
            Console.WriteLine("2. Fahrenheit til Celsius");
            Console.WriteLine("3. Afslut");
            Console.Write("\nVælg en funktion (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Celcius_To_Fahrenheit();
                    break;
                case "2":
                    Fahrenheit_To_Celcius();
                    break;
                case "3":
                    Console.WriteLine("Program afsluttet.");
                    return;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    break;
            }
        }
    }

    static void Celcius_To_Fahrenheit()
    {
        Console.Write("Indtast temperatur i Celsius: ");
        string input = Console.ReadLine();
        celsius = Convert.ToDouble(input); 
        fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C er {fahrenheit}°F.");
    }

    static void Fahrenheit_To_Celcius()
    {
        Console.Write("Indtast temperatur i Fahrenheit: ");
        string input = Console.ReadLine();
        fahrenheit = Convert.ToDouble(input);  
        celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit}°F er {celsius}°C.");
    }
}