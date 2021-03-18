using System;
using System.Collections.Generic;
using System.IO;

namespace Files_ReadingCSVAndParsing
{
    //WILL BE ON FINAL
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");
            List<string> states = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();


            for (int i = 3; i < lines.Length; i++)
            {
                //Region/state, SOCCER, FOOTBALL
                //"Alabama,16%,84%"
                string line = lines[i];

                //     0       1     2
                //{"Alabama","16%","84%"}
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);

                string soccerScoresAsString = pieces[1].Remove(pieces[1].Length - 1);
                double soccerScore = Convert.ToDouble(soccerScoresAsString) / 100;
                soccerScores.Add(soccerScore);

                footballScores.Add(Convert.ToDouble(pieces[2].Remove(pieces[1].Length - 1)) / 100);
                //Console.WriteLine(state);
            }

            for (int i = 0; i < footballScores.Count; i++)
            {
                string state = states[i];
                double soccer = soccerScores[i];
                double football = footballScores[i];

                if (soccer > football)
                {
                    Console.WriteLine(state);
                }
            }
            
            

        }
    }
}
