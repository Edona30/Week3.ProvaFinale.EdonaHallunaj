using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ProvaFinale
{
    public class Author
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
       

        public Author()
        {

        }
        public Author(string name, string lastname, DateTime birthdate)

        {
           Name = name;
           LastName = lastname;
           Birthdate = birthdate;
        }
        public string Print()
        {
            return $"Author -> Name: {Name}, Lastname: {LastName}, Birthdate: {Birthdate}";
        }
        
    }
}
