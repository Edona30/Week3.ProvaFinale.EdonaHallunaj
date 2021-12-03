using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ProvaFinale.Repositories
{
    internal class PodcastRepository : IManager<Podcast>
    {
        static List<Podcast> podcasts = new List<Podcast>
        {
            new Podcast("The Essential", "S&P", "Global", new DateTime(1990,8,30), "Inchiesta", 49),
            new Podcast("Serial", "Sara", "Koening", new DateTime(1987,9,27),"Investigativo", 32),
           
        };
        public List<Podcast> Fetch()
        {
            return podcasts;
        }

        internal IEnumerable<Podcast> GetByTitle(string chosenTitle)
        {
            throw new NotImplementedException();
        }
    }
}
