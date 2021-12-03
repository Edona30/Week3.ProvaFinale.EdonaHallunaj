using System;


namespace Week3.ProvaFinale

{
    class Program
    {
        public static Repositories.PodcastRepository pRep = new Repositories.PodcastRepository();
        public static Repositories.SongRepository sRep = new Repositories.SongRepository();
        
         public static void Main(string[] args)
        {
            char choice;
            bool exit = true;
            do
            {
                Console.WriteLine("Scegli un opzione:" +
                    "\n[a] Visualizzare tutte le canzoni" +
                    "\n[b] Visualizzare tutti i podcasts" +
                    "\n[c] Per filtrare le canzoni per genere" +
                    "\n[d] Per filtrare gli episodi per podcast" +
                    "\n[e] Per filtrare gli episodi per durata" +
                    "\n[f] Esci");

                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case 'a':
                        List<Song> songs = sRep.Fetch();
                        Print(songs);
                        ;
                        break;
                    case 'b':
                       
                        List<Podcast> podcasts = pRep.Fetch();
                        var podcast.Remove(3);  //Vorrei rimuvere l'informazione relativa agli episodi prima di stampare tutti i podcast
                        Print(podcasts);
                        break;
                    case 'c':
                        break;
                    case 'd':
                        
                        break;
                    case 'e':
                        break;
                    case 'f':
                        Console.WriteLine("Arrivederci!");
                        break;
                    default:
                        Console.WriteLine("Scelta non valida!");
                        break;


                }


            } while (exit);
        }

        private static void Print(List<Song> songs)
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song.Print());
            }
        }
        private static void Print(List<Podcast> podcasts)
        {
            foreach (var podcast in podcasts)
            {
                Console.WriteLine(podcast.Print());
            }
            
        }

    }
}
    
