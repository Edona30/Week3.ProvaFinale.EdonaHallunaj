using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ProvaFinale
{
    internal class Podcast: MultimediaFile 
    {
        public string Description{ get; set; }
        public int Episode { get; set; }

        public Podcast()
        {

        }
        public Podcast(string title, string name, string lastname, DateTime birthdate, string description, int episode)
            : base(title, name, lastname, birthdate)
           
        {   
            Description = description;  
            Episode = episode;
        }
        public override string Print()
        {
            return $"Podcast -> {base.Print()}, Description: {Description}, Episode: {Episode}";
        }



    }
}
