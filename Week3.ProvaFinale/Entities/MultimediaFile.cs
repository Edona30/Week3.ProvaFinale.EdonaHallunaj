using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ProvaFinale
{
    public abstract class MultimediaFile
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public MultimediaFile()
        {

        }
        public MultimediaFile(string title, string name, string lastname, DateTime birthdate)
        {
            Title = title;
            Author = new Author(name, lastname, birthdate);
        }

        static List<Author> authors = new List<Author>
        {
            new Author("Adele", "Adkins", new DateTime (1988,5,5)),
            new Author("Ermal", "Meta", new DateTime(1981,4,20)),
            new Author("Elhaida", "Dani", new DateTime(1993,2,17)),
            new Author ("Alanis", "Morissette", new DateTime(1974,6,1)),
            new Author("Matt", "Bellamy", new DateTime(1978,6,9)),
            new Author("Samuele", "Bersani", new DateTime(1970,10,1)),

        };

        public List<Author> Fetch()
        {
            return authors;
        }

        public virtual string Print()
            {
            return $"Title: {Title}, Author: {Author.Name} {Author.LastName}-{Author.Birthdate}";

        }
    }
}
