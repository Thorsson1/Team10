namespace Rud_Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = ("Rud");
            int year = 30;
            double height = 1.64;
            char pronouns = 'F';
            bool isEqual = true;
            
            Console.WriteLine("Hej! Mit navn er " + name + " og jeg er " + year + " aar." +
                "\nMin hoejde er " + height + " og mit koen er: " + pronouns + " \nEr det sandt eller falsk at jeg er studerende?" + isEqual);

            Console.ReadKey();
        }
    }
}
