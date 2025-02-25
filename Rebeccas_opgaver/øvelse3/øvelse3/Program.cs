using Microsoft.VisualBasic;

namespace øvelse3
{
    internal class Program
    {
        static void Main(string[] args)
        {//øvelse 3
            //Console.WriteLine("Indtast din højde:");
            //double Højde = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Indtast din vægt:");
            //double Vægt = Convert.ToDouble(Console.ReadLine());

            //double bmi = Vægt / (Højde * Højde);
            //Console.WriteLine("Dit BMI er " + bmi);

            //øvelse 4
            //int addition = 2 + 2;
            //int substraktion = 6 - 4;
            //int mulitiplikation = 6 * 3;
            //int divison = 25 / 5;
            //int modulus = 10 % 3;
            //Console.WriteLine($"sum: {addition} difference: {substraktion} product: {mulitiplikation} quotient: {divison} remainder: {modulus}");

            //øvelse 5
            //Console.WriteLine("Angiv radius:");
            //double radius = Convert.ToDouble(Console.ReadLine());

            //double area = double.Pi * radius;
            //double circumference = 2 * double.Pi * radius;

            //Console.WriteLine($"Area: {area} Circumference: {circumference}");

            //øvelse 6
            //int a = 15;
            //int b = 20;
            //Console.WriteLine("Is equal?" + (a == b));

            //Console.WriteLine("Is greater?" + (a > b)); 

            //Console.WriteLine("Is less?" + (a < b));

            //Console.WriteLine("Is greater or equal?" + (a >= b));

            //Console.WriteLine("Is greater or less?" + (a <= b));

            //øvelse 7
            //Console.WriteLine("Indtast et tal:");
            //int tal = Convert.ToInt32(Console.ReadLine());

            //if (tal == 0)
            //{
            //    Console.WriteLine("Tallet er 0");
            //}
            //else if (tal > 0)
            //{
            //    Console.WriteLine("Tallet er positivt");
            //}
            //else
            //{
            //    Console.WriteLine("Tallet er negativt");
            //}

            //øvelse 8

            Console.WriteLine("Indtast din karakter (A, B, C, D eller F):");
            char karakter = Convert.ToChar(Console.ReadLine());
            bool resultat = Bestået (karakter);
            if (resultat)
            {
                Console.WriteLine("Bestået");
            }
            else
            {
                Console.WriteLine("Ikke bestået");

            }

        }

        static bool Bestået(char karakter)
        {
            if (karakter == 'A' || karakter == 'B' || karakter == 'C' || karakter == 'D')


            {
                return true;

            }
            else
            {
                return false;

            }

        }
    }
}
