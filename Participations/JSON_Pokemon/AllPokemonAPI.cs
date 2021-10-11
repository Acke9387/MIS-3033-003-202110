﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Pokemon
{
    public class AllPokemonAPI
    {
        public int count { get; set; }

        public List<ResultItem> results { get; set; }

    }

    public class ResultItem
    {
        public string name {get;set;}
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
