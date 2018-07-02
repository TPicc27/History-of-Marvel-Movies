using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace History_of_Marvel_Movies.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeriesNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Seasons Season { get; set; }
        public decimal Rating { get; set; }
    }
}