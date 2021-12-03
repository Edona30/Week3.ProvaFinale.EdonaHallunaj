using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ProvaFinale
{
    internal class Episode
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public FlagEnum Flag { get; set; }

        public Episode()
        {

        }
        public Episode(string title, int duration, FlagEnum flag)
            
        {
            Title = title;
            Duration = duration;    
            Flag = flag;
        }
        public enum FlagEnum
        {
            Heard = 0,
            NotHeard = 1,
        }
        public string Print()
        {
            return $"Song ->Title: {Title}, Duration: {Duration}, Flag: {Flag}";
        }
    }
}
