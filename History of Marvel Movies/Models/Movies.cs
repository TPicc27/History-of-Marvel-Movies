using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace History_of_Marvel_Movies.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Collection Number")]
        public int CollectionNumber { get; set; }
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        public Phases Phase { get; set; }
        public decimal Rating { get; set; }
        [DisplayName("Box Office")]
        public decimal BoxOffice { get; set; }
    }
}