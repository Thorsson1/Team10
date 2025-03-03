using System.ComponentModel.DataAnnotations;

namespace RudOpgave19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] inputstring = new char[100];
            int i, vowels, consonants, x;

            vowels = 0;
            consonants = 0;

            Console.WriteLine("Tilføj længden af den sætning, du vil indtaste senere:\n");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv en sætning:\n");
            for (i = 0; i < x; i++)
            {
                inputstring[i] = Convert.ToChar(Console.Read());
            }
 
            for (i = 0; inputstring[i] != '\0'; i++)
            {

                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U' ||
                    inputstring[i] == 'æ' || inputstring[i] == 'Æ' ||
                    inputstring[i] == 'ø' || inputstring[i] == 'Ø' ||
                    inputstring[i] == 'å' || inputstring[i] == 'Å' ||)
                {
                    vowels++;
                }

                else
                {
                    consonants++;
                }
            }
            Console.WriteLine("\nAntallet af forskellige vokaler = " + vowels);
            Console.WriteLine("Antallet af konsonanter = " + consonants);

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}


