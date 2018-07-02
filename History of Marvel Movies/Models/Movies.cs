using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace History_of_Marvel_Movies.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CollectionNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Phases Phase { get; set; }
        public decimal Rating { get; set; }
        public decimal BoxOffice { get; set; }
    }
}