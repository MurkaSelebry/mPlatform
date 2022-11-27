using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mPlatform.MVVM.Model;
using mPlatform.Core;


namespace mPlatform.MVVM.ViewModel
{
    class MovieViewModel: ObservableObject
    {
        Movie movie;

        public MovieViewModel(Movie movie)
        {
            this.movie = movie;
        }
        public string ImageSource { get => movie.ImageSource; set => movie.ImageSource = value; }
        public string Url { get => movie.Url; set => movie.Url = value; }
        public MovieInfo Title { get => movie.Title; set => movie.Title = value; }

        public double Rating { get => movie.Rating; set
            {
                movie.Rating = value;
                OnPropertyChanged("Rating");
            }
            }


    }
}
