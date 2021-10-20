using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Serialization
{
    public class Game
    {
        public string name { get; set; }
        public string platform { get; set; }
        public DateTime release_date { get; set; }
        public string summary { get; set; }
        public int meta_score { get; set; }
        public string user_review { get; set; }

        public Game()
        {
            name = string.Empty;
            platform = string.Empty;
            release_date = DateTime.Now;
            summary = string.Empty;
            meta_score =  0;
            user_review = "";

        }

        public override string ToString()
        {
            return name;
        }

    }
}
