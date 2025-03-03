namespace RudOpgave20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firkantSide = 5;
            double cirkelRadius = 5.5;
            double pi = 3.1415926535897931;
            Console.WriteLine("Arealet af firkanten er: " + FirkantUdregning(firkantSide));
            Console.WriteLine("Arealet af cirklen er: " + Math.Ceiling(CirkelUdregning(cirkelRadius, pi)));
            Console.ReadKey();

            static int FirkantUdregning(int length)
            {
                return length * length;
            }
            static double CirkelUdregning(double radius, double pi)
            {
                return pi * radius * radius;
            }
        }
    }
}
