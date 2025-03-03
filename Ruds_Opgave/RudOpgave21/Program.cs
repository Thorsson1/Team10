namespace RudOpgave21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cubeSide = 4;
            double cylinderRadius = 2.5;
            double cylinderHeight = 5;
            double pi = 3.1415926535897931;
            Console.WriteLine("Kubens areal er: " + KubeUdregning(cubeSide));
            Console.WriteLine("Cylinderens areal er: " + CylinderUdregning(cylinderRadius, cylinderHeight, pi));
            Console.ReadKey();
        }

        static int KubeUdregning( int length)
        {
            return 6 * length * length;
        }

        static double CylinderUdregning(double radius, double height, double pi)
        {
            return 2 * pi * radius * (radius + height);
        }
    }
}
