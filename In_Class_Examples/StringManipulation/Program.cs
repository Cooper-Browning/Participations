using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string artist = "tAyLoR SwIFt"; //tHe WeEknD, TRaVis sCoTt, 
            // string newValue = artist.ToLower(); //must create new string because strings are immutable
            artist = artist.ToLower();

            string artistWithProperName = artist.ToUpper()[0] + artist.Substring(1, 6) + artist.ToUpper()[7] + artist.Substring(8);

            string realProblem = "tAyLoR SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSh";
            string[] artistNames = realProblem.Split(", "); // splits into array of string after each comma. ',' because char
                                                           // or Split(", ")

            for (int i = 0; i < artistNames.Length; i++)
            {
                string tist = artistNames[i].ToLower();
                //int spaceLocation = tist.IndexOf(' ');
                //artistWithProperName = tist.ToUpper()[0] + tist.Substring(1, spaceLocation) + tist.ToUpper()[spaceLocation+1] + tist.Substring(spaceLocation+2);

                string[] names = tist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                firstName = firstName.ToUpper()[0] + firstName.Substring(1);
                lastName = lastName.ToUpper()[0] + lastName.Substring(1);

                Console.WriteLine($"{firstName} {lastName}"); //trim gets rid of leading or trailing white space
                
            }

            /*for (int i = 0; i < artistWithProperName.Length; i++)
            {
                Console.WriteLine(artistWithProperName[i]);
            }
            */

            Console.WriteLine(artistWithProperName);
        }
    }
}
