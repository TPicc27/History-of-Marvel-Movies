using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace History_of_Marvel_Movies.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Series Number")]
        public int SeriesNumber { get; set; }
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        public Phases Phase { get; set; }
        public decimal Rating { get; set; }
    }
}