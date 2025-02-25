using System;

class Program
{




    static void Main()
    {
        Console.WriteLine("Indtast radius af cirkel: ");
        Double Radius = Convert.ToDouble(Console.ReadLine());

        Double Areal = double.Pi * Radius*Radius;
        Double Omkreds = double.Pi * 2 * Radius;
        Console.Write($"areal: {Math.Round(Areal,4)}, Omkreds: {Math.Round(Omkreds,4)}");       

        
    }
}