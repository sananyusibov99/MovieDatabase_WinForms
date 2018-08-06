using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseWinForms
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string ID { get; set; }

        public override string ToString()
        {
            return $"{Title} {Year}";
        }
    }
}
