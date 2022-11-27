using System;

namespace mPlatform.MVVM.Model
{
    class MovieInfo
    {
        private string name;
        private DateTime releaseYear;
        private string director;
        private string country;
        private string[] genre;
        private string description;

        public string Name { get => name; set => name = value; }
        public DateTime ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public string Director { get => director; set => director = value; }
        public string Country { get => country; set => country = value; }
        public string[] Genre { get => genre; set => genre = value; }
        public string Description { get => description; set => description = value; }

        public MovieInfo(string name, DateTime releaseYear, string director, string country, string[] genre, string description, double rating)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Director = director;
            Country = country;
            Genre = genre;
            Description = description;
        }
    }
}