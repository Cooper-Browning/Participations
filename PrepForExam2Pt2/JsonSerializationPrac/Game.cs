using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializationPrac
{
    public class Game
    {
        public string Name {get; set;}
        public string Platform {get; set;}
        public string ReleaseDate {get; set;}
        public string Summary {get; set;}
        public string MetaScore {get; set;}
        public string UserReview { get; set; }

        public Game()
        {
            Name = string.Empty;
            Platform = string.Empty;
            ReleaseDate = string.Empty;
            Summary = string.Empty;
            MetaScore = string.Empty;
            UserReview = string.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
