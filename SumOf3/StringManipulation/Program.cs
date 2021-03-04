using System;

namespace StringManipulation
{
    class Program
    {
        static string programming = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.Write(programming);
            

            Console.WriteLine("\n\nWhat word would you like to replace in the above statement?");
            string answerReplace = Console.ReadLine();

            Console.WriteLine($"\nWhat word would you like to replace {answerReplace} with?");
            string word = Console.ReadLine();

            if (programming.Contains(answerReplace) == false)
            {
                string backwards = "";
                Console.WriteLine($"Sorry, I could not find your word: {answerReplace}");
                for (int i = answerReplace.Length - 1; i >= 0; i--)
                {
                    backwards = backwards + answerReplace[i];
                }
                Console.WriteLine(backwards);
            }
            else
            {
                string newSentence = programming.Replace(answerReplace, word);
                Console.WriteLine($"\n{newSentence}");
            }
        }
    }
}
