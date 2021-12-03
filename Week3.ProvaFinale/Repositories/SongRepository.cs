using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ProvaFinale.Repositories
{
    public class SongRepository : IManager<Song>
    {
        static List<Song> songs = new List<Song>
        {
            new Song("En e Xanax", "Samuele", "Bersani", new DateTime(1970,10,1), Song.TypeEnum.Pop),
            new Song("Resistance", "Matt","Bellamy", new DateTime(1978,6,9), Song.TypeEnum.Rock),
            new Song("Starlight", "Matt","Bellamy", new DateTime(1978,6,9), Song.TypeEnum.Rock),
            new Song("Easy on me", "Adele", "Adkins", new DateTime (1988,5,5), Song.TypeEnum.Pop),
            new Song ("Underneath", "Alanis","Morissette", new DateTime(1974,6,1), Song.TypeEnum.Country),
            new Song ("Stelle Cadenti", "Ermal", "Meta", new DateTime(1981,4,20), Song.TypeEnum.Pop),
            new Song ("Jam Betu", "Elhaida", "Dani", new DateTime(1993,2,17), Song.TypeEnum.Blues)

        };
        public List<Song> Fetch()
        {
            return songs;
        }
    }
}
