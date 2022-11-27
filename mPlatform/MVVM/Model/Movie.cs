using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPlatform.MVVM.Model
{
    class Movie
    {
        private MovieInfo title;
        private string imageSource;
        private string url;
        private double rating;
       

        public string ImageSource { get => imageSource; set => imageSource = value; }
        public string Url { get => url; set => url = value; }
        internal MovieInfo Title { get => title; set => title = value; }
        public double Rating { get => rating; set => rating = value; }

        public Movie(MovieInfo title, string imageSource, string url, double rating)
        {
            Title = title;
            ImageSource = imageSource;
            Url = url;
            Rating = rating;
        }

        
    }
}
