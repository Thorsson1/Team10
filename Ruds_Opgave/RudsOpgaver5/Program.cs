using System.Security.Cryptography.X509Certificates;

namespace RudsOpgaver5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1415926535897931;
            Console.WriteLine("Velkommen til Ruds Opgave 5!" +
                "\nVi skal arbejde med at beregne en cirkels omkreds og areal");
            Console.Write("Hvad er cirklens radius i cm? ");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            double diameter = radius + radius;
            double areal = pi * radius * radius;
            double omkreds = pi * diameter;
            Console.WriteLine($"Hvis radius af cirklen er " + radius + "cm, saa er diameter " + diameter + "cm.");
                Console.WriteLine($"Arealet af cirklen er {Math.Ceiling(areal)}cm og omkredsen af cirklen er {Math.Ceiling(omkreds)}cm. ");

            Console.ReadKey();
        }
    }
}
