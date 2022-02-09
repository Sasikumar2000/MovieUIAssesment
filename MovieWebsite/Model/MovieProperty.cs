using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebsite.Model
{
    public class MovieProperty
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int YearOfRealised { get; set; }
        public int Rating { get; set; }
    }
}
