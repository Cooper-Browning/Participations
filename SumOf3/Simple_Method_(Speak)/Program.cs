using System;

namespace Simple_Method__Speak_
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            { 
                Console.WriteLine("Enter an animal to hear what sound it makes: dog, goat, monkey, cat>>");
                string animal = Console.ReadLine();
                Console.WriteLine($"The sound of a {animal} is: {AnimalSound(animal)}");

                Console.WriteLine("Would you like to enter another animal to hear its sound?");
                answer = Console.ReadLine().ToLower();
            } while (answer[0] == 'y');
            

            
        }

        static string AnimalSound(string animal)
        {
            if (animal.ToLower() == "dog")
            {
                return "woof";
            }
            else if (animal.ToLower() == "goat")
            {
                return "bleeeeat"; //I looked it up on google this is the sound of a goat ig
            }
            else if (animal.ToLower() == "monkey")
            {
                return "ooh ooh ah ah";
            }
            else if(animal.ToLower() == "cat")
            {
                return "meow";
            }
            else
            {
                return "I don't know what sound that animal makes";
            }
        }
    }
}
