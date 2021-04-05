using System;
using System.Collections.Generic;
using System.IO;

namespace Attempt_at_DictionariesHW
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("Jane Eyre.txt");
            Dictionary<string, int> words = new Dictionary<string, int>();
            
            string[] pieces = new string[lines.Length-1];
           for (int i = 0; i < lines.Length; i++)
           {
               pieces = lines[i].Split(' ');
               for (int j = 0; j < pieces.Length; j++)
               {
                   pieces[j] = pieces[j].Replace(",", "").Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "")
                       .Replace("?", "").Replace(",", "*").Replace("/", "").Replace(":", "").Replace(".", "");
                   if (words.ContainsKey(pieces[j]) == false)
                   {
                       words.Add(pieces[j], 1);
                   }
                   else
                   {
                       words[pieces[j]] += 1;
                   }
               }   

           }

           foreach (string key in words.Keys)
           {
               Console.WriteLine($"{key}\t{words[key]}");
           }


           for (int i = 0; i < pieces.Length; i++)
           {
               if (words.ContainsKey(pieces[i]) == false)
               {
                   words.Add(pieces[i], 1);
               }
               else
               {
                   words[pieces[i]] += 1;
               }
           }
            
            foreach (string piece in pieces)
            {
                Console.WriteLine(piece);
            }

            /*
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            */
        }
    }
}
