using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace History_of_Marvel_Movies.Models
{
    public class Phases
    {
        public int Id { get; set; }
        public int Phase { get; set; }
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
    }
}