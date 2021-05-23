using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Joke //Object that contains properties
    {
        public int Id { get; set; }

        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        public Joke() //Constructor 
        {
           //Empty now, but will be used later
        }
    }
}
