namespace RudOpgave19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en sætning her: ");
            char vocal = Convert.ToChar(Console.ReadLine());
        }
            
        private readonly char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'æ', 'ø', 'å' };
        public int CountVowels(string text)
        {
            return text.ToLower().Count(x => vowels.Contains(x));
        }
    }
    }

