using System;

class Program
{




    static void Main()
    {
        Console.WriteLine("Indtast det første tal: ");
        Double tal1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Indtast det andet tal: ");
        Double tal2 = Convert.ToDouble(Console.ReadLine());

        double sum = tal1 + tal2;
        double produkt = tal1 * tal2;
        double difference = tal1 - tal2;
        double quotient = tal1 / tal2;
        double remainder = tal1 % tal2;

        Console.Write($"Sum: {sum}, Produkt: {produkt}, Difference: {difference}, Quotient: {quotient}, Remainder: {remainder}");
    }
}