using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    class Ticket
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public double Price { get; set; }
        public string SellDate { get; set; }
        public Movie movie { get; set; }
    }
    class Movie
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }
        public Poster poster { get; set; }
    }
    class Poster
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
    }
}
