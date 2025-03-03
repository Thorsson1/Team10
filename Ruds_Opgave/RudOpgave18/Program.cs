namespace RudOpgave18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string malkavian = "Se koderne baglaens";

            for (int i = 0; i < malkavian.Length; i++)
            {
                System.Console.Write(malkavian[malkavian.Length - i - 1]);
            }
            Console.ReadKey();
        }
    }
}
