using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ProvaFinale
{
    public class Song : MultimediaFile
    {
        
        public TypeEnum Type { get; set; }

        public Song()
        {

        }
        public Song(string title, string name, string lastname, DateTime birthdate, TypeEnum type)
            : base(title, name, lastname, birthdate) 
        {
            
            Type = type;
        }

        public enum TypeEnum
        {
            Country = 0,
            Pop = 1,
            Jazz = 2,
            Dark = 3,
            Rock = 4,
            Blues = 5,
        }
        public override string Print()
        {
            return $"Song -> {base.Print()}, Type: {Type}";
        }


    }
}
