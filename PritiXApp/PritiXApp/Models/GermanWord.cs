﻿using SQLite;

namespace PritiXApp.Models
{
    public class GermanWord : IWord
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Word { get; set; }

        public int Index { get; set; }
    }
}
