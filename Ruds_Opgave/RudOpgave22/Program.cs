namespace RudOpgave22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleLenght = 5;
            int triangleHeight = 5;
            double squareLength = 2.5;
            double squareHeight = 2.5;
            Console.WriteLine("Trekantens rumfang er: " + TrekantUdregning(triangleHeight, triangleLenght));
            Console.WriteLine("Rektanglens rumfang er: " + RektangelUdregning(squareLength, squareHeight));
            Console.ReadKey();
        }
        static double TrekantUdregning(int length, int height)
        {
            return 0.5 * length * height;
        }
        static double RektangelUdregning(double length, double height)
        {
            return 0.5 * length * height;
        }
    }
}
