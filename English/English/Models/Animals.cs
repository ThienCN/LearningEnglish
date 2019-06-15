using System;
using System.Collections.Generic;

namespace English.Models
{
    public partial class Animals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vietnamese { get; set; }
        public string ImageUrl { get; set; }
        public string PronounceUrl { get; set; }
        public string SoundUrl { get; set; }
    }
}
